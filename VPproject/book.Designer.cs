namespace VPproject
{
    partial class book
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.ctotal_txt = new System.Windows.Forms.TextBox();
            this.Course = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvl_txt = new System.Windows.Forms.TextBox();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.req_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.invins_pic = new System.Windows.Forms.PictureBox();
            this.invins_lbl = new System.Windows.Forms.Label();
            this.invcourse_pic = new System.Windows.Forms.PictureBox();
            this.invcourse_lbl = new System.Windows.Forms.Label();
            this.ins_box = new System.Windows.Forms.ListBox();
            this.hours_numeric = new System.Windows.Forms.NumericUpDown();
            this.course_box = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.d_pick = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.RadioButton();
            this.C1 = new System.Windows.Forms.RadioButton();
            this.B2 = new System.Windows.Forms.RadioButton();
            this.B1 = new System.Windows.Forms.RadioButton();
            this.A2 = new System.Windows.Forms.RadioButton();
            this.A1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.mycourses_btn = new System.Windows.Forms.Button();
            this.myacc_btn = new System.Windows.Forms.Button();
            this.bookc_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invins_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invcourse_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_numeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.ctotal_txt);
            this.panel5.Controls.Add(this.Course);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lvl_txt);
            this.panel5.Controls.Add(this.total_txt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(444, 255);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(108, 217);
            this.panel5.TabIndex = 45;
            // 
            // ctotal_txt
            // 
            this.ctotal_txt.Location = new System.Drawing.Point(2, 45);
            this.ctotal_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ctotal_txt.Name = "ctotal_txt";
            this.ctotal_txt.ReadOnly = true;
            this.ctotal_txt.Size = new System.Drawing.Size(100, 27);
            this.ctotal_txt.TabIndex = 5;
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.BackColor = System.Drawing.Color.Transparent;
            this.Course.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Course.Location = new System.Drawing.Point(2, 17);
            this.Course.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(84, 18);
            this.Course.TabIndex = 6;
            this.Course.Text = "Course Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Level Total";
            // 
            // lvl_txt
            // 
            this.lvl_txt.Location = new System.Drawing.Point(2, 105);
            this.lvl_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvl_txt.Name = "lvl_txt";
            this.lvl_txt.ReadOnly = true;
            this.lvl_txt.Size = new System.Drawing.Size(100, 27);
            this.lvl_txt.TabIndex = 8;
            // 
            // total_txt
            // 
            this.total_txt.Location = new System.Drawing.Point(2, 165);
            this.total_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.total_txt.Name = "total_txt";
            this.total_txt.PlaceholderText = "Hours x Total";
            this.total_txt.ReadOnly = true;
            this.total_txt.Size = new System.Drawing.Size(100, 27);
            this.total_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Net Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.label4.Location = new System.Drawing.Point(8, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 35);
            this.label4.TabIndex = 43;
            this.label4.Text = "Instructor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 35);
            this.label1.TabIndex = 43;
            this.label1.Text = "Additional Requests:";
            // 
            // req_txt
            // 
            this.req_txt.AcceptsReturn = true;
            this.req_txt.Location = new System.Drawing.Point(3, 47);
            this.req_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.req_txt.Multiline = true;
            this.req_txt.Name = "req_txt";
            this.req_txt.Size = new System.Drawing.Size(242, 164);
            this.req_txt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(8, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 35);
            this.label2.TabIndex = 47;
            this.label2.Text = "Credit Hours:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.req_txt);
            this.panel1.Location = new System.Drawing.Point(145, 253);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 219);
            this.panel1.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.invins_pic);
            this.panel4.Controls.Add(this.invins_lbl);
            this.panel4.Controls.Add(this.invcourse_pic);
            this.panel4.Controls.Add(this.invcourse_lbl);
            this.panel4.Controls.Add(this.ins_box);
            this.panel4.Controls.Add(this.hours_numeric);
            this.panel4.Controls.Add(this.course_box);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.d_pick);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(232, 99);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(570, 488);
            this.panel4.TabIndex = 47;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // invins_pic
            // 
            this.invins_pic.BackgroundImage = global::VPproject.Properties.Resources.ki85qL9kT;
            this.invins_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.invins_pic.Location = new System.Drawing.Point(183, 121);
            this.invins_pic.Name = "invins_pic";
            this.invins_pic.Size = new System.Drawing.Size(15, 15);
            this.invins_pic.TabIndex = 55;
            this.invins_pic.TabStop = false;
            this.invins_pic.Visible = false;
            // 
            // invins_lbl
            // 
            this.invins_lbl.AutoSize = true;
            this.invins_lbl.BackColor = System.Drawing.Color.Transparent;
            this.invins_lbl.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.invins_lbl.ForeColor = System.Drawing.Color.Red;
            this.invins_lbl.Location = new System.Drawing.Point(203, 121);
            this.invins_lbl.Name = "invins_lbl";
            this.invins_lbl.Size = new System.Drawing.Size(178, 18);
            this.invins_lbl.TabIndex = 54;
            this.invins_lbl.Text = "Please Choose an Instructor";
            this.invins_lbl.Visible = false;
            // 
            // invcourse_pic
            // 
            this.invcourse_pic.BackgroundImage = global::VPproject.Properties.Resources.ki85qL9kT;
            this.invcourse_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.invcourse_pic.Location = new System.Drawing.Point(183, 53);
            this.invcourse_pic.Name = "invcourse_pic";
            this.invcourse_pic.Size = new System.Drawing.Size(15, 15);
            this.invcourse_pic.TabIndex = 53;
            this.invcourse_pic.TabStop = false;
            this.invcourse_pic.Visible = false;
            // 
            // invcourse_lbl
            // 
            this.invcourse_lbl.AutoSize = true;
            this.invcourse_lbl.BackColor = System.Drawing.Color.Transparent;
            this.invcourse_lbl.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.invcourse_lbl.ForeColor = System.Drawing.Color.Red;
            this.invcourse_lbl.Location = new System.Drawing.Point(203, 53);
            this.invcourse_lbl.Name = "invcourse_lbl";
            this.invcourse_lbl.Size = new System.Drawing.Size(152, 18);
            this.invcourse_lbl.TabIndex = 52;
            this.invcourse_lbl.Text = "Please Choose a Course";
            this.invcourse_lbl.Visible = false;
            // 
            // ins_box
            // 
            this.ins_box.FormattingEnabled = true;
            this.ins_box.ItemHeight = 20;
            this.ins_box.Items.AddRange(new object[] {
            "(Choose an instructor)"});
            this.ins_box.Location = new System.Drawing.Point(183, 94);
            this.ins_box.Name = "ins_box";
            this.ins_box.ScrollAlwaysVisible = true;
            this.ins_box.Size = new System.Drawing.Size(244, 24);
            this.ins_box.TabIndex = 51;
            this.ins_box.SelectedIndexChanged += new System.EventHandler(this.ins_box_SelectedIndexChanged);
            // 
            // hours_numeric
            // 
            this.hours_numeric.Location = new System.Drawing.Point(183, 213);
            this.hours_numeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hours_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hours_numeric.Name = "hours_numeric";
            this.hours_numeric.Size = new System.Drawing.Size(102, 27);
            this.hours_numeric.TabIndex = 50;
            this.hours_numeric.TabStop = false;
            this.hours_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hours_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hours_numeric.ValueChanged += new System.EventHandler(this.hours_numeric_ValueChanged);
            // 
            // course_box
            // 
            this.course_box.FormattingEnabled = true;
            this.course_box.ItemHeight = 20;
            this.course_box.Items.AddRange(new object[] {
            "(Choose a course)",
            "Spanish Course",
            "Chinese Course",
            "Japanese Course",
            "Hindi Course",
            "English Course",
            "Arabic Course",
            "Russian Course"});
            this.course_box.Location = new System.Drawing.Point(183, 26);
            this.course_box.Name = "course_box";
            this.course_box.ScrollAlwaysVisible = true;
            this.course_box.Size = new System.Drawing.Size(244, 24);
            this.course_box.TabIndex = 49;
            this.course_box.TabStop = false;
            this.course_box.Tag = "";
            this.course_box.UseTabStops = false;
            this.course_box.SelectedIndexChanged += new System.EventHandler(this.course_box_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 35);
            this.label7.TabIndex = 41;
            this.label7.Text = "Course:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.label6.Location = new System.Drawing.Point(8, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 35);
            this.label6.TabIndex = 39;
            this.label6.Text = "Start Date:";
            // 
            // d_pick
            // 
            this.d_pick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.d_pick.Location = new System.Drawing.Point(183, 154);
            this.d_pick.MaxDate = new System.DateTime(2024, 2, 1, 0, 0, 0, 0);
            this.d_pick.MinDate = new System.DateTime(2023, 1, 20, 0, 0, 0, 0);
            this.d_pick.Name = "d_pick";
            this.d_pick.Size = new System.Drawing.Size(102, 27);
            this.d_pick.TabIndex = 40;
            this.d_pick.TabStop = false;
            this.d_pick.Value = new System.DateTime(2023, 1, 20, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.C2);
            this.panel2.Controls.Add(this.C1);
            this.panel2.Controls.Add(this.B2);
            this.panel2.Controls.Add(this.B1);
            this.panel2.Controls.Add(this.A2);
            this.panel2.Controls.Add(this.A1);
            this.panel2.Location = new System.Drawing.Point(13, 253);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 219);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.label10.Location = new System.Drawing.Point(1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 35);
            this.label10.TabIndex = 42;
            this.label10.Text = "Level:";
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.Location = new System.Drawing.Point(2, 190);
            this.C2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(85, 24);
            this.C2.TabIndex = 6;
            this.C2.TabStop = true;
            this.C2.Text = "C2 (60$)";
            this.C2.UseVisualStyleBackColor = true;
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Location = new System.Drawing.Point(2, 158);
            this.C1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(85, 24);
            this.C1.TabIndex = 5;
            this.C1.TabStop = true;
            this.C1.Text = "C1 (50$)";
            this.C1.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            this.B2.AutoSize = true;
            this.B2.Location = new System.Drawing.Point(2, 126);
            this.B2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(85, 24);
            this.B2.TabIndex = 4;
            this.B2.TabStop = true;
            this.B2.Text = "B2 (40$)";
            this.B2.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            this.B1.AutoSize = true;
            this.B1.Location = new System.Drawing.Point(2, 96);
            this.B1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(85, 24);
            this.B1.TabIndex = 3;
            this.B1.TabStop = true;
            this.B1.Text = "B1 (30$)";
            this.B1.UseVisualStyleBackColor = true;
            // 
            // A2
            // 
            this.A2.AutoSize = true;
            this.A2.Location = new System.Drawing.Point(2, 66);
            this.A2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(86, 24);
            this.A2.TabIndex = 2;
            this.A2.TabStop = true;
            this.A2.Text = "A2 (20$)";
            this.A2.UseVisualStyleBackColor = true;
            // 
            // A1
            // 
            this.A1.AutoSize = true;
            this.A1.Location = new System.Drawing.Point(2, 38);
            this.A1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(86, 24);
            this.A1.TabIndex = 1;
            this.A1.TabStop = true;
            this.A1.Text = "A1 (10$)";
            this.A1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.label8.Location = new System.Drawing.Point(375, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 61);
            this.label8.TabIndex = 45;
            this.label8.Text = "Book a Course";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.panel3.Controls.Add(this.logout_btn);
            this.panel3.Controls.Add(this.mycourses_btn);
            this.panel3.Controls.Add(this.myacc_btn);
            this.panel3.Controls.Add(this.bookc_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 27);
            this.panel3.TabIndex = 46;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.logout_btn.Location = new System.Drawing.Point(931, -3);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(87, 35);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.TabStop = false;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // mycourses_btn
            // 
            this.mycourses_btn.BackColor = System.Drawing.Color.Transparent;
            this.mycourses_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.mycourses_btn.FlatAppearance.BorderSize = 0;
            this.mycourses_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mycourses_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.mycourses_btn.Location = new System.Drawing.Point(168, -1);
            this.mycourses_btn.Name = "mycourses_btn";
            this.mycourses_btn.Size = new System.Drawing.Size(106, 32);
            this.mycourses_btn.TabIndex = 5;
            this.mycourses_btn.TabStop = false;
            this.mycourses_btn.Text = "My Courses";
            this.mycourses_btn.UseVisualStyleBackColor = false;
            this.mycourses_btn.Click += new System.EventHandler(this.mycourses_btn_Click);
            // 
            // myacc_btn
            // 
            this.myacc_btn.BackColor = System.Drawing.Color.Transparent;
            this.myacc_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.myacc_btn.FlatAppearance.BorderSize = 0;
            this.myacc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myacc_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.myacc_btn.Location = new System.Drawing.Point(0, 0);
            this.myacc_btn.Name = "myacc_btn";
            this.myacc_btn.Size = new System.Drawing.Size(162, 30);
            this.myacc_btn.TabIndex = 4;
            this.myacc_btn.TabStop = false;
            this.myacc_btn.Text = "Manage Account";
            this.myacc_btn.UseVisualStyleBackColor = false;
            this.myacc_btn.Click += new System.EventHandler(this.myacc_btn_Click);
            // 
            // bookc_btn
            // 
            this.bookc_btn.BackColor = System.Drawing.Color.Transparent;
            this.bookc_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.bookc_btn.FlatAppearance.BorderSize = 0;
            this.bookc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookc_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.bookc_btn.Location = new System.Drawing.Point(280, -1);
            this.bookc_btn.Name = "bookc_btn";
            this.bookc_btn.Size = new System.Drawing.Size(123, 31);
            this.bookc_btn.TabIndex = 3;
            this.bookc_btn.TabStop = false;
            this.bookc_btn.Text = "Book a Course";
            this.bookc_btn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(606, 598);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 39);
            this.button1.TabIndex = 44;
            this.button1.Text = "Continue To Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1011, 642);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.book_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invins_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invcourse_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_numeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel5;
        private TextBox ctotal_txt;
        private Label Course;
        private Label label3;
        private TextBox lvl_txt;
        private TextBox total_txt;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox req_txt;
        private Label label2;
        private Panel panel1;
        private Panel panel4;
        private Label label7;
        private Label label6;
        private DateTimePicker d_pick;
        private Panel panel2;
        private Label label10;
        private RadioButton C2;
        private RadioButton C1;
        private RadioButton B2;
        private RadioButton B1;
        private RadioButton A2;
        private RadioButton A1;
        private Label label8;
        private Panel panel3;
        private Button logout_btn;
        private Button mycourses_btn;
        private Button myacc_btn;
        private Button bookc_btn;
        private Button button1;
        private NumericUpDown hours_numeric;
        private ListBox course_box;
        private ListBox ins_box;
        private PictureBox invins_pic;
        private Label invins_lbl;
        private PictureBox invcourse_pic;
        private Label invcourse_lbl;
    }
}