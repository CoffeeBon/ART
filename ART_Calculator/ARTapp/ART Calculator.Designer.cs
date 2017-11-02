namespace ARTapp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlowingPath = new System.Windows.Forms.TextBox();
            this.FrozenPath = new System.Windows.Forms.TextBox();
            this.textBox_Bandwidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Iteration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenButton_Flowing = new System.Windows.Forms.Button();
            this.OpenButton_Frozen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_EffectiveTorque = new System.Windows.Forms.TextBox();
            this.textBox_EffectivePhaseLag = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Rawdata_Flowing = new System.Windows.Forms.DataGridView();
            this.Time_FF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Torque_FF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll_FF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_SignalPeriod = new System.Windows.Forms.TextBox();
            this.textBox_TestPeriod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Notification = new System.Windows.Forms.Button();
            this.PhaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.visualChartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TorqueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.showPlotButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.watch = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rawdata_Flowing)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualChartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TorqueChart)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1294, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기OToolStripMenuItem,
            this.저장SToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(86, 32);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.열기OToolStripMenuItem.Text = "열기(O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.저장SToolStripMenuItem.Text = "저장(S)";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // FlowingPath
            // 
            this.FlowingPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowingPath.Location = new System.Drawing.Point(15, 32);
            this.FlowingPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FlowingPath.Name = "FlowingPath";
            this.FlowingPath.Size = new System.Drawing.Size(401, 25);
            this.FlowingPath.TabIndex = 1;
            // 
            // FrozenPath
            // 
            this.FrozenPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrozenPath.Location = new System.Drawing.Point(16, 32);
            this.FrozenPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FrozenPath.Name = "FrozenPath";
            this.FrozenPath.Size = new System.Drawing.Size(399, 25);
            this.FrozenPath.TabIndex = 1;
            // 
            // textBox_Bandwidth
            // 
            this.textBox_Bandwidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Bandwidth.Location = new System.Drawing.Point(201, 65);
            this.textBox_Bandwidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Bandwidth.Name = "textBox_Bandwidth";
            this.textBox_Bandwidth.Size = new System.Drawing.Size(164, 25);
            this.textBox_Bandwidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flowing Test File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frozen Test File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Smoothing Parameter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Num. of Data in Window Span (= N x f)";
            // 
            // textBox_Iteration
            // 
            this.textBox_Iteration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Iteration.Location = new System.Drawing.Point(201, 121);
            this.textBox_Iteration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Iteration.Name = "textBox_Iteration";
            this.textBox_Iteration.Size = new System.Drawing.Size(164, 25);
            this.textBox_Iteration.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Num. of Iteration";
            // 
            // OpenButton_Flowing
            // 
            this.OpenButton_Flowing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButton_Flowing.Location = new System.Drawing.Point(330, 61);
            this.OpenButton_Flowing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenButton_Flowing.Name = "OpenButton_Flowing";
            this.OpenButton_Flowing.Size = new System.Drawing.Size(86, 29);
            this.OpenButton_Flowing.TabIndex = 4;
            this.OpenButton_Flowing.Text = "Open(O)";
            this.OpenButton_Flowing.UseVisualStyleBackColor = true;
            this.OpenButton_Flowing.Click += new System.EventHandler(this.OpenButton_Flowing_Click);
            // 
            // OpenButton_Frozen
            // 
            this.OpenButton_Frozen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButton_Frozen.Location = new System.Drawing.Point(330, 61);
            this.OpenButton_Frozen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenButton_Frozen.Name = "OpenButton_Frozen";
            this.OpenButton_Frozen.Size = new System.Drawing.Size(86, 29);
            this.OpenButton_Frozen.TabIndex = 4;
            this.OpenButton_Frozen.Text = "Open(O)";
            this.OpenButton_Frozen.UseVisualStyleBackColor = true;
            this.OpenButton_Frozen.Click += new System.EventHandler(this.OpenButton_Frozen_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FlowingPath);
            this.panel1.Controls.Add(this.OpenButton_Flowing);
            this.panel1.Location = new System.Drawing.Point(405, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 95);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.Controls.Add(this.OpenButton_Frozen);
            this.panel2.Controls.Add(this.FrozenPath);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(405, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 95);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_Bandwidth);
            this.panel3.Controls.Add(this.textBox_Iteration);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(405, 238);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 153);
            this.panel3.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(368, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = "[개]";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(126, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "(Default = 2)";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBox_EffectiveTorque);
            this.panel4.Controls.Add(this.textBox_EffectivePhaseLag);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(405, 501);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 125);
            this.panel4.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Result";
            // 
            // textBox_EffectiveTorque
            // 
            this.textBox_EffectiveTorque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_EffectiveTorque.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_EffectiveTorque.Location = new System.Drawing.Point(169, 42);
            this.textBox_EffectiveTorque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_EffectiveTorque.Name = "textBox_EffectiveTorque";
            this.textBox_EffectiveTorque.Size = new System.Drawing.Size(196, 29);
            this.textBox_EffectiveTorque.TabIndex = 1;
            // 
            // textBox_EffectivePhaseLag
            // 
            this.textBox_EffectivePhaseLag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_EffectivePhaseLag.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_EffectivePhaseLag.Location = new System.Drawing.Point(169, 81);
            this.textBox_EffectivePhaseLag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_EffectivePhaseLag.Name = "textBox_EffectivePhaseLag";
            this.textBox_EffectivePhaseLag.Size = new System.Drawing.Size(196, 29);
            this.textBox_EffectivePhaseLag.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "[deg]";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "[Nm]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Effective Torque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Effective PhaseLag";
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RunButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RunButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.ForeColor = System.Drawing.Color.DarkRed;
            this.RunButton.Location = new System.Drawing.Point(11, 4);
            this.RunButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(119, 54);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(323, 64);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(119, 54);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Rawdata_Flowing
            // 
            this.Rawdata_Flowing.AllowUserToAddRows = false;
            this.Rawdata_Flowing.AllowUserToDeleteRows = false;
            this.Rawdata_Flowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rawdata_Flowing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time_FF,
            this.Torque_FF,
            this.Roll_FF});
            this.Rawdata_Flowing.Dock = System.Windows.Forms.DockStyle.Left;
            this.Rawdata_Flowing.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Rawdata_Flowing.Location = new System.Drawing.Point(0, 36);
            this.Rawdata_Flowing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rawdata_Flowing.Name = "Rawdata_Flowing";
            this.Rawdata_Flowing.RowTemplate.Height = 23;
            this.Rawdata_Flowing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Rawdata_Flowing.Size = new System.Drawing.Size(394, 720);
            this.Rawdata_Flowing.TabIndex = 0;
            // 
            // Time_FF
            // 
            this.Time_FF.HeaderText = "Time";
            this.Time_FF.MaxInputLength = 3000;
            this.Time_FF.Name = "Time_FF";
            // 
            // Torque_FF
            // 
            this.Torque_FF.HeaderText = "Torque";
            this.Torque_FF.MaxInputLength = 3000;
            this.Torque_FF.Name = "Torque_FF";
            // 
            // Roll_FF
            // 
            this.Roll_FF.HeaderText = "Roll Angle";
            this.Roll_FF.MaxInputLength = 3000;
            this.Roll_FF.Name = "Roll_FF";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.textBox_SignalPeriod);
            this.panel5.Controls.Add(this.textBox_TestPeriod);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(405, 393);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(431, 105);
            this.panel5.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(367, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "[sec]";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(368, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "[개]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(257, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "ART Calculation Parameter";
            // 
            // textBox_SignalPeriod
            // 
            this.textBox_SignalPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SignalPeriod.Location = new System.Drawing.Point(169, 37);
            this.textBox_SignalPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_SignalPeriod.Name = "textBox_SignalPeriod";
            this.textBox_SignalPeriod.Size = new System.Drawing.Size(196, 25);
            this.textBox_SignalPeriod.TabIndex = 1;
            // 
            // textBox_TestPeriod
            // 
            this.textBox_TestPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TestPeriod.Location = new System.Drawing.Point(169, 71);
            this.textBox_TestPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_TestPeriod.Name = "textBox_TestPeriod";
            this.textBox_TestPeriod.Size = new System.Drawing.Size(196, 25);
            this.textBox_TestPeriod.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(13, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Num. of Signal Period";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Test Roll Period";
            // 
            // Notification
            // 
            this.Notification.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Notification.ForeColor = System.Drawing.Color.Black;
            this.Notification.Location = new System.Drawing.Point(11, 66);
            this.Notification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(306, 49);
            this.Notification.TabIndex = 3;
            this.Notification.Text = "Ready";
            this.Notification.UseVisualStyleBackColor = true;
            this.Notification.Click += new System.EventHandler(this.Notification_Click);
            // 
            // PhaseChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PhaseChart.ChartAreas.Add(chartArea1);
            this.PhaseChart.DataSource = this.visualChartBindingSource;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsDockedInsideChartArea = false;
            legend1.MaximumAutoSize = 30F;
            legend1.Name = "Legend1";
            this.PhaseChart.Legends.Add(legend1);
            this.PhaseChart.Location = new System.Drawing.Point(3, 382);
            this.PhaseChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhaseChart.Name = "PhaseChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 4;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "RawData";
            series1.XValueMember = "Time";
            series1.YValueMembers = "RawDataPhase";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerSize = 3;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "LOWESS";
            series2.XValueMember = "Time";
            series2.YValueMembers = "LOWESSPhase";
            this.PhaseChart.Series.Add(series1);
            this.PhaseChart.Series.Add(series2);
            this.PhaseChart.Size = new System.Drawing.Size(431, 340);
            this.PhaseChart.TabIndex = 10;
            this.PhaseChart.Text = "chart2";
            title1.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "RawData";
            title1.Text = "Roll Angle Plot";
            this.PhaseChart.Titles.Add(title1);
            // 
            // TorqueChart
            // 
            chartArea2.Name = "ChartArea1";
            this.TorqueChart.ChartAreas.Add(chartArea2);
            this.TorqueChart.DataSource = this.visualChartBindingSource;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BorderColor = System.Drawing.Color.Black;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.IsDockedInsideChartArea = false;
            legend2.MaximumAutoSize = 30F;
            legend2.Name = "Legend1";
            this.TorqueChart.Legends.Add(legend2);
            this.TorqueChart.Location = new System.Drawing.Point(3, 8);
            this.TorqueChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TorqueChart.Name = "TorqueChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerSize = 4;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "RawData";
            series3.XValueMember = "Time";
            series3.YValueMembers = "RawDataTorque";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerSize = 3;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "LOWESS";
            series4.XValueMember = "Time";
            series4.YValueMembers = "LOWESSTorque";
            this.TorqueChart.Series.Add(series3);
            this.TorqueChart.Series.Add(series4);
            this.TorqueChart.Size = new System.Drawing.Size(431, 340);
            this.TorqueChart.TabIndex = 11;
            this.TorqueChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "RawData";
            title2.Text = "Torque Plot";
            this.TorqueChart.Titles.Add(title2);
            // 
            // showPlotButton
            // 
            this.showPlotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showPlotButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showPlotButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showPlotButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPlotButton.ForeColor = System.Drawing.Color.DarkRed;
            this.showPlotButton.Location = new System.Drawing.Point(323, 4);
            this.showPlotButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showPlotButton.Name = "showPlotButton";
            this.showPlotButton.Size = new System.Drawing.Size(119, 54);
            this.showPlotButton.TabIndex = 12;
            this.showPlotButton.Text = "Show Plot";
            this.showPlotButton.UseVisualStyleBackColor = false;
            this.showPlotButton.Click += new System.EventHandler(this.showPlotButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TorqueChart);
            this.panel6.Controls.Add(this.PhaseChart);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(846, 36);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(448, 720);
            this.panel6.TabIndex = 13;
            // 
            // watch
            // 
            this.watch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.watch.FlatAppearance.BorderSize = 0;
            this.watch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watch.ForeColor = System.Drawing.Color.Black;
            this.watch.Location = new System.Drawing.Point(140, 4);
            this.watch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.watch.Name = "watch";
            this.watch.Size = new System.Drawing.Size(163, 54);
            this.watch.TabIndex = 3;
            this.watch.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.RunButton);
            this.panel7.Controls.Add(this.watch);
            this.panel7.Controls.Add(this.Notification);
            this.panel7.Controls.Add(this.showPlotButton);
            this.panel7.Controls.Add(this.SaveButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(394, 629);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(452, 127);
            this.panel7.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1294, 756);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Rawdata_Flowing);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ART Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rawdata_Flowing)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualChartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TorqueChart)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.TextBox FlowingPath;
        private System.Windows.Forms.TextBox FrozenPath;
        private System.Windows.Forms.TextBox textBox_Bandwidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Iteration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OpenButton_Flowing;
        private System.Windows.Forms.Button OpenButton_Frozen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_EffectiveTorque;
        private System.Windows.Forms.TextBox textBox_EffectivePhaseLag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView Rawdata_Flowing;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_SignalPeriod;
        private System.Windows.Forms.TextBox textBox_TestPeriod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_FF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Torque_FF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll_FF;
        private System.Windows.Forms.Button Notification;
        private System.Windows.Forms.DataVisualization.Charting.Chart PhaseChart;
        private System.Windows.Forms.BindingSource visualChartBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart TorqueChart;
        private System.Windows.Forms.Button showPlotButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button watch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
    }
}

