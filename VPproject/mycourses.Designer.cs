namespace VPproject
{
    partial class mycourses
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.mycourses_btn = new System.Windows.Forms.Button();
            this.myacc_btn = new System.Windows.Forms.Button();
            this.bookc_btn = new System.Windows.Forms.Button();
            this.courses_data = new System.Windows.Forms.DataGridView();
            this.nodata_lbl = new System.Windows.Forms.Label();
            this.bnow_llbl = new System.Windows.Forms.LinkLabel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courses_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(164)))));
            this.label8.Location = new System.Drawing.Point(20, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 49);
            this.label8.TabIndex = 49;
            this.label8.Text = "My Courses";
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
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 20);
            this.panel3.TabIndex = 50;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.logout_btn.Location = new System.Drawing.Point(745, -3);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(76, 26);
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
            this.mycourses_btn.Location = new System.Drawing.Point(147, -2);
            this.mycourses_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mycourses_btn.Name = "mycourses_btn";
            this.mycourses_btn.Size = new System.Drawing.Size(93, 24);
            this.mycourses_btn.TabIndex = 5;
            this.mycourses_btn.TabStop = false;
            this.mycourses_btn.Text = "My Courses";
            this.mycourses_btn.UseVisualStyleBackColor = false;
            // 
            // myacc_btn
            // 
            this.myacc_btn.BackColor = System.Drawing.Color.Transparent;
            this.myacc_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.myacc_btn.FlatAppearance.BorderSize = 0;
            this.myacc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myacc_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.myacc_btn.Location = new System.Drawing.Point(0, 0);
            this.myacc_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myacc_btn.Name = "myacc_btn";
            this.myacc_btn.Size = new System.Drawing.Size(142, 22);
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
            this.bookc_btn.Location = new System.Drawing.Point(245, 0);
            this.bookc_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookc_btn.Name = "bookc_btn";
            this.bookc_btn.Size = new System.Drawing.Size(108, 23);
            this.bookc_btn.TabIndex = 3;
            this.bookc_btn.TabStop = false;
            this.bookc_btn.Text = "Book a Course";
            this.bookc_btn.UseVisualStyleBackColor = false;
            this.bookc_btn.Click += new System.EventHandler(this.bookc_btn_Click);
            // 
            // courses_data
            // 
            this.courses_data.AllowUserToAddRows = false;
            this.courses_data.AllowUserToDeleteRows = false;
            this.courses_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courses_data.Location = new System.Drawing.Point(20, 104);
            this.courses_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courses_data.Name = "courses_data";
            this.courses_data.ReadOnly = true;
            this.courses_data.RowHeadersWidth = 51;
            this.courses_data.RowTemplate.Height = 29;
            this.courses_data.Size = new System.Drawing.Size(788, 370);
            this.courses_data.TabIndex = 51;
            this.courses_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courses_data_CellContentClick);
            // 
            // nodata_lbl
            // 
            this.nodata_lbl.AutoSize = true;
            this.nodata_lbl.BackColor = System.Drawing.Color.Transparent;
            this.nodata_lbl.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nodata_lbl.ForeColor = System.Drawing.Color.Brown;
            this.nodata_lbl.Location = new System.Drawing.Point(339, 270);
            this.nodata_lbl.Name = "nodata_lbl";
            this.nodata_lbl.Size = new System.Drawing.Size(162, 24);
            this.nodata_lbl.TabIndex = 52;
            this.nodata_lbl.Text = "No Courses Found";
            this.nodata_lbl.Visible = false;
            // 
            // bnow_llbl
            // 
            this.bnow_llbl.AutoSize = true;
            this.bnow_llbl.Location = new System.Drawing.Point(339, 293);
            this.bnow_llbl.Name = "bnow_llbl";
            this.bnow_llbl.Size = new System.Drawing.Size(114, 15);
            this.bnow_llbl.TabIndex = 53;
            this.bnow_llbl.TabStop = true;
            this.bnow_llbl.Text = "Book a Course Now!";
            this.bnow_llbl.Visible = false;
            this.bnow_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // mycourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(832, 500);
            this.Controls.Add(this.bnow_llbl);
            this.Controls.Add(this.nodata_lbl);
            this.Controls.Add(this.courses_data);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "mycourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mycourses";
            this.Load += new System.EventHandler(this.mycourses_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courses_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label8;
        private Panel panel3;
        private Button logout_btn;
        private Button mycourses_btn;
        private Button myacc_btn;
        private Button bookc_btn;
        private DataGridView courses_data;
        private Label nodata_lbl;
        private LinkLabel bnow_llbl;
    }
}