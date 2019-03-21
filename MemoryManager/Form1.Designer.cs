namespace MemoryManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 90D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleBar = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.minButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.windowIcon = new System.Windows.Forms.PictureBox();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.loadlocallyHelpButton = new System.Windows.Forms.Button();
            this.savelocallyHelpButton = new System.Windows.Forms.Button();
            this.loadlocallyCheckBox = new System.Windows.Forms.CheckBox();
            this.savelocallyCheckBox = new System.Windows.Forms.CheckBox();
            this.safemodeHelpButton = new System.Windows.Forms.Button();
            this.safemodeCheckBox = new System.Windows.Forms.CheckBox();
            this.snapshotrateNumeric = new System.Windows.Forms.NumericUpDown();
            this.usagealertsHelpButton = new System.Windows.Forms.Button();
            this.usagealertsCheckBox = new System.Windows.Forms.CheckBox();
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            this.snapshotrateHelpButton = new System.Windows.Forms.Button();
            this.snapshotrateLabel = new System.Windows.Forms.Label();
            this.CurrentSnapshotChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.snapshotmanagerButton = new System.Windows.Forms.Button();
            this.changesnapshotButton = new System.Windows.Forms.Button();
            this.hourlyusageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.notenoughdataPictureBox = new System.Windows.Forms.PictureBox();
            this.nosnapshotloadedPictureBox = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).BeginInit();
            this.settingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapshotrateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentSnapshotChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyusageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notenoughdataPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosnapshotloadedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.titleBar.Controls.Add(this.titleLabel);
            this.titleBar.Controls.Add(this.minButton);
            this.titleBar.Controls.Add(this.closeButton);
            this.titleBar.Controls.Add(this.windowIcon);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(480, 33);
            this.titleBar.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(123, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(231, 18);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Daymon\'s Memory Manager";
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.Location = new System.Drawing.Point(414, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(33, 33);
            this.minButton.TabIndex = 2;
            this.minButton.Text = "_";
            this.minButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(447, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 33);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // windowIcon
            // 
            this.windowIcon.Image = global::MemoryManager.Properties.Resources.cpu_Srk_icon;
            this.windowIcon.Location = new System.Drawing.Point(3, 3);
            this.windowIcon.Name = "windowIcon";
            this.windowIcon.Size = new System.Drawing.Size(24, 24);
            this.windowIcon.TabIndex = 1;
            this.windowIcon.TabStop = false;
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.loadlocallyHelpButton);
            this.settingsBox.Controls.Add(this.savelocallyHelpButton);
            this.settingsBox.Controls.Add(this.loadlocallyCheckBox);
            this.settingsBox.Controls.Add(this.savelocallyCheckBox);
            this.settingsBox.Controls.Add(this.safemodeHelpButton);
            this.settingsBox.Controls.Add(this.safemodeCheckBox);
            this.settingsBox.Controls.Add(this.snapshotrateNumeric);
            this.settingsBox.Controls.Add(this.usagealertsHelpButton);
            this.settingsBox.Controls.Add(this.usagealertsCheckBox);
            this.settingsBox.Controls.Add(this.enabledCheckBox);
            this.settingsBox.Controls.Add(this.snapshotrateHelpButton);
            this.settingsBox.Controls.Add(this.snapshotrateLabel);
            this.settingsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBox.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBox.Location = new System.Drawing.Point(12, 39);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(451, 114);
            this.settingsBox.TabIndex = 1;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // loadlocallyHelpButton
            // 
            this.loadlocallyHelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.loadlocallyHelpButton.FlatAppearance.BorderSize = 0;
            this.loadlocallyHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.loadlocallyHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadlocallyHelpButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadlocallyHelpButton.Location = new System.Drawing.Point(417, 79);
            this.loadlocallyHelpButton.Name = "loadlocallyHelpButton";
            this.loadlocallyHelpButton.Size = new System.Drawing.Size(26, 26);
            this.loadlocallyHelpButton.TabIndex = 11;
            this.loadlocallyHelpButton.Text = "?";
            this.loadlocallyHelpButton.UseVisualStyleBackColor = false;
            // 
            // savelocallyHelpButton
            // 
            this.savelocallyHelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.savelocallyHelpButton.FlatAppearance.BorderSize = 0;
            this.savelocallyHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.savelocallyHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savelocallyHelpButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savelocallyHelpButton.Location = new System.Drawing.Point(417, 48);
            this.savelocallyHelpButton.Name = "savelocallyHelpButton";
            this.savelocallyHelpButton.Size = new System.Drawing.Size(26, 26);
            this.savelocallyHelpButton.TabIndex = 11;
            this.savelocallyHelpButton.Text = "?";
            this.savelocallyHelpButton.UseVisualStyleBackColor = false;
            // 
            // loadlocallyCheckBox
            // 
            this.loadlocallyCheckBox.AutoSize = true;
            this.loadlocallyCheckBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.loadlocallyCheckBox.Location = new System.Drawing.Point(303, 83);
            this.loadlocallyCheckBox.Name = "loadlocallyCheckBox";
            this.loadlocallyCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loadlocallyCheckBox.Size = new System.Drawing.Size(108, 18);
            this.loadlocallyCheckBox.TabIndex = 10;
            this.loadlocallyCheckBox.Text = ":Load Locally";
            this.loadlocallyCheckBox.UseVisualStyleBackColor = true;
            this.loadlocallyCheckBox.CheckedChanged += new System.EventHandler(this.loadlocallyCheckBox_CheckedChanged);
            // 
            // savelocallyCheckBox
            // 
            this.savelocallyCheckBox.AutoSize = true;
            this.savelocallyCheckBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.savelocallyCheckBox.Location = new System.Drawing.Point(303, 53);
            this.savelocallyCheckBox.Name = "savelocallyCheckBox";
            this.savelocallyCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.savelocallyCheckBox.Size = new System.Drawing.Size(108, 18);
            this.savelocallyCheckBox.TabIndex = 10;
            this.savelocallyCheckBox.Text = ":Save Locally";
            this.savelocallyCheckBox.UseVisualStyleBackColor = true;
            this.savelocallyCheckBox.CheckedChanged += new System.EventHandler(this.savelocallyCheckBox_CheckedChanged);
            // 
            // safemodeHelpButton
            // 
            this.safemodeHelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.safemodeHelpButton.FlatAppearance.BorderSize = 0;
            this.safemodeHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.safemodeHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.safemodeHelpButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safemodeHelpButton.Location = new System.Drawing.Point(417, 20);
            this.safemodeHelpButton.Name = "safemodeHelpButton";
            this.safemodeHelpButton.Size = new System.Drawing.Size(26, 26);
            this.safemodeHelpButton.TabIndex = 9;
            this.safemodeHelpButton.Text = "?";
            this.safemodeHelpButton.UseVisualStyleBackColor = false;
            // 
            // safemodeCheckBox
            // 
            this.safemodeCheckBox.AutoSize = true;
            this.safemodeCheckBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.safemodeCheckBox.Location = new System.Drawing.Point(314, 24);
            this.safemodeCheckBox.Name = "safemodeCheckBox";
            this.safemodeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.safemodeCheckBox.Size = new System.Drawing.Size(97, 18);
            this.safemodeCheckBox.TabIndex = 8;
            this.safemodeCheckBox.Text = ":Safe Mode";
            this.safemodeCheckBox.UseVisualStyleBackColor = true;
            this.safemodeCheckBox.CheckedChanged += new System.EventHandler(this.safemodeCheckBox_CheckedChanged);
            // 
            // snapshotrateNumeric
            // 
            this.snapshotrateNumeric.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic);
            this.snapshotrateNumeric.Location = new System.Drawing.Point(117, 20);
            this.snapshotrateNumeric.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.snapshotrateNumeric.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.snapshotrateNumeric.Name = "snapshotrateNumeric";
            this.snapshotrateNumeric.Size = new System.Drawing.Size(100, 26);
            this.snapshotrateNumeric.TabIndex = 3;
            this.snapshotrateNumeric.ThousandsSeparator = true;
            this.snapshotrateNumeric.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.snapshotrateNumeric.ValueChanged += new System.EventHandler(this.snapshotrateNumeric_ValueChanged);
            // 
            // usagealertsHelpButton
            // 
            this.usagealertsHelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.usagealertsHelpButton.FlatAppearance.BorderSize = 0;
            this.usagealertsHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.usagealertsHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usagealertsHelpButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usagealertsHelpButton.Location = new System.Drawing.Point(137, 71);
            this.usagealertsHelpButton.Name = "usagealertsHelpButton";
            this.usagealertsHelpButton.Size = new System.Drawing.Size(26, 26);
            this.usagealertsHelpButton.TabIndex = 7;
            this.usagealertsHelpButton.Text = "?";
            this.usagealertsHelpButton.UseVisualStyleBackColor = false;
            // 
            // usagealertsCheckBox
            // 
            this.usagealertsCheckBox.AutoSize = true;
            this.usagealertsCheckBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.usagealertsCheckBox.Location = new System.Drawing.Point(20, 76);
            this.usagealertsCheckBox.Name = "usagealertsCheckBox";
            this.usagealertsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usagealertsCheckBox.Size = new System.Drawing.Size(111, 18);
            this.usagealertsCheckBox.TabIndex = 6;
            this.usagealertsCheckBox.Text = ":Usage Alerts";
            this.usagealertsCheckBox.UseVisualStyleBackColor = true;
            this.usagealertsCheckBox.CheckedChanged += new System.EventHandler(this.usagealertsCheckBox_CheckedChanged);
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.enabledCheckBox.Location = new System.Drawing.Point(49, 52);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enabledCheckBox.Size = new System.Drawing.Size(82, 18);
            this.enabledCheckBox.TabIndex = 5;
            this.enabledCheckBox.Text = ":Enabled";
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            this.enabledCheckBox.CheckedChanged += new System.EventHandler(this.enabledCheckBox_CheckedChanged);
            // 
            // snapshotrateHelpButton
            // 
            this.snapshotrateHelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.snapshotrateHelpButton.FlatAppearance.BorderSize = 0;
            this.snapshotrateHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.snapshotrateHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snapshotrateHelpButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapshotrateHelpButton.Location = new System.Drawing.Point(223, 20);
            this.snapshotrateHelpButton.Name = "snapshotrateHelpButton";
            this.snapshotrateHelpButton.Size = new System.Drawing.Size(26, 26);
            this.snapshotrateHelpButton.TabIndex = 4;
            this.snapshotrateHelpButton.Text = "?";
            this.snapshotrateHelpButton.UseVisualStyleBackColor = false;
            // 
            // snapshotrateLabel
            // 
            this.snapshotrateLabel.AutoSize = true;
            this.snapshotrateLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapshotrateLabel.Location = new System.Drawing.Point(6, 26);
            this.snapshotrateLabel.Name = "snapshotrateLabel";
            this.snapshotrateLabel.Size = new System.Drawing.Size(105, 14);
            this.snapshotrateLabel.TabIndex = 2;
            this.snapshotrateLabel.Text = "Snapshot Rate:";
            // 
            // CurrentSnapshotChart
            // 
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.IsMarksNextToAxis = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "RAM % Used";
            chartArea1.Name = "ChartArea1";
            this.CurrentSnapshotChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Top 10 Spenders";
            this.CurrentSnapshotChart.Legends.Add(legend1);
            this.CurrentSnapshotChart.Location = new System.Drawing.Point(12, 489);
            this.CurrentSnapshotChart.Name = "CurrentSnapshotChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PointWidth=2";
            series1.Legend = "Legend1";
            series1.Name = "PieData";
            this.CurrentSnapshotChart.Series.Add(series1);
            this.CurrentSnapshotChart.Size = new System.Drawing.Size(451, 310);
            this.CurrentSnapshotChart.TabIndex = 3;
            this.CurrentSnapshotChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "title1";
            title1.Text = "12/12/2019 24:21:53 Snapshot";
            this.CurrentSnapshotChart.Titles.Add(title1);
            this.CurrentSnapshotChart.Visible = false;
            // 
            // snapshotmanagerButton
            // 
            this.snapshotmanagerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.snapshotmanagerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.snapshotmanagerButton.FlatAppearance.BorderSize = 0;
            this.snapshotmanagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snapshotmanagerButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.snapshotmanagerButton.Location = new System.Drawing.Point(0, 805);
            this.snapshotmanagerButton.Name = "snapshotmanagerButton";
            this.snapshotmanagerButton.Size = new System.Drawing.Size(479, 33);
            this.snapshotmanagerButton.TabIndex = 4;
            this.snapshotmanagerButton.Text = "Snapshot Manager";
            this.snapshotmanagerButton.UseVisualStyleBackColor = false;
            // 
            // changesnapshotButton
            // 
            this.changesnapshotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changesnapshotButton.FlatAppearance.BorderSize = 0;
            this.changesnapshotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changesnapshotButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changesnapshotButton.Location = new System.Drawing.Point(175, 472);
            this.changesnapshotButton.Name = "changesnapshotButton";
            this.changesnapshotButton.Size = new System.Drawing.Size(128, 23);
            this.changesnapshotButton.TabIndex = 5;
            this.changesnapshotButton.Text = "Change Snapshot";
            this.changesnapshotButton.UseVisualStyleBackColor = false;
            this.changesnapshotButton.Click += new System.EventHandler(this.changesnapshotButton_Click);
            // 
            // hourlyusageChart
            // 
            chartArea2.AxisX.CustomLabels.Add(customLabel2);
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.Maximum = 10D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.IsMarksNextToAxis = false;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "RAM % Used";
            chartArea2.Name = "ChartArea1";
            this.hourlyusageChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Top 10 Spenders";
            this.hourlyusageChart.Legends.Add(legend2);
            this.hourlyusageChart.Location = new System.Drawing.Point(12, 156);
            this.hourlyusageChart.Name = "hourlyusageChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PointWidth=2";
            series2.Legend = "Legend1";
            series2.Name = "PieData";
            dataPoint2.IsValueShownAsLabel = false;
            dataPoint2.Label = "xxx";
            series2.Points.Add(dataPoint1);
            series2.Points.Add(dataPoint2);
            this.hourlyusageChart.Series.Add(series2);
            this.hourlyusageChart.Size = new System.Drawing.Size(451, 310);
            this.hourlyusageChart.TabIndex = 6;
            this.hourlyusageChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "title1";
            title2.Text = "Hourly Usage";
            this.hourlyusageChart.Titles.Add(title2);
            this.hourlyusageChart.Visible = false;
            // 
            // notenoughdataPictureBox
            // 
            this.notenoughdataPictureBox.Image = global::MemoryManager.Properties.Resources.notEnoughData;
            this.notenoughdataPictureBox.Location = new System.Drawing.Point(81, 159);
            this.notenoughdataPictureBox.Name = "notenoughdataPictureBox";
            this.notenoughdataPictureBox.Size = new System.Drawing.Size(310, 310);
            this.notenoughdataPictureBox.TabIndex = 8;
            this.notenoughdataPictureBox.TabStop = false;
            // 
            // nosnapshotloadedPictureBox
            // 
            this.nosnapshotloadedPictureBox.Image = global::MemoryManager.Properties.Resources.noSnapshotLoaded;
            this.nosnapshotloadedPictureBox.Location = new System.Drawing.Point(81, 489);
            this.nosnapshotloadedPictureBox.Name = "nosnapshotloadedPictureBox";
            this.nosnapshotloadedPictureBox.Size = new System.Drawing.Size(310, 310);
            this.nosnapshotloadedPictureBox.TabIndex = 7;
            this.nosnapshotloadedPictureBox.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Minimized to system tray";
            this.notifyIcon1.BalloonTipTitle = "Daymon\'s Memory Manager";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Daymon\'s Memory Manager";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 838);
            this.Controls.Add(this.notenoughdataPictureBox);
            this.Controls.Add(this.snapshotmanagerButton);
            this.Controls.Add(this.changesnapshotButton);
            this.Controls.Add(this.nosnapshotloadedPictureBox);
            this.Controls.Add(this.hourlyusageChart);
            this.Controls.Add(this.CurrentSnapshotChart);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).EndInit();
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapshotrateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentSnapshotChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyusageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notenoughdataPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosnapshotloadedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox windowIcon;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Label snapshotrateLabel;
        private System.Windows.Forms.Button snapshotrateHelpButton;
        private System.Windows.Forms.CheckBox enabledCheckBox;
        private System.Windows.Forms.CheckBox usagealertsCheckBox;
        private System.Windows.Forms.Button usagealertsHelpButton;
        private System.Windows.Forms.NumericUpDown snapshotrateNumeric;
        private System.Windows.Forms.DataVisualization.Charting.Chart CurrentSnapshotChart;
        private System.Windows.Forms.Button snapshotmanagerButton;
        private System.Windows.Forms.Button changesnapshotButton;
        private System.Windows.Forms.Button safemodeHelpButton;
        private System.Windows.Forms.CheckBox safemodeCheckBox;
        private System.Windows.Forms.Button loadlocallyHelpButton;
        private System.Windows.Forms.Button savelocallyHelpButton;
        private System.Windows.Forms.CheckBox loadlocallyCheckBox;
        private System.Windows.Forms.CheckBox savelocallyCheckBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart hourlyusageChart;
        private System.Windows.Forms.PictureBox nosnapshotloadedPictureBox;
        private System.Windows.Forms.PictureBox notenoughdataPictureBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

