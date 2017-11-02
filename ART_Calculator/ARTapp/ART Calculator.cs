using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ARTapp
{
    public partial class Form1 : Form
    {
        List<double> Times = new List<double>();
        List<double> Torques = new List<double>();
        List<double> Phases = new List<double>();

        List<double> Frozen_Times = new List<double>();
        List<double> Frozen_Torques = new List<double>();
        List<double> Frozen_Phases = new List<double>();

        List<double> LOWESSOutput_Torques = new List<double>();
        List<double> LOWESSOutput_Phases = new List<double>();

        private string fileName { get; set; }
        private string Frozen_fileName { get; set; }

        public Form1()
        {
            InitializeComponent();
            panel6.Hide();
        }

        private void OpenButton_Flowing_Click(object sender, EventArgs e)
        {
            FlowingPath.Clear();
            Times.Clear();
            Torques.Clear();
            Phases.Clear();
            Rawdata_Flowing.Rows.Clear();

            Notification.Text = "Load File";
            Notification.ForeColor = Color.Gray;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                RawdataInputFile file = new RawdataInputFile(fileName, Times, Torques, Phases);

                for (int i = 0; i < Times.Count; i++)
                { Rawdata_Flowing.Rows.Add(Times[i], Torques[i], Phases[i]); }

                FlowingPath.Text = fileName;
            }
        }

        private void OpenButton_Frozen_Click(object sender, EventArgs e)
        {
            FrozenPath.Clear();
            Frozen_Times.Clear();
            Frozen_Torques.Clear();
            Frozen_Phases.Clear();

            Notification.Text = "Load File";
            Notification.ForeColor = Color.Gray;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Frozen_fileName = openFileDialog1.FileName;
                RawdataInputFile file = new RawdataInputFile(Frozen_fileName, Frozen_Times, Frozen_Torques, Frozen_Phases);

                FrozenPath.Text = Frozen_fileName;
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            textBox_EffectiveTorque.Clear();
            textBox_EffectivePhaseLag.Clear();

            Notification.Text = "Smoothing...";
            Notification.ForeColor = Color.Blue;

            #region Smoothing process

            double[] LOWESS_Times = Times.ToArray();
            double[] LOWESS_Torques = Torques.ToArray();
            double[] LOWESS_Phases = Phases.ToArray();

            double Bandwidth = double.Parse(textBox_Bandwidth.Text) / Times.Count;
            int Iter = int.Parse(textBox_Iteration.Text);

            LOWESS smoothTQ = new LOWESS(Bandwidth, Iter);
            LOWESS smoothPH = new LOWESS(Bandwidth, Iter);
            LOWESS_Torques = smoothTQ.smooth(LOWESS_Times, LOWESS_Torques);
            LOWESS_Phases = smoothPH.smooth(LOWESS_Times, LOWESS_Phases);

            foreach (var item in LOWESS_Torques)
            {
                LOWESSOutput_Torques.Add(item);
            }

            foreach (var item1 in LOWESS_Phases)
            {
                LOWESSOutput_Phases.Add(item1);
            }

            #endregion

            #region Calculation Result

            Notification.Text = "Calcuation...";
            Notification.ForeColor = Color.Blue;

            int SignalPeriod = int.Parse(textBox_SignalPeriod.Text);
            double TestPeriod = double.Parse(textBox_TestPeriod.Text);
            double CrossTime = Times[1];

            PositivePart p_Torque = new PositivePart(LOWESS_Torques);
            PositivePart p_Phase = new PositivePart(LOWESS_Phases);
            NegativePart n_Torque = new NegativePart(LOWESS_Torques);
            NegativePart n_Phase = new NegativePart(LOWESS_Phases);

            #region Frozen Process

            double[] LOWESS_FrozenTime = Frozen_Times.ToArray();
            double[] LOWESS_FrozenTorque = Frozen_Torques.ToArray();
            FrozenAnalysis frozenAnalysis = new FrozenAnalysis();
            double FrozenTQ = frozenAnalysis.FrozenProcedure(LOWESS_FrozenTime, LOWESS_FrozenTorque);

            #endregion

            double P_EffectiveTorque = p_Torque.CalculateEffectiveTorque(p_Torque.P_PeakIndex(),
                                                                                                                         p_Phase.P_PeakIndex(),
                                                                                                                         p_Torque.P_PeakData(),
                                                                                                                         SignalPeriod, CrossTime,
                                                                                                                         TestPeriod, FrozenTQ);

            double N_EffectiveTorque = n_Torque.CalculateEffectiveTorque(n_Torque.N_PeakIndex(),
                                                                                                                         n_Phase.N_PeakIndex(),
                                                                                                                         n_Torque.N_PeakData(),
                                                                                                                         SignalPeriod,
                                                                                                                         CrossTime,
                                                                                                                         TestPeriod, FrozenTQ);

            double P_EffectivePhaseLag = p_Phase.CalculateEffectivePhaseLag(p_Torque.P_PeakIndex(),
                                                                                                                                p_Phase.P_PeakIndex(),
                                                                                                                                p_Torque.P_PeakData(),
                                                                                                                                SignalPeriod,
                                                                                                                                CrossTime,
                                                                                                                                TestPeriod, FrozenTQ);
            double N_EffectivePhaseLag = n_Phase.CalculateEffectivePhaseLag(n_Torque.N_PeakIndex(),
                                                                                                                                n_Phase.N_PeakIndex(),
                                                                                                                                n_Torque.N_PeakData(),
                                                                                                                                SignalPeriod,
                                                                                                                                CrossTime,
                                                                                                                                TestPeriod, FrozenTQ);

            double Total_EffectiveTorque = (P_EffectiveTorque + N_EffectiveTorque) / 2;
            double Total_EffectivePhaseLag = (P_EffectivePhaseLag + N_EffectivePhaseLag) / 2;

            textBox_EffectiveTorque.Text = Total_EffectiveTorque.ToString();
            textBox_EffectivePhaseLag.Text = Total_EffectivePhaseLag.ToString();

            Notification.Text = "Complete!!!";
            Notification.ForeColor = Color.Red;
            #endregion

            stopwatch.Stop();
            watch.Text = stopwatch.Elapsed.TotalSeconds.ToString() + "초";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SaveFileName = saveFileDialog1.FileName;
                //File.WriteAllText(SaveFileName, textBox1.Text);

                string[] CalResultWrite = new string[Times.Count];
                double[] LOWESSOutput_Times = Times.ToArray();
                double[] LOWESSOutput_Torque = LOWESSOutput_Torques.ToArray();
                double[] LOWESSOutput_Phase = LOWESSOutput_Phases.ToArray();

                Parallel.For(0, Times.Count, ii => { CalResultWrite[ii] = Convert.ToString(Times[ii]).PadRight(8) + "\t" + Convert.ToString(LOWESSOutput_Torques[ii]).PadRight(16) + "\t" + Convert.ToString(LOWESSOutput_Phase[ii]).PadRight(8); });

                File.WriteAllLines(SaveFileName, CalResultWrite);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                FlowingPath.Clear();
                FrozenPath.Clear();
                FlowingPath.Text = File.ReadAllText(fileName);
                FrozenPath.Text = fileName;
            }
        }

        public string ShowFileOpenDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();    //파일오픈창 생성 및 설정
            ofd.Title = "파일 오픈";
            ofd.FileName = "test";
            ofd.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";

            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                string fileName = ofd.SafeFileName; //File명과 확장자를 가지고 온다.
                string fileFullName = ofd.FileName; //File경로와 File명을 모두 가지고 온다.
                string filePath = fileFullName.Replace(fileName, ""); //File경로만 가지고 온다.

                fileName = ofd.FileName;
                FlowingPath.Text = File.ReadAllText(fileName);
                //출력 예제용 로직
                //textBox1.Text = "File Name  : " + fileName;
                FrozenPath.Text = "Full Name  : " + fileFullName;
                textBox_Bandwidth.Text = "File Path  : " + filePath;

                //File경로 + 파일명 리턴
                return fileFullName;
            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == DialogResult.Cancel)
            {
                return "";
            }
            return "";
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                File.WriteAllText(fileName, FlowingPath.Text);
            }
        }

        private void showPlotButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3000; i++)
            {
                TorqueChart.Series["RawData"].Points.AddXY(Times[i], Torques[i]);
                PhaseChart.Series["RawData"].Points.AddXY(Times[i], Phases[i]);
                TorqueChart.Series["LOWESS"].Points.AddXY(Times[i], LOWESSOutput_Torques[i]);
                PhaseChart.Series["LOWESS"].Points.AddXY(Times[i], LOWESSOutput_Phases[i]);
            }

            panel6.Show();
            TorqueChart.Show();
            PhaseChart.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Notification_Click(object sender, EventArgs e)
        {

        }
    }
}

