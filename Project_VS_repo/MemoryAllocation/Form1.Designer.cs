namespace MemoryAllocation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.deBtn = new System.Windows.Forms.Button();
            this.segList = new System.Windows.Forms.ListView();
            this.segName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.segSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewProcess = new System.Windows.Forms.TextBox();
            this.beginSeg = new System.Windows.Forms.Button();
            this.RmvSeg = new System.Windows.Forms.Button();
            this.AddSeg = new System.Windows.Forms.Button();
            this.segNameLbl = new System.Windows.Forms.Label();
            this.segSizeLbl = new System.Windows.Forms.Label();
            this.tbSegName = new System.Windows.Forms.TextBox();
            this.tbSegSize = new System.Windows.Forms.TextBox();
            this.pNameLbl = new System.Windows.Forms.Label();
            this.p_name_label = new System.Windows.Forms.Label();
            this.alBtn = new System.Windows.Forms.Button();
            this.rstBtn = new System.Windows.Forms.Button();
            this.cbPList = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.initHoleLabel = new System.Windows.Forms.Label();
            this.tbHoleSize = new System.Windows.Forms.TextBox();
            this.tbHoleStart = new System.Windows.Forms.TextBox();
            this.holeSizeLabel = new System.Windows.Forms.Label();
            this.holeStLabel = new System.Windows.Forms.Label();
            this.addHole = new System.Windows.Forms.Button();
            this.holeList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rmvHole = new System.Windows.Forms.Button();
            this.tbMemSize = new System.Windows.Forms.TextBox();
            this.lblMemSize = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbFirst = new System.Windows.Forms.RadioButton();
            this.rbBest = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TreeView();
            this.tableLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mem)).BeginInit();
            this.SuspendLayout();
            // 
            // mem
            // 
            this.mem.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Silver;
            this.mem.ChartAreas.Add(chartArea1);
            this.mem.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mem.Location = new System.Drawing.Point(11, 54);
            this.mem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mem.Name = "mem";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series1.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.mem.Series.Add(series1);
            this.mem.Size = new System.Drawing.Size(1031, 1813);
            this.mem.TabIndex = 0;
            this.mem.Text = "memory";
            this.mem.Visible = false;
            this.mem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mem_MouseDown);
            this.mem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mem_MouseMove);
            // 
            // deBtn
            // 
            this.deBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deBtn.FlatAppearance.BorderSize = 3;
            this.deBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deBtn.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deBtn.Location = new System.Drawing.Point(1024, 1385);
            this.deBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.deBtn.Name = "deBtn";
            this.deBtn.Size = new System.Drawing.Size(557, 202);
            this.deBtn.TabIndex = 1;
            this.deBtn.Text = "Deallocate";
            this.deBtn.UseVisualStyleBackColor = false;
            this.deBtn.Click += new System.EventHandler(this.deBtn_Click);
            // 
            // segList
            // 
            this.segList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.segList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.segName,
            this.segSize});
            this.segList.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segList.FullRowSelect = true;
            this.segList.GridLines = true;
            this.segList.HideSelection = false;
            this.segList.Location = new System.Drawing.Point(1596, 563);
            this.segList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.segList.MultiSelect = false;
            this.segList.Name = "segList";
            this.segList.Size = new System.Drawing.Size(1135, 1230);
            this.segList.TabIndex = 2;
            this.segList.Tag = "segListWhole";
            this.segList.UseCompatibleStateImageBehavior = false;
            this.segList.View = System.Windows.Forms.View.Details;
            // 
            // segName
            // 
            this.segName.Text = "Segmentation Name";
            this.segName.Width = 300;
            // 
            // segSize
            // 
            this.segSize.Text = "Size";
            this.segSize.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1591, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "New Process Name";
            // 
            // tbNewProcess
            // 
            this.tbNewProcess.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewProcess.Location = new System.Drawing.Point(1596, 184);
            this.tbNewProcess.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbNewProcess.Name = "tbNewProcess";
            this.tbNewProcess.Size = new System.Drawing.Size(405, 47);
            this.tbNewProcess.TabIndex = 14;
            this.tbNewProcess.Enter += new System.EventHandler(this.tbNewProcess_Enter);
            // 
            // beginSeg
            // 
            this.beginSeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.beginSeg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.beginSeg.FlatAppearance.BorderSize = 3;
            this.beginSeg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.beginSeg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.beginSeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginSeg.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginSeg.Location = new System.Drawing.Point(2036, 163);
            this.beginSeg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.beginSeg.Name = "beginSeg";
            this.beginSeg.Size = new System.Drawing.Size(695, 95);
            this.beginSeg.TabIndex = 15;
            this.beginSeg.Text = "Begin Process Segmentation Entry";
            this.beginSeg.UseVisualStyleBackColor = false;
            this.beginSeg.Click += new System.EventHandler(this.beginSeg_Click);
            // 
            // RmvSeg
            // 
            this.RmvSeg.Enabled = false;
            this.RmvSeg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RmvSeg.FlatAppearance.BorderSize = 3;
            this.RmvSeg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.RmvSeg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RmvSeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RmvSeg.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmvSeg.Location = new System.Drawing.Point(2331, 450);
            this.RmvSeg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RmvSeg.Name = "RmvSeg";
            this.RmvSeg.Size = new System.Drawing.Size(400, 89);
            this.RmvSeg.TabIndex = 3;
            this.RmvSeg.Tag = "segListWhole";
            this.RmvSeg.Text = "Remove Selected";
            this.RmvSeg.UseVisualStyleBackColor = false;
            this.RmvSeg.Click += new System.EventHandler(this.RmvSeg_Click);
            // 
            // AddSeg
            // 
            this.AddSeg.BackColor = System.Drawing.Color.White;
            this.AddSeg.Enabled = false;
            this.AddSeg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddSeg.FlatAppearance.BorderSize = 3;
            this.AddSeg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddSeg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddSeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSeg.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSeg.Location = new System.Drawing.Point(2331, 351);
            this.AddSeg.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.AddSeg.Name = "AddSeg";
            this.AddSeg.Size = new System.Drawing.Size(400, 89);
            this.AddSeg.TabIndex = 4;
            this.AddSeg.Tag = "segListWhole";
            this.AddSeg.Text = "Add";
            this.AddSeg.UseVisualStyleBackColor = false;
            this.AddSeg.Click += new System.EventHandler(this.AddSeg_Click);
            // 
            // segNameLbl
            // 
            this.segNameLbl.AutoSize = true;
            this.segNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segNameLbl.Location = new System.Drawing.Point(1599, 380);
            this.segNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.segNameLbl.Name = "segNameLbl";
            this.segNameLbl.Size = new System.Drawing.Size(323, 36);
            this.segNameLbl.TabIndex = 5;
            this.segNameLbl.Tag = "segListWhole";
            this.segNameLbl.Text = "Segmentation Name";
            // 
            // segSizeLbl
            // 
            this.segSizeLbl.AutoSize = true;
            this.segSizeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segSizeLbl.Location = new System.Drawing.Point(1599, 475);
            this.segSizeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.segSizeLbl.Name = "segSizeLbl";
            this.segSizeLbl.Size = new System.Drawing.Size(297, 36);
            this.segSizeLbl.TabIndex = 7;
            this.segSizeLbl.Tag = "segListWhole";
            this.segSizeLbl.Text = "Segmentation Size";
            // 
            // tbSegName
            // 
            this.tbSegName.Enabled = false;
            this.tbSegName.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSegName.Location = new System.Drawing.Point(1942, 377);
            this.tbSegName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbSegName.Name = "tbSegName";
            this.tbSegName.Size = new System.Drawing.Size(366, 47);
            this.tbSegName.TabIndex = 8;
            this.tbSegName.Tag = "segListWhole";
            this.tbSegName.Enter += new System.EventHandler(this.tbSegName_Enter);
            // 
            // tbSegSize
            // 
            this.tbSegSize.Enabled = false;
            this.tbSegSize.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSegSize.Location = new System.Drawing.Point(1944, 466);
            this.tbSegSize.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbSegSize.Name = "tbSegSize";
            this.tbSegSize.Size = new System.Drawing.Size(366, 47);
            this.tbSegSize.TabIndex = 10;
            this.tbSegSize.Tag = "segListWhole";
            this.tbSegSize.Enter += new System.EventHandler(this.tbSegSize_Enter);
            // 
            // pNameLbl
            // 
            this.pNameLbl.AutoSize = true;
            this.pNameLbl.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLbl.Location = new System.Drawing.Point(1599, 296);
            this.pNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pNameLbl.Name = "pNameLbl";
            this.pNameLbl.Size = new System.Drawing.Size(280, 41);
            this.pNameLbl.TabIndex = 11;
            this.pNameLbl.Tag = "segListWhole";
            this.pNameLbl.Text = "Process Name :";
            // 
            // p_name_label
            // 
            this.p_name_label.AutoSize = true;
            this.p_name_label.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_name_label.Location = new System.Drawing.Point(1940, 296);
            this.p_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p_name_label.Name = "p_name_label";
            this.p_name_label.Size = new System.Drawing.Size(0, 41);
            this.p_name_label.TabIndex = 12;
            this.p_name_label.Tag = "segListWhole";
            // 
            // alBtn
            // 
            this.alBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.alBtn.FlatAppearance.BorderSize = 3;
            this.alBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.alBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.alBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alBtn.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alBtn.Location = new System.Drawing.Point(1024, 563);
            this.alBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.alBtn.Name = "alBtn";
            this.alBtn.Size = new System.Drawing.Size(557, 202);
            this.alBtn.TabIndex = 16;
            this.alBtn.Text = "Initialize Memory";
            this.alBtn.UseVisualStyleBackColor = false;
            this.alBtn.Click += new System.EventHandler(this.alBtn_Click);
            // 
            // rstBtn
            // 
            this.rstBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rstBtn.FlatAppearance.BorderSize = 3;
            this.rstBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.rstBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rstBtn.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rstBtn.Location = new System.Drawing.Point(1024, 1591);
            this.rstBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rstBtn.Name = "rstBtn";
            this.rstBtn.Size = new System.Drawing.Size(557, 202);
            this.rstBtn.TabIndex = 17;
            this.rstBtn.Text = "Reset";
            this.rstBtn.UseVisualStyleBackColor = false;
            this.rstBtn.Click += new System.EventHandler(this.rstBtn_Click);
            // 
            // cbPList
            // 
            this.cbPList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPList.FormattingEnabled = true;
            this.cbPList.Items.AddRange(new object[] {
            "Choose a process to deallocate..."});
            this.cbPList.Location = new System.Drawing.Point(1024, 771);
            this.cbPList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbPList.Name = "cbPList";
            this.cbPList.Size = new System.Drawing.Size(557, 44);
            this.cbPList.TabIndex = 18;
            this.cbPList.Text = "Choose a process to deallocate...";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeBtn.FlatAppearance.BorderSize = 3;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(2652, 11);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(79, 76);
            this.closeBtn.TabIndex = 19;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(510, 69);
            this.label5.TabIndex = 20;
            this.label5.Text = "Memory Allocator";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label5_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.900001F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 41);
            this.label6.TabIndex = 29;
            // 
            // initHoleLabel
            // 
            this.initHoleLabel.AutoSize = true;
            this.initHoleLabel.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initHoleLabel.Location = new System.Drawing.Point(14, 141);
            this.initHoleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initHoleLabel.Name = "initHoleLabel";
            this.initHoleLabel.Size = new System.Drawing.Size(273, 41);
            this.initHoleLabel.TabIndex = 28;
            this.initHoleLabel.Text = "Initialize Holes";
            // 
            // tbHoleSize
            // 
            this.tbHoleSize.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoleSize.Location = new System.Drawing.Point(212, 314);
            this.tbHoleSize.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbHoleSize.Name = "tbHoleSize";
            this.tbHoleSize.Size = new System.Drawing.Size(280, 47);
            this.tbHoleSize.TabIndex = 27;
            this.tbHoleSize.Enter += new System.EventHandler(this.tbHoleSize_Enter);
            // 
            // tbHoleStart
            // 
            this.tbHoleStart.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoleStart.Location = new System.Drawing.Point(212, 225);
            this.tbHoleStart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbHoleStart.Name = "tbHoleStart";
            this.tbHoleStart.Size = new System.Drawing.Size(280, 47);
            this.tbHoleStart.TabIndex = 26;
            this.tbHoleStart.Enter += new System.EventHandler(this.tbHoleStart_Enter);
            // 
            // holeSizeLabel
            // 
            this.holeSizeLabel.AutoSize = true;
            this.holeSizeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holeSizeLabel.Location = new System.Drawing.Point(14, 323);
            this.holeSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.holeSizeLabel.Name = "holeSizeLabel";
            this.holeSizeLabel.Size = new System.Drawing.Size(155, 36);
            this.holeSizeLabel.TabIndex = 25;
            this.holeSizeLabel.Text = "Hole Size";
            // 
            // holeStLabel
            // 
            this.holeStLabel.AutoSize = true;
            this.holeStLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holeStLabel.Location = new System.Drawing.Point(14, 228);
            this.holeStLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.holeStLabel.Name = "holeStLabel";
            this.holeStLabel.Size = new System.Drawing.Size(167, 36);
            this.holeStLabel.TabIndex = 24;
            this.holeStLabel.Text = "Hole Start";
            // 
            // addHole
            // 
            this.addHole.BackColor = System.Drawing.Color.White;
            this.addHole.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addHole.FlatAppearance.BorderSize = 3;
            this.addHole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addHole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addHole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addHole.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHole.Location = new System.Drawing.Point(518, 208);
            this.addHole.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.addHole.Name = "addHole";
            this.addHole.Size = new System.Drawing.Size(486, 80);
            this.addHole.TabIndex = 23;
            this.addHole.Text = "Add Hole";
            this.addHole.UseVisualStyleBackColor = false;
            this.addHole.Click += new System.EventHandler(this.addHole_Click);
            // 
            // holeList
            // 
            this.holeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.holeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.holeList.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holeList.FullRowSelect = true;
            this.holeList.GridLines = true;
            this.holeList.HideSelection = false;
            this.holeList.Location = new System.Drawing.Point(15, 495);
            this.holeList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.holeList.MultiSelect = false;
            this.holeList.Name = "holeList";
            this.holeList.Size = new System.Drawing.Size(990, 1298);
            this.holeList.TabIndex = 21;
            this.holeList.UseCompatibleStateImageBehavior = false;
            this.holeList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hole Start";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hole Size";
            this.columnHeader2.Width = 200;
            // 
            // rmvHole
            // 
            this.rmvHole.BackColor = System.Drawing.Color.White;
            this.rmvHole.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rmvHole.FlatAppearance.BorderSize = 3;
            this.rmvHole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.rmvHole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rmvHole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmvHole.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmvHole.Location = new System.Drawing.Point(518, 293);
            this.rmvHole.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.rmvHole.Name = "rmvHole";
            this.rmvHole.Size = new System.Drawing.Size(486, 80);
            this.rmvHole.TabIndex = 30;
            this.rmvHole.Text = "Remove Hole";
            this.rmvHole.UseVisualStyleBackColor = false;
            this.rmvHole.Click += new System.EventHandler(this.rmvHole_Click);
            // 
            // tbMemSize
            // 
            this.tbMemSize.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemSize.Location = new System.Drawing.Point(514, 384);
            this.tbMemSize.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbMemSize.Name = "tbMemSize";
            this.tbMemSize.Size = new System.Drawing.Size(486, 47);
            this.tbMemSize.TabIndex = 33;
            this.tbMemSize.Enter += new System.EventHandler(this.tbMemSize_Enter);
            // 
            // lblMemSize
            // 
            this.lblMemSize.AutoSize = true;
            this.lblMemSize.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemSize.Location = new System.Drawing.Point(24, 389);
            this.lblMemSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemSize.Name = "lblMemSize";
            this.lblMemSize.Size = new System.Drawing.Size(413, 41);
            this.lblMemSize.TabIndex = 32;
            this.lblMemSize.Text = "Memory Maximum Size";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2568, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 76);
            this.button1.TabIndex = 34;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbFirst
            // 
            this.rbFirst.AutoSize = true;
            this.rbFirst.Checked = true;
            this.rbFirst.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFirst.Location = new System.Drawing.Point(1027, 296);
            this.rbFirst.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbFirst.Name = "rbFirst";
            this.rbFirst.Size = new System.Drawing.Size(186, 45);
            this.rbFirst.TabIndex = 35;
            this.rbFirst.TabStop = true;
            this.rbFirst.Text = "First Fit";
            this.rbFirst.UseVisualStyleBackColor = true;
            // 
            // rbBest
            // 
            this.rbBest.AutoSize = true;
            this.rbBest.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBest.Location = new System.Drawing.Point(1027, 355);
            this.rbBest.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbBest.Name = "rbBest";
            this.rbBest.Size = new System.Drawing.Size(184, 45);
            this.rbBest.TabIndex = 36;
            this.rbBest.Text = "Best Fit";
            this.rbBest.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1019, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 48);
            this.label7.TabIndex = 37;
            this.label7.Text = "Method:";
            // 
            // table
            // 
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.table.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table.HotTracking = true;
            this.table.Location = new System.Drawing.Point(1596, 337);
            this.table.Name = "table";
            this.table.ShowRootLines = false;
            this.table.Size = new System.Drawing.Size(1135, 1456);
            this.table.TabIndex = 39;
            // 
            // tableLbl
            // 
            this.tableLbl.AutoSize = true;
            this.tableLbl.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLbl.Location = new System.Drawing.Point(1599, 296);
            this.tableLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableLbl.Name = "tableLbl";
            this.tableLbl.Size = new System.Drawing.Size(311, 41);
            this.tableLbl.TabIndex = 40;
            this.tableLbl.Tag = "";
            this.tableLbl.Text = "Allocation Table :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2784, 1830);
            this.Controls.Add(this.tableLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbBest);
            this.Controls.Add(this.rbFirst);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMemSize);
            this.Controls.Add(this.lblMemSize);
            this.Controls.Add(this.rmvHole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.initHoleLabel);
            this.Controls.Add(this.tbHoleSize);
            this.Controls.Add(this.tbHoleStart);
            this.Controls.Add(this.holeSizeLabel);
            this.Controls.Add(this.holeStLabel);
            this.Controls.Add(this.addHole);
            this.Controls.Add(this.holeList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.cbPList);
            this.Controls.Add(this.rstBtn);
            this.Controls.Add(this.alBtn);
            this.Controls.Add(this.beginSeg);
            this.Controls.Add(this.tbNewProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_name_label);
            this.Controls.Add(this.pNameLbl);
            this.Controls.Add(this.tbSegSize);
            this.Controls.Add(this.tbSegName);
            this.Controls.Add(this.segSizeLbl);
            this.Controls.Add(this.segNameLbl);
            this.Controls.Add(this.AddSeg);
            this.Controls.Add(this.RmvSeg);
            this.Controls.Add(this.segList);
            this.Controls.Add(this.deBtn);
            this.Controls.Add(this.mem);
            this.Controls.Add(this.table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Memory Allocator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.mem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mem;
        private System.Windows.Forms.Button deBtn;
        private System.Windows.Forms.ListView segList;
        private System.Windows.Forms.ColumnHeader segName;
        private System.Windows.Forms.ColumnHeader segSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewProcess;
        private System.Windows.Forms.Button beginSeg;
        private System.Windows.Forms.Button RmvSeg;
        private System.Windows.Forms.Button AddSeg;
        private System.Windows.Forms.Label segNameLbl;
        private System.Windows.Forms.Label segSizeLbl;
        private System.Windows.Forms.TextBox tbSegName;
        private System.Windows.Forms.TextBox tbSegSize;
        private System.Windows.Forms.Label pNameLbl;
        private System.Windows.Forms.Label p_name_label;
        private System.Windows.Forms.Button alBtn;
        private System.Windows.Forms.Button rstBtn;
        private System.Windows.Forms.ComboBox cbPList;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label initHoleLabel;
        private System.Windows.Forms.TextBox tbHoleSize;
        private System.Windows.Forms.TextBox tbHoleStart;
        private System.Windows.Forms.Label holeSizeLabel;
        private System.Windows.Forms.Label holeStLabel;
        private System.Windows.Forms.Button addHole;
        private System.Windows.Forms.ListView holeList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button rmvHole;
        private System.Windows.Forms.TextBox tbMemSize;
        private System.Windows.Forms.Label lblMemSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbFirst;
        private System.Windows.Forms.RadioButton rbBest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TreeView table;
        private System.Windows.Forms.Label tableLbl;
    }
}

