namespace ParkingDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.CommSet_groupBox = new System.Windows.Forms.GroupBox();
			this.CommBaud_comboBox = new System.Windows.Forms.ComboBox();
			this.CommPort_comboBox = new System.Windows.Forms.ComboBox();
			this.OpenClosePort_Button = new System.Windows.Forms.Button();
			this.CommStatus_label = new System.Windows.Forms.Label();
			this.CommBaud_label = new System.Windows.Forms.Label();
			this.CommPort_label = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.light73 = new System.Windows.Forms.Label();
			this.light74 = new System.Windows.Forms.Label();
			this.light75 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.haveCarLight = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.NoCarLight = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.light78 = new System.Windows.Forms.Label();
			this.light79 = new System.Windows.Forms.Label();
			this.light7A = new System.Windows.Forms.Label();
			this.light7B = new System.Windows.Forms.Label();
			this.light81 = new System.Windows.Forms.Label();
			this.light76 = new System.Windows.Forms.Label();
			this.light77 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.close = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.ethConfiggroupBox = new System.Windows.Forms.GroupBox();
			this.listenstatelabel = new System.Windows.Forms.Label();
			this.deviceIPstatelabel = new System.Windows.Forms.Label();
			this.startListenbutton = new System.Windows.Forms.Button();
			this.deviceIPlabel = new System.Windows.Forms.Label();
			this.connectstatelabel = new System.Windows.Forms.Label();
			this.label87 = new System.Windows.Forms.Label();
			this.severPorttextBox = new System.Windows.Forms.TextBox();
			this.severPortlabel = new System.Windows.Forms.Label();
			this.severIPcomboBox = new System.Windows.Forms.ComboBox();
			this.severIPlabel = new System.Windows.Forms.Label();
			this.CommSet_groupBox.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.ethConfiggroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// CommSet_groupBox
			// 
			this.CommSet_groupBox.AutoSize = true;
			this.CommSet_groupBox.Controls.Add(this.CommBaud_comboBox);
			this.CommSet_groupBox.Controls.Add(this.CommPort_comboBox);
			this.CommSet_groupBox.Controls.Add(this.OpenClosePort_Button);
			this.CommSet_groupBox.Controls.Add(this.CommStatus_label);
			this.CommSet_groupBox.Controls.Add(this.CommBaud_label);
			this.CommSet_groupBox.Controls.Add(this.CommPort_label);
			this.CommSet_groupBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CommSet_groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(61)))));
			this.CommSet_groupBox.Location = new System.Drawing.Point(9, 79);
			this.CommSet_groupBox.Margin = new System.Windows.Forms.Padding(4);
			this.CommSet_groupBox.Name = "CommSet_groupBox";
			this.CommSet_groupBox.Padding = new System.Windows.Forms.Padding(4);
			this.CommSet_groupBox.Size = new System.Drawing.Size(987, 115);
			this.CommSet_groupBox.TabIndex = 7;
			this.CommSet_groupBox.TabStop = false;
			this.CommSet_groupBox.Text = "Comm  Port  Set";
			// 
			// CommBaud_comboBox
			// 
			this.CommBaud_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CommBaud_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "230400",
            "256000"});
			this.CommBaud_comboBox.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CommBaud_comboBox.FormattingEnabled = true;
			this.CommBaud_comboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CommBaud_comboBox.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
			this.CommBaud_comboBox.Location = new System.Drawing.Point(512, 35);
			this.CommBaud_comboBox.Margin = new System.Windows.Forms.Padding(4);
			this.CommBaud_comboBox.Name = "CommBaud_comboBox";
			this.CommBaud_comboBox.Size = new System.Drawing.Size(171, 29);
			this.CommBaud_comboBox.TabIndex = 5;
			// 
			// CommPort_comboBox
			// 
			this.CommPort_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CommPort_comboBox.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CommPort_comboBox.FormattingEnabled = true;
			this.CommPort_comboBox.Location = new System.Drawing.Point(206, 35);
			this.CommPort_comboBox.Margin = new System.Windows.Forms.Padding(4);
			this.CommPort_comboBox.Name = "CommPort_comboBox";
			this.CommPort_comboBox.Size = new System.Drawing.Size(171, 29);
			this.CommPort_comboBox.TabIndex = 4;
			// 
			// OpenClosePort_Button
			// 
			this.OpenClosePort_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.OpenClosePort_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(61)))));
			this.OpenClosePort_Button.FlatAppearance.BorderSize = 0;
			this.OpenClosePort_Button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OpenClosePort_Button.ForeColor = System.Drawing.Color.White;
			this.OpenClosePort_Button.Location = new System.Drawing.Point(775, 25);
			this.OpenClosePort_Button.Margin = new System.Windows.Forms.Padding(4);
			this.OpenClosePort_Button.Name = "OpenClosePort_Button";
			this.OpenClosePort_Button.Size = new System.Drawing.Size(135, 58);
			this.OpenClosePort_Button.TabIndex = 3;
			this.OpenClosePort_Button.Text = "Open  Comm";
			this.OpenClosePort_Button.UseVisualStyleBackColor = false;
			this.OpenClosePort_Button.Click += new System.EventHandler(this.OpenClosePort_Button_Click);
			// 
			// CommStatus_label
			// 
			this.CommStatus_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CommStatus_label.AutoSize = true;
			this.CommStatus_label.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CommStatus_label.ForeColor = System.Drawing.Color.DarkGray;
			this.CommStatus_label.Location = new System.Drawing.Point(706, 35);
			this.CommStatus_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CommStatus_label.Name = "CommStatus_label";
			this.CommStatus_label.Size = new System.Drawing.Size(43, 30);
			this.CommStatus_label.TabIndex = 2;
			this.CommStatus_label.Text = "●";
			// 
			// CommBaud_label
			// 
			this.CommBaud_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CommBaud_label.AutoSize = true;
			this.CommBaud_label.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CommBaud_label.ForeColor = System.Drawing.Color.Black;
			this.CommBaud_label.Location = new System.Drawing.Point(400, 35);
			this.CommBaud_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CommBaud_label.Name = "CommBaud_label";
			this.CommBaud_label.Size = new System.Drawing.Size(94, 22);
			this.CommBaud_label.TabIndex = 1;
			this.CommBaud_label.Text = "Baud  Rate:";
			// 
			// CommPort_label
			// 
			this.CommPort_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CommPort_label.AutoSize = true;
			this.CommPort_label.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CommPort_label.ForeColor = System.Drawing.Color.Black;
			this.CommPort_label.Location = new System.Drawing.Point(97, 40);
			this.CommPort_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CommPort_label.Name = "CommPort_label";
			this.CommPort_label.Size = new System.Drawing.Size(98, 22);
			this.CommPort_label.TabIndex = 0;
			this.CommPort_label.Text = "Port  Name:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(9, 514);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(987, 127);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// light73
			// 
			this.light73.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.light73.AutoSize = true;
			this.light73.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.light73.ForeColor = System.Drawing.Color.DarkGray;
			this.light73.Location = new System.Drawing.Point(286, 81);
			this.light73.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.light73.Name = "light73";
			this.light73.Size = new System.Drawing.Size(43, 30);
			this.light73.TabIndex = 12;
			this.light73.Text = "●";
			// 
			// light74
			// 
			this.light74.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.light74.AutoSize = true;
			this.light74.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.light74.ForeColor = System.Drawing.Color.DarkGray;
			this.light74.Location = new System.Drawing.Point(286, 127);
			this.light74.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.light74.Name = "light74";
			this.light74.Size = new System.Drawing.Size(43, 30);
			this.light74.TabIndex = 13;
			this.light74.Text = "●";
			this.light74.Click += new System.EventHandler(this.light74_Click);
			// 
			// light75
			// 
			this.light75.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.light75.AutoSize = true;
			this.light75.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.light75.ForeColor = System.Drawing.Color.DarkGray;
			this.light75.Location = new System.Drawing.Point(286, 176);
			this.light75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.light75.Name = "light75";
			this.light75.Size = new System.Drawing.Size(43, 30);
			this.light75.TabIndex = 14;
			this.light75.Text = "●";
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSize = true;
			this.groupBox2.Controls.Add(this.haveCarLight);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.NoCarLight);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.light78);
			this.groupBox2.Controls.Add(this.light79);
			this.groupBox2.Controls.Add(this.light7A);
			this.groupBox2.Controls.Add(this.light7B);
			this.groupBox2.Controls.Add(this.light81);
			this.groupBox2.Controls.Add(this.light76);
			this.groupBox2.Controls.Add(this.light77);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.light73);
			this.groupBox2.Controls.Add(this.light75);
			this.groupBox2.Controls.Add(this.light74);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(61)))));
			this.groupBox2.Location = new System.Drawing.Point(9, 353);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(987, 389);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sensor Status";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// haveCarLight
			// 
			this.haveCarLight.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.haveCarLight.AutoSize = true;
			this.haveCarLight.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.haveCarLight.ForeColor = System.Drawing.Color.DarkGray;
			this.haveCarLight.Location = new System.Drawing.Point(286, 330);
			this.haveCarLight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.haveCarLight.Name = "haveCarLight";
			this.haveCarLight.Size = new System.Drawing.Size(43, 30);
			this.haveCarLight.TabIndex = 39;
			this.haveCarLight.Text = "●";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(510, 330);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(79, 23);
			this.label18.TabIndex = 38;
			this.label18.Text = "No Car";
			this.label18.Click += new System.EventHandler(this.label18_Click);
			// 
			// NoCarLight
			// 
			this.NoCarLight.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NoCarLight.AutoSize = true;
			this.NoCarLight.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.NoCarLight.ForeColor = System.Drawing.Color.DarkGray;
			this.NoCarLight.Location = new System.Drawing.Point(708, 330);
			this.NoCarLight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NoCarLight.Name = "NoCarLight";
			this.NoCarLight.Size = new System.Drawing.Size(43, 30);
			this.NoCarLight.TabIndex = 37;
			this.NoCarLight.Text = "●";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(52, 330);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(102, 23);
			this.label16.TabIndex = 36;
			this.label16.Text = "Have Car";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(695, 42);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(66, 23);
			this.label15.TabIndex = 35;
			this.label15.Text = "Status";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(510, 42);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(99, 23);
			this.label14.TabIndex = 34;
			this.label14.Text = "Sensor ID";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(274, 42);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(66, 23);
			this.label13.TabIndex = 33;
			this.label13.Text = "Status";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(71, 42);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(99, 23);
			this.label12.TabIndex = 32;
			this.label12.Text = "Sensor ID";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// light78
			// 
			this.light78.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.light78.AutoSize = true;
			this.light78.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.light78.ForeColor = System.Drawing.Color.DarkGray;
			this.light78.Location = new System.Drawing.Point(708, 81);
			this.light78.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.light78.Name = "light78";
			this.light78.Size = new System.Drawing.Size(43, 30);
			this.light78.TabIndex = 31;
			this.light78.Text = "●";
			// 
			// light79
			// 
			this.light79.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.light79.AutoSize = true;
			this.light79.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.light79.ForeColor = System.Drawing.Color.DarkGray;
			this.light79.Location = new System.Drawing.Point(708, 127);
			this.light79.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.light79.Name = "light79";
			this.light79.Size = new System.Drawing.Size(43, 30);
			this.light79.TabIndex = 30;
			this.light79.Text = "●";
			// 
			// light7A
			// 
			this.light7A.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.light7A.AutoSize = true;
			this.light7A.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.light7A.ForeColor = System.Drawing.Color.DarkGray;
			this.light7A.Location = new System.Drawing.Point(708, 176);
			this.light7A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.light7A.Name = "light7A";
			this.light7A.Size = new System.Drawing.Size(43, 30);
			this.light7A.TabIndex = 29;
			this.light7A.Text = "●";
			// 
			// light7B
			// 
			this.light7B.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.light7B.AutoSize = true;
			this.light7B.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.light7B.ForeColor = System.Drawing.Color.DarkGray;
			this.light7B.Location = new System.Drawing.Point(708, 226);
			this.light7B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.light7B.Name = "light7B";
			this.light7B.Size = new System.Drawing.Size(43, 30);
			this.light7B.TabIndex = 28;
			this.light7B.Text = "●";
			// 
			// light81
			// 
			this.light81.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.light81.AutoSize = true;
			this.light81.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.light81.ForeColor = System.Drawing.Color.DarkGray;
			this.light81.Location = new System.Drawing.Point(708, 279);
			this.light81.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.light81.Name = "light81";
			this.light81.Size = new System.Drawing.Size(43, 30);
			this.light81.TabIndex = 27;
			this.light81.Text = "●";
			// 
			// light76
			// 
			this.light76.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.light76.AutoSize = true;
			this.light76.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.light76.ForeColor = System.Drawing.Color.DarkGray;
			this.light76.Location = new System.Drawing.Point(286, 226);
			this.light76.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.light76.Name = "light76";
			this.light76.Size = new System.Drawing.Size(43, 30);
			this.light76.TabIndex = 26;
			this.light76.Text = "●";
			// 
			// light77
			// 
			this.light77.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.light77.AutoSize = true;
			this.light77.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.light77.ForeColor = System.Drawing.Color.DarkGray;
			this.light77.Location = new System.Drawing.Point(286, 279);
			this.light77.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.light77.Name = "light77";
			this.light77.Size = new System.Drawing.Size(43, 30);
			this.light77.TabIndex = 25;
			this.light77.Text = "●";
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(510, 91);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 22);
			this.label10.TabIndex = 24;
			this.label10.Text = "283A7851";
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(510, 137);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 22);
			this.label9.TabIndex = 23;
			this.label9.Text = "283A7951";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(510, 289);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 22);
			this.label8.TabIndex = 22;
			this.label8.Text = "283A8151";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(510, 236);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 22);
			this.label7.TabIndex = 21;
			this.label7.Text = "283A7B51";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(510, 186);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 22);
			this.label6.TabIndex = 20;
			this.label6.Text = "283A7A51";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(71, 289);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 22);
			this.label5.TabIndex = 19;
			this.label5.Text = "283A7751";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(71, 236);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 22);
			this.label4.TabIndex = 18;
			this.label4.Text = "283A7651";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(71, 186);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 22);
			this.label3.TabIndex = 17;
			this.label3.Text = "283A7551";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(71, 137);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 22);
			this.label2.TabIndex = 16;
			this.label2.Text = "283A7451";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(71, 91);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 22);
			this.label1.TabIndex = 15;
			this.label1.Text = "283A7351";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(61)))));
			this.panel1.Controls.Add(this.close);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Location = new System.Drawing.Point(-1, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1010, 53);
			this.panel1.TabIndex = 6;
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.Maroon;
			this.close.FlatAppearance.BorderSize = 0;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.close.ForeColor = System.Drawing.SystemColors.Window;
			this.close.Location = new System.Drawing.Point(970, 12);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(27, 28);
			this.close.TabIndex = 2;
			this.close.Text = "X";
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.MintCream;
			this.label11.Location = new System.Drawing.Point(11, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(821, 38);
			this.label11.TabIndex = 0;
			this.label11.Text = "Smart Car Parking (National Institute of Electronics)";
			// 
			// ethConfiggroupBox
			// 
			this.ethConfiggroupBox.Controls.Add(this.listenstatelabel);
			this.ethConfiggroupBox.Controls.Add(this.deviceIPstatelabel);
			this.ethConfiggroupBox.Controls.Add(this.startListenbutton);
			this.ethConfiggroupBox.Controls.Add(this.deviceIPlabel);
			this.ethConfiggroupBox.Controls.Add(this.connectstatelabel);
			this.ethConfiggroupBox.Controls.Add(this.label87);
			this.ethConfiggroupBox.Controls.Add(this.severPorttextBox);
			this.ethConfiggroupBox.Controls.Add(this.severPortlabel);
			this.ethConfiggroupBox.Controls.Add(this.severIPcomboBox);
			this.ethConfiggroupBox.Controls.Add(this.severIPlabel);
			this.ethConfiggroupBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
			this.ethConfiggroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(61)))));
			this.ethConfiggroupBox.Location = new System.Drawing.Point(9, 202);
			this.ethConfiggroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.ethConfiggroupBox.Name = "ethConfiggroupBox";
			this.ethConfiggroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.ethConfiggroupBox.Size = new System.Drawing.Size(987, 143);
			this.ethConfiggroupBox.TabIndex = 16;
			this.ethConfiggroupBox.TabStop = false;
			this.ethConfiggroupBox.Text = "Ethernet  Port Set";
			// 
			// listenstatelabel
			// 
			this.listenstatelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.listenstatelabel.AutoSize = true;
			this.listenstatelabel.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listenstatelabel.ForeColor = System.Drawing.Color.DarkGray;
			this.listenstatelabel.Location = new System.Drawing.Point(706, 37);
			this.listenstatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.listenstatelabel.Name = "listenstatelabel";
			this.listenstatelabel.Size = new System.Drawing.Size(43, 30);
			this.listenstatelabel.TabIndex = 6;
			this.listenstatelabel.Text = "●";
			// 
			// deviceIPstatelabel
			// 
			this.deviceIPstatelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.deviceIPstatelabel.AutoSize = true;
			this.deviceIPstatelabel.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deviceIPstatelabel.ForeColor = System.Drawing.Color.Black;
			this.deviceIPstatelabel.Location = new System.Drawing.Point(202, 93);
			this.deviceIPstatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.deviceIPstatelabel.Name = "deviceIPstatelabel";
			this.deviceIPstatelabel.Size = new System.Drawing.Size(61, 22);
			this.deviceIPstatelabel.TabIndex = 14;
			this.deviceIPstatelabel.Text = "0.0.0.0";
			// 
			// startListenbutton
			// 
			this.startListenbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(111)))), ((int)(((byte)(61)))));
			this.startListenbutton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
			this.startListenbutton.ForeColor = System.Drawing.Color.White;
			this.startListenbutton.Location = new System.Drawing.Point(775, 31);
			this.startListenbutton.Margin = new System.Windows.Forms.Padding(4);
			this.startListenbutton.Name = "startListenbutton";
			this.startListenbutton.Size = new System.Drawing.Size(135, 54);
			this.startListenbutton.TabIndex = 10;
			this.startListenbutton.Text = "Start  Listen";
			this.startListenbutton.UseVisualStyleBackColor = false;
			this.startListenbutton.Click += new System.EventHandler(this.startListenbutton_Click_1);
			// 
			// deviceIPlabel
			// 
			this.deviceIPlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.deviceIPlabel.AutoSize = true;
			this.deviceIPlabel.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deviceIPlabel.ForeColor = System.Drawing.Color.Black;
			this.deviceIPlabel.Location = new System.Drawing.Point(118, 93);
			this.deviceIPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.deviceIPlabel.Name = "deviceIPlabel";
			this.deviceIPlabel.Size = new System.Drawing.Size(74, 22);
			this.deviceIPlabel.TabIndex = 13;
			this.deviceIPlabel.Text = "WDC  IP:";
			// 
			// connectstatelabel
			// 
			this.connectstatelabel.AutoSize = true;
			this.connectstatelabel.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connectstatelabel.ForeColor = System.Drawing.Color.Black;
			this.connectstatelabel.Location = new System.Drawing.Point(447, 93);
			this.connectstatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.connectstatelabel.Name = "connectstatelabel";
			this.connectstatelabel.Size = new System.Drawing.Size(149, 22);
			this.connectstatelabel.TabIndex = 12;
			this.connectstatelabel.Text = "Waiting  Connect...";
			// 
			// label87
			// 
			this.label87.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label87.AutoSize = true;
			this.label87.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label87.ForeColor = System.Drawing.Color.Black;
			this.label87.Location = new System.Drawing.Point(378, 93);
			this.label87.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label87.Name = "label87";
			this.label87.Size = new System.Drawing.Size(122, 22);
			this.label87.TabIndex = 11;
			this.label87.Text = "Connect  State:";
			// 
			// severPorttextBox
			// 
			this.severPorttextBox.Font = new System.Drawing.Font("Calibri", 10.5F);
			this.severPorttextBox.Location = new System.Drawing.Point(512, 36);
			this.severPorttextBox.Margin = new System.Windows.Forms.Padding(4);
			this.severPorttextBox.Name = "severPorttextBox";
			this.severPorttextBox.Size = new System.Drawing.Size(171, 29);
			this.severPorttextBox.TabIndex = 9;
			this.severPorttextBox.Text = "6000";
			// 
			// severPortlabel
			// 
			this.severPortlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.severPortlabel.AutoSize = true;
			this.severPortlabel.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.severPortlabel.ForeColor = System.Drawing.Color.Black;
			this.severPortlabel.Location = new System.Drawing.Point(400, 45);
			this.severPortlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.severPortlabel.Name = "severPortlabel";
			this.severPortlabel.Size = new System.Drawing.Size(100, 22);
			this.severPortlabel.TabIndex = 8;
			this.severPortlabel.Text = "Server  Port:";
			// 
			// severIPcomboBox
			// 
			this.severIPcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.severIPcomboBox.Font = new System.Drawing.Font("Calibri", 10.5F);
			this.severIPcomboBox.FormattingEnabled = true;
			this.severIPcomboBox.Items.AddRange(new object[] {
            "192.168.1.2",
            "119.78.248.11",
            "192.168.1.103",
            "192.168.100.106"});
			this.severIPcomboBox.Location = new System.Drawing.Point(206, 38);
			this.severIPcomboBox.Margin = new System.Windows.Forms.Padding(4);
			this.severIPcomboBox.Name = "severIPcomboBox";
			this.severIPcomboBox.Size = new System.Drawing.Size(171, 29);
			this.severIPcomboBox.TabIndex = 7;
			// 
			// severIPlabel
			// 
			this.severIPlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.severIPlabel.AutoSize = true;
			this.severIPlabel.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.severIPlabel.ForeColor = System.Drawing.Color.Black;
			this.severIPlabel.Location = new System.Drawing.Point(108, 43);
			this.severIPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.severIPlabel.Name = "severIPlabel";
			this.severIPlabel.Size = new System.Drawing.Size(83, 22);
			this.severIPlabel.TabIndex = 6;
			this.severIPlabel.Text = "Server  IP:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1009, 753);
			this.Controls.Add(this.ethConfiggroupBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.CommSet_groupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Smart Car Parking";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.CommSet_groupBox.ResumeLayout(false);
			this.CommSet_groupBox.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ethConfiggroupBox.ResumeLayout(false);
			this.ethConfiggroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox CommSet_groupBox;
        private System.Windows.Forms.ComboBox CommBaud_comboBox;
        private System.Windows.Forms.ComboBox CommPort_comboBox;
        private System.Windows.Forms.Button OpenClosePort_Button;
        private System.Windows.Forms.Label CommStatus_label;
        private System.Windows.Forms.Label CommBaud_label;
        private System.Windows.Forms.Label CommPort_label;
        private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label light73;
		private System.Windows.Forms.Label light74;
		private System.Windows.Forms.Label light75;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label light78;
		private System.Windows.Forms.Label light79;
		private System.Windows.Forms.Label light7A;
		private System.Windows.Forms.Label light7B;
		private System.Windows.Forms.Label light81;
		private System.Windows.Forms.Label light76;
		private System.Windows.Forms.Label light77;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label haveCarLight;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label NoCarLight;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.GroupBox ethConfiggroupBox;
		private System.Windows.Forms.Label listenstatelabel;
		private System.Windows.Forms.Label deviceIPstatelabel;
		private System.Windows.Forms.Button startListenbutton;
		private System.Windows.Forms.Label deviceIPlabel;
		private System.Windows.Forms.Label connectstatelabel;
		private System.Windows.Forms.Label label87;
		private System.Windows.Forms.TextBox severPorttextBox;
		private System.Windows.Forms.Label severPortlabel;
		private System.Windows.Forms.ComboBox severIPcomboBox;
		private System.Windows.Forms.Label severIPlabel;
	}
}

