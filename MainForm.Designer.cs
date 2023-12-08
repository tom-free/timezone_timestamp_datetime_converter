namespace TimezoneConverter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listTime = new ListView();
            columnTimezone = new ColumnHeader();
            columnDateTime = new ColumnHeader();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnCopyTimestampHex = new Button();
            btnCopyTimestampDec = new Button();
            txbTimestampHex = new TextBox();
            txbTimestampDec = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txbTimestampEx = new TextBox();
            lblTimestampFormat = new Label();
            chkTimestampHex = new CheckBox();
            btnTimestampToDatetime = new Button();
            txbTimestamp = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            cmbTimezoneSelect = new ComboBox();
            dateInputTime = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            txbTimestampHexResult = new TextBox();
            txbTimestampDecResult = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnDatetimeToTimestamp = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // listTime
            // 
            listTime.Columns.AddRange(new ColumnHeader[] { columnTimezone, columnDateTime });
            listTime.Font = new Font("Microsoft YaHei UI", 9F);
            listTime.FullRowSelect = true;
            listTime.GridLines = true;
            listTime.Location = new Point(8, 73);
            listTime.Name = "listTime";
            listTime.Size = new Size(290, 279);
            listTime.TabIndex = 0;
            listTime.UseCompatibleStateImageBehavior = false;
            listTime.View = View.Details;
            // 
            // columnTimezone
            // 
            columnTimezone.Text = "时区";
            columnTimezone.Width = 120;
            // 
            // columnDateTime
            // 
            columnDateTime.Text = "日期和时间";
            columnDateTime.Width = 971;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 8;
            label1.Text = "十进制：";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCopyTimestampHex);
            groupBox1.Controls.Add(btnCopyTimestampDec);
            groupBox1.Controls.Add(txbTimestampHex);
            groupBox1.Controls.Add(txbTimestampDec);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(304, 74);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "实时时间戳";
            // 
            // btnCopyTimestampHex
            // 
            btnCopyTimestampHex.Location = new Point(225, 42);
            btnCopyTimestampHex.Margin = new Padding(2);
            btnCopyTimestampHex.Name = "btnCopyTimestampHex";
            btnCopyTimestampHex.Size = new Size(71, 24);
            btnCopyTimestampHex.TabIndex = 19;
            btnCopyTimestampHex.Text = "复制";
            btnCopyTimestampHex.UseVisualStyleBackColor = true;
            btnCopyTimestampHex.Click += btnCopyTimestampHex_Click;
            // 
            // btnCopyTimestampDec
            // 
            btnCopyTimestampDec.Location = new Point(225, 16);
            btnCopyTimestampDec.Margin = new Padding(2);
            btnCopyTimestampDec.Name = "btnCopyTimestampDec";
            btnCopyTimestampDec.Size = new Size(71, 24);
            btnCopyTimestampDec.TabIndex = 18;
            btnCopyTimestampDec.Text = "复制";
            btnCopyTimestampDec.UseVisualStyleBackColor = true;
            btnCopyTimestampDec.Click += btnCopyTimestampDec_Click;
            // 
            // txbTimestampHex
            // 
            txbTimestampHex.Enabled = false;
            txbTimestampHex.ImeMode = ImeMode.Off;
            txbTimestampHex.Location = new Point(60, 42);
            txbTimestampHex.Margin = new Padding(2);
            txbTimestampHex.Name = "txbTimestampHex";
            txbTimestampHex.ReadOnly = true;
            txbTimestampHex.Size = new Size(162, 23);
            txbTimestampHex.TabIndex = 17;
            txbTimestampHex.TextAlign = HorizontalAlignment.Center;
            // 
            // txbTimestampDec
            // 
            txbTimestampDec.Enabled = false;
            txbTimestampDec.ImeMode = ImeMode.Off;
            txbTimestampDec.Location = new Point(60, 16);
            txbTimestampDec.Margin = new Padding(2);
            txbTimestampDec.Name = "txbTimestampDec";
            txbTimestampDec.ReadOnly = true;
            txbTimestampDec.Size = new Size(162, 23);
            txbTimestampDec.TabIndex = 16;
            txbTimestampDec.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 14;
            label2.Text = "十六进制：";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbTimestampEx);
            groupBox2.Controls.Add(lblTimestampFormat);
            groupBox2.Controls.Add(chkTimestampHex);
            groupBox2.Controls.Add(btnTimestampToDatetime);
            groupBox2.Controls.Add(txbTimestamp);
            groupBox2.Controls.Add(listTime);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(8, 86);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(304, 358);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "时间戳转时间";
            // 
            // txbTimestampEx
            // 
            txbTimestampEx.Enabled = false;
            txbTimestampEx.ImeMode = ImeMode.Off;
            txbTimestampEx.Location = new Point(60, 45);
            txbTimestampEx.Margin = new Padding(2);
            txbTimestampEx.Name = "txbTimestampEx";
            txbTimestampEx.ReadOnly = true;
            txbTimestampEx.Size = new Size(162, 23);
            txbTimestampEx.TabIndex = 23;
            txbTimestampEx.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTimestampFormat
            // 
            lblTimestampFormat.AutoSize = true;
            lblTimestampFormat.Location = new Point(4, 48);
            lblTimestampFormat.Margin = new Padding(2, 0, 2, 0);
            lblTimestampFormat.Name = "lblTimestampFormat";
            lblTimestampFormat.Size = new Size(68, 17);
            lblTimestampFormat.TabIndex = 22;
            lblTimestampFormat.Text = "十六进制：";
            // 
            // chkTimestampHex
            // 
            chkTimestampHex.AutoSize = true;
            chkTimestampHex.Location = new Point(225, 20);
            chkTimestampHex.Margin = new Padding(2);
            chkTimestampHex.Name = "chkTimestampHex";
            chkTimestampHex.Size = new Size(75, 21);
            chkTimestampHex.TabIndex = 21;
            chkTimestampHex.Text = "十六进制";
            chkTimestampHex.UseVisualStyleBackColor = true;
            chkTimestampHex.CheckedChanged += chkTimestampHex_CheckedChanged;
            // 
            // btnTimestampToDatetime
            // 
            btnTimestampToDatetime.Location = new Point(225, 45);
            btnTimestampToDatetime.Margin = new Padding(2);
            btnTimestampToDatetime.Name = "btnTimestampToDatetime";
            btnTimestampToDatetime.Size = new Size(71, 24);
            btnTimestampToDatetime.TabIndex = 19;
            btnTimestampToDatetime.Text = "转换";
            btnTimestampToDatetime.UseVisualStyleBackColor = true;
            btnTimestampToDatetime.Click += btnTimestampToDatetime_Click;
            // 
            // txbTimestamp
            // 
            txbTimestamp.ImeMode = ImeMode.Off;
            txbTimestamp.Location = new Point(60, 18);
            txbTimestamp.Margin = new Padding(2);
            txbTimestamp.MaxLength = 12;
            txbTimestamp.Name = "txbTimestamp";
            txbTimestamp.Size = new Size(162, 23);
            txbTimestamp.TabIndex = 16;
            txbTimestamp.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 21);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 8;
            label4.Text = "时间戳：";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbTimezoneSelect);
            groupBox3.Controls.Add(dateInputTime);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txbTimestampHexResult);
            groupBox3.Controls.Add(txbTimestampDecResult);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(btnDatetimeToTimestamp);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(8, 448);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(304, 156);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "时间转时间戳";
            // 
            // cmbTimezoneSelect
            // 
            cmbTimezoneSelect.FormattingEnabled = true;
            cmbTimezoneSelect.Location = new Point(60, 18);
            cmbTimezoneSelect.Margin = new Padding(2);
            cmbTimezoneSelect.Name = "cmbTimezoneSelect";
            cmbTimezoneSelect.Size = new Size(162, 25);
            cmbTimezoneSelect.TabIndex = 29;
            // 
            // dateInputTime
            // 
            dateInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateInputTime.Format = DateTimePickerFormat.Custom;
            dateInputTime.Location = new Point(60, 47);
            dateInputTime.Margin = new Padding(2);
            dateInputTime.Name = "dateInputTime";
            dateInputTime.ShowUpDown = true;
            dateInputTime.Size = new Size(162, 23);
            dateInputTime.TabIndex = 28;
            dateInputTime.Value = new DateTime(2023, 12, 4, 2, 24, 38, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 51);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(44, 17);
            label8.TabIndex = 27;
            label8.Text = "时间：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 22);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 17);
            label7.TabIndex = 26;
            label7.Text = "时区：";
            // 
            // txbTimestampHexResult
            // 
            txbTimestampHexResult.ImeMode = ImeMode.Off;
            txbTimestampHexResult.Location = new Point(60, 123);
            txbTimestampHexResult.Margin = new Padding(2);
            txbTimestampHexResult.Name = "txbTimestampHexResult";
            txbTimestampHexResult.ReadOnly = true;
            txbTimestampHexResult.Size = new Size(162, 23);
            txbTimestampHexResult.TabIndex = 25;
            txbTimestampHexResult.TextAlign = HorizontalAlignment.Center;
            // 
            // txbTimestampDecResult
            // 
            txbTimestampDecResult.ImeMode = ImeMode.Off;
            txbTimestampDecResult.Location = new Point(60, 96);
            txbTimestampDecResult.Margin = new Padding(2);
            txbTimestampDecResult.Name = "txbTimestampDecResult";
            txbTimestampDecResult.ReadOnly = true;
            txbTimestampDecResult.Size = new Size(162, 23);
            txbTimestampDecResult.TabIndex = 24;
            txbTimestampDecResult.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 126);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 23;
            label5.Text = "十六进制：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 99);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 22;
            label6.Text = "十进制：";
            // 
            // btnDatetimeToTimestamp
            // 
            btnDatetimeToTimestamp.Location = new Point(225, 47);
            btnDatetimeToTimestamp.Margin = new Padding(2);
            btnDatetimeToTimestamp.Name = "btnDatetimeToTimestamp";
            btnDatetimeToTimestamp.Size = new Size(71, 24);
            btnDatetimeToTimestamp.TabIndex = 19;
            btnDatetimeToTimestamp.Text = "转换";
            btnDatetimeToTimestamp.UseVisualStyleBackColor = true;
            btnDatetimeToTimestamp.Click += btnDatetimeToTimestamp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 8;
            label3.Text = "时间戳：";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 610);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "各时区时间戳转换器";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listTime;
        private ColumnHeader columnTimezone;
        private ColumnHeader columnDateTime;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txbTimestampDec;
        private TextBox txbTimestampHex;
        private Button btnCopyTimestampHex;
        private Button btnCopyTimestampDec;
        private GroupBox groupBox2;
        private TextBox txbTimestamp;
        private Label label4;
        private Button btnTimestampToDatetime;
        private CheckBox chkTimestampHex;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox txbTimestampHexResult;
        private TextBox txbTimestampDecResult;
        private Label label5;
        private Label label6;
        private Button btnDatetimeToTimestamp;
        private Label label3;
        private DateTimePicker dateInputTime;
        private Label label8;
        private ComboBox cmbTimezoneSelect;
        private TextBox txbTimestampEx;
        private Label lblTimestampFormat;
    }
}
