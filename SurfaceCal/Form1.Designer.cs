namespace SurfaceCal
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnV1 = new System.Windows.Forms.Button();
            this.btnV2 = new System.Windows.Forms.Button();
            this.btnV3 = new System.Windows.Forms.Button();
            this.btnV4 = new System.Windows.Forms.Button();
            this.btnV5 = new System.Windows.Forms.Button();
            this.btnV6 = new System.Windows.Forms.Button();
            this.btnV7 = new System.Windows.Forms.Button();
            this.btnV8 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAn30Pwm = new System.Windows.Forms.TextBox();
            this.txtA0Pwm = new System.Windows.Forms.TextBox();
            this.txtA30Pwm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAilL = new System.Windows.Forms.Button();
            this.btnAilR = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtTailNumber = new System.Windows.Forms.TextBox();
            this.btnValidateServo = new System.Windows.Forms.Button();
            this.btnValidateAll = new System.Windows.Forms.Button();
            this.btnGenerateParams = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btdLoadCal = new System.Windows.Forms.Button();
            this.btnSuspendCal = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnV1
            // 
            this.btnV1.BackColor = System.Drawing.Color.Crimson;
            this.btnV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV1.ForeColor = System.Drawing.Color.White;
            this.btnV1.Location = new System.Drawing.Point(4, 59);
            this.btnV1.Margin = new System.Windows.Forms.Padding(1);
            this.btnV1.Name = "btnV1";
            this.btnV1.Size = new System.Drawing.Size(100, 31);
            this.btnV1.TabIndex = 100;
            this.btnV1.TabStop = false;
            this.btnV1.Text = "Vane 1";
            this.btnV1.UseVisualStyleBackColor = false;
            this.btnV1.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // btnV2
            // 
            this.btnV2.BackColor = System.Drawing.Color.Crimson;
            this.btnV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV2.ForeColor = System.Drawing.Color.White;
            this.btnV2.Location = new System.Drawing.Point(4, 92);
            this.btnV2.Margin = new System.Windows.Forms.Padding(1);
            this.btnV2.Name = "btnV2";
            this.btnV2.Size = new System.Drawing.Size(100, 31);
            this.btnV2.TabIndex = 101;
            this.btnV2.TabStop = false;
            this.btnV2.Text = "Vane 2";
            this.btnV2.UseVisualStyleBackColor = false;
            this.btnV2.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // btnV3
            // 
            this.btnV3.BackColor = System.Drawing.Color.Crimson;
            this.btnV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV3.ForeColor = System.Drawing.Color.White;
            this.btnV3.Location = new System.Drawing.Point(4, 125);
            this.btnV3.Margin = new System.Windows.Forms.Padding(1);
            this.btnV3.Name = "btnV3";
            this.btnV3.Size = new System.Drawing.Size(100, 31);
            this.btnV3.TabIndex = 102;
            this.btnV3.TabStop = false;
            this.btnV3.Text = "Vane 3";
            this.btnV3.UseVisualStyleBackColor = false;
            this.btnV3.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // btnV4
            // 
            this.btnV4.BackColor = System.Drawing.Color.Crimson;
            this.btnV4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV4.ForeColor = System.Drawing.Color.White;
            this.btnV4.Location = new System.Drawing.Point(4, 159);
            this.btnV4.Margin = new System.Windows.Forms.Padding(1);
            this.btnV4.Name = "btnV4";
            this.btnV4.Size = new System.Drawing.Size(100, 31);
            this.btnV4.TabIndex = 103;
            this.btnV4.TabStop = false;
            this.btnV4.Text = "Vane 4";
            this.btnV4.UseVisualStyleBackColor = false;
            this.btnV4.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // btnV5
            // 
            this.btnV5.BackColor = System.Drawing.Color.Crimson;
            this.btnV5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV5.ForeColor = System.Drawing.Color.White;
            this.btnV5.Location = new System.Drawing.Point(4, 192);
            this.btnV5.Margin = new System.Windows.Forms.Padding(1);
            this.btnV5.Name = "btnV5";
            this.btnV5.Size = new System.Drawing.Size(100, 31);
            this.btnV5.TabIndex = 104;
            this.btnV5.TabStop = false;
            this.btnV5.Text = "Vane 5";
            this.btnV5.UseVisualStyleBackColor = false;
            this.btnV5.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // btnV6
            // 
            this.btnV6.BackColor = System.Drawing.Color.Crimson;
            this.btnV6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV6.ForeColor = System.Drawing.Color.White;
            this.btnV6.Location = new System.Drawing.Point(4, 225);
            this.btnV6.Margin = new System.Windows.Forms.Padding(1);
            this.btnV6.Name = "btnV6";
            this.btnV6.Size = new System.Drawing.Size(100, 31);
            this.btnV6.TabIndex = 105;
            this.btnV6.TabStop = false;
            this.btnV6.Text = "Vane 6";
            this.btnV6.UseVisualStyleBackColor = false;
            this.btnV6.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // btnV7
            // 
            this.btnV7.BackColor = System.Drawing.Color.Crimson;
            this.btnV7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV7.ForeColor = System.Drawing.Color.White;
            this.btnV7.Location = new System.Drawing.Point(4, 258);
            this.btnV7.Margin = new System.Windows.Forms.Padding(1);
            this.btnV7.Name = "btnV7";
            this.btnV7.Size = new System.Drawing.Size(100, 31);
            this.btnV7.TabIndex = 106;
            this.btnV7.TabStop = false;
            this.btnV7.Text = "Vane 7";
            this.btnV7.UseVisualStyleBackColor = false;
            this.btnV7.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // btnV8
            // 
            this.btnV8.BackColor = System.Drawing.Color.Crimson;
            this.btnV8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV8.ForeColor = System.Drawing.Color.White;
            this.btnV8.Location = new System.Drawing.Point(4, 291);
            this.btnV8.Margin = new System.Windows.Forms.Padding(1);
            this.btnV8.Name = "btnV8";
            this.btnV8.Size = new System.Drawing.Size(100, 31);
            this.btnV8.TabIndex = 107;
            this.btnV8.TabStop = false;
            this.btnV8.Text = "Vane 8";
            this.btnV8.UseVisualStyleBackColor = false;
            this.btnV8.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtAn30Pwm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtA0Pwm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtA30Pwm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(116, 59);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 143);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // txtAn30Pwm
            // 
            this.txtAn30Pwm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAn30Pwm.BackColor = System.Drawing.Color.Yellow;
            this.txtAn30Pwm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAn30Pwm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAn30Pwm.Location = new System.Drawing.Point(180, 111);
            this.txtAn30Pwm.Margin = new System.Windows.Forms.Padding(1);
            this.txtAn30Pwm.Name = "txtAn30Pwm";
            this.txtAn30Pwm.Size = new System.Drawing.Size(96, 25);
            this.txtAn30Pwm.TabIndex = 5;
            this.txtAn30Pwm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA0Pwm
            // 
            this.txtA0Pwm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtA0Pwm.BackColor = System.Drawing.Color.Yellow;
            this.txtA0Pwm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA0Pwm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA0Pwm.Location = new System.Drawing.Point(180, 75);
            this.txtA0Pwm.Margin = new System.Windows.Forms.Padding(1);
            this.txtA0Pwm.Name = "txtA0Pwm";
            this.txtA0Pwm.Size = new System.Drawing.Size(96, 25);
            this.txtA0Pwm.TabIndex = 4;
            this.txtA0Pwm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA30Pwm
            // 
            this.txtA30Pwm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtA30Pwm.BackColor = System.Drawing.Color.Yellow;
            this.txtA30Pwm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA30Pwm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA30Pwm.Location = new System.Drawing.Point(180, 40);
            this.txtA30Pwm.Margin = new System.Windows.Forms.Padding(1);
            this.txtA30Pwm.Name = "txtA30Pwm";
            this.txtA30Pwm.Size = new System.Drawing.Size(96, 25);
            this.txtA30Pwm.TabIndex = 3;
            this.txtA30Pwm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "30";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "-30";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(200, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "PWM";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.Interval = 10D;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Interval = 100D;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.Interval = 100D;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MajorTickMark.Interval = 0D;
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(432, 10);
            this.chart1.Margin = new System.Windows.Forms.Padding(1);
            this.chart1.Name = "chart1";
            this.chart1.Padding = new System.Windows.Forms.Padding(2);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.MarkerColor = System.Drawing.Color.Blue;
            series1.Name = "PWM";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.MarkerBorderColor = System.Drawing.Color.Lime;
            series2.MarkerColor = System.Drawing.Color.Lime;
            series2.Name = "Best Fit";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(430, 378);
            this.chart1.TabIndex = 120;
            this.chart1.TabStop = false;
            this.chart1.Text = "Best Fit";
            // 
            // btnAilL
            // 
            this.btnAilL.BackColor = System.Drawing.Color.Crimson;
            this.btnAilL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAilL.ForeColor = System.Drawing.Color.White;
            this.btnAilL.Location = new System.Drawing.Point(4, 324);
            this.btnAilL.Margin = new System.Windows.Forms.Padding(1);
            this.btnAilL.Name = "btnAilL";
            this.btnAilL.Size = new System.Drawing.Size(100, 31);
            this.btnAilL.TabIndex = 108;
            this.btnAilL.TabStop = false;
            this.btnAilL.Text = "Aileron L";
            this.btnAilL.UseVisualStyleBackColor = false;
            this.btnAilL.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // btnAilR
            // 
            this.btnAilR.BackColor = System.Drawing.Color.Crimson;
            this.btnAilR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAilR.ForeColor = System.Drawing.Color.White;
            this.btnAilR.Location = new System.Drawing.Point(4, 357);
            this.btnAilR.Margin = new System.Windows.Forms.Padding(1);
            this.btnAilR.Name = "btnAilR";
            this.btnAilR.Size = new System.Drawing.Size(100, 31);
            this.btnAilR.TabIndex = 109;
            this.btnAilR.TabStop = false;
            this.btnAilR.Text = "Aileron R";
            this.btnAilR.UseVisualStyleBackColor = false;
            this.btnAilR.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "PID :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(194, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tail # :";
            // 
            // txtPID
            // 
            this.txtPID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.Location = new System.Drawing.Point(84, 4);
            this.txtPID.Margin = new System.Windows.Forms.Padding(1);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(86, 32);
            this.txtPID.TabIndex = 0;
            this.txtPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTailNumber
            // 
            this.txtTailNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTailNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTailNumber.Location = new System.Drawing.Point(285, 4);
            this.txtTailNumber.Margin = new System.Windows.Forms.Padding(1);
            this.txtTailNumber.Name = "txtTailNumber";
            this.txtTailNumber.Size = new System.Drawing.Size(111, 32);
            this.txtTailNumber.TabIndex = 1;
            this.txtTailNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnValidateServo
            // 
            this.btnValidateServo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateServo.Location = new System.Drawing.Point(116, 344);
            this.btnValidateServo.Margin = new System.Windows.Forms.Padding(1);
            this.btnValidateServo.Name = "btnValidateServo";
            this.btnValidateServo.Size = new System.Drawing.Size(143, 43);
            this.btnValidateServo.TabIndex = 6;
            this.btnValidateServo.Text = "Validate Servo";
            this.btnValidateServo.UseVisualStyleBackColor = true;
            this.btnValidateServo.Click += new System.EventHandler(this.btnValidateServo_Click);
            // 
            // btnValidateAll
            // 
            this.btnValidateAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateAll.Location = new System.Drawing.Point(277, 279);
            this.btnValidateAll.Margin = new System.Windows.Forms.Padding(1);
            this.btnValidateAll.Name = "btnValidateAll";
            this.btnValidateAll.Size = new System.Drawing.Size(143, 43);
            this.btnValidateAll.TabIndex = 7;
            this.btnValidateAll.Text = "Validate All";
            this.btnValidateAll.UseVisualStyleBackColor = true;
            this.btnValidateAll.Click += new System.EventHandler(this.btnValidateAll_Click);
            // 
            // btnGenerateParams
            // 
            this.btnGenerateParams.Enabled = false;
            this.btnGenerateParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateParams.Location = new System.Drawing.Point(278, 344);
            this.btnGenerateParams.Margin = new System.Windows.Forms.Padding(1);
            this.btnGenerateParams.Name = "btnGenerateParams";
            this.btnGenerateParams.Size = new System.Drawing.Size(143, 43);
            this.btnGenerateParams.TabIndex = 8;
            this.btnGenerateParams.Text = "Generate Params";
            this.btnGenerateParams.UseVisualStyleBackColor = true;
            this.btnGenerateParams.Click += new System.EventHandler(this.btnGenerateParams_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.83296F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.63657F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.7833F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.97291F));
            this.tableLayoutPanel2.Controls.Add(this.txtPID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTailNumber, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 40);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // btdLoadCal
            // 
            this.btdLoadCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdLoadCal.Location = new System.Drawing.Point(116, 220);
            this.btdLoadCal.Margin = new System.Windows.Forms.Padding(1);
            this.btdLoadCal.Name = "btdLoadCal";
            this.btdLoadCal.Size = new System.Drawing.Size(143, 43);
            this.btdLoadCal.TabIndex = 2;
            this.btdLoadCal.Text = "Load";
            this.btdLoadCal.UseVisualStyleBackColor = true;
            this.btdLoadCal.Click += new System.EventHandler(this.btdLoadCal_Click);
            // 
            // btnSuspendCal
            // 
            this.btnSuspendCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuspendCal.Location = new System.Drawing.Point(278, 219);
            this.btnSuspendCal.Margin = new System.Windows.Forms.Padding(1);
            this.btnSuspendCal.Name = "btnSuspendCal";
            this.btnSuspendCal.Size = new System.Drawing.Size(143, 43);
            this.btnSuspendCal.TabIndex = 10;
            this.btnSuspendCal.TabStop = false;
            this.btnSuspendCal.Text = "Suspend";
            this.btnSuspendCal.UseVisualStyleBackColor = true;
            this.btnSuspendCal.Click += new System.EventHandler(this.btnSuspendCal_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "json";
            this.openFileDialog1.FilterIndex = 2;
            // 
            // btnUnlock
            // 
            this.btnUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.Location = new System.Drawing.Point(116, 279);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(1);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(143, 43);
            this.btnUnlock.TabIndex = 11;
            this.btnUnlock.TabStop = false;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 405);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnSuspendCal);
            this.Controls.Add(this.btdLoadCal);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnGenerateParams);
            this.Controls.Add(this.btnValidateAll);
            this.Controls.Add(this.btnValidateServo);
            this.Controls.Add(this.btnAilR);
            this.Controls.Add(this.btnAilL);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnV8);
            this.Controls.Add(this.btnV7);
            this.Controls.Add(this.btnV6);
            this.Controls.Add(this.btnV5);
            this.Controls.Add(this.btnV4);
            this.Controls.Add(this.btnV3);
            this.Controls.Add(this.btnV2);
            this.Controls.Add(this.btnV1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Surface Calibration Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnV1;
        private System.Windows.Forms.Button btnV2;
        private System.Windows.Forms.Button btnV3;
        private System.Windows.Forms.Button btnV4;
        private System.Windows.Forms.Button btnV5;
        private System.Windows.Forms.Button btnV6;
        private System.Windows.Forms.Button btnV7;
        private System.Windows.Forms.Button btnV8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnAilL;
        private System.Windows.Forms.Button btnAilR;
        private System.Windows.Forms.TextBox txtAn30Pwm;
        private System.Windows.Forms.TextBox txtA0Pwm;
        private System.Windows.Forms.TextBox txtA30Pwm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtTailNumber;
        private System.Windows.Forms.Button btnValidateServo;
        private System.Windows.Forms.Button btnValidateAll;
        private System.Windows.Forms.Button btnGenerateParams;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btdLoadCal;
        private System.Windows.Forms.Button btnSuspendCal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUnlock;
    }
}

