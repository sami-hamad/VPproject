using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace VPproject
{
    public partial class create : Form
    {
        private SQLiteConnection conn;
        string dbp = "C:\\Users\\samim\\source\\repos\\VPproject\\VPproject\\bin\\Debug\\customer.db";
        class client
        {
            private string fname;
            private string lname;
            private string email;
            private string password;
            private string dob;
            private string phone;
            public bool setfname(string fname)
            {
                string tex = fname.Trim();
                if (tex.Length == 0) return false;
                for (int i = 0; i < tex.Length; i++)
                {
                    if ((tex[i] >= 'a' && tex[i] <= 'z') || (tex[i] >= 'A' && tex[i] <= 'Z'))
                    { }
                    else
                    {
                        return false;
                    }
                }
                this.fname = fname;
                return true;

            }
            public bool setlname(string lname)
            {
                string tex = lname;
                if (tex.Length == 0) return false;
                for (int i = 0; i < tex.Length; i++)
                {
                    if ((tex[i] >= 'a' && tex[i] <= 'z') || (tex[i] >= 'A' && tex[i] <= 'Z'))
                    { }
                    else
                    {
                        return false;
                    }
                }
                this.lname = lname;
                return true;
            }

            public bool setemail(string email)
            {
                string text = email;
                if (text.Length == 0) return false;

                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                RegexOptions.CultureInvariant | RegexOptions.Singleline);

                bool valid = regex.IsMatch(text);
                if (!valid)
                {
                    return false;
                }
                else
                {
                    this.email = text.ToUpper();
                    return true;
                }

            }
            public int setpass(string pass)
            {
                int cond = 0;
                if (pass.Length == 0)
                {
                    return 0;
                }
                else if (pass.Length < 8)
                {
                    return 1;
                }
                else
                {
                    this.password = pass;
                    return 2;
                }
            }
            public bool setpass2(string pass2)
            {
                if (pass2 != password)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            public bool setphone(string phone)
            {
                string text = phone;
                if (text.Length == 0) return false;

                for (int i = 0; i < text.Length; i++)
                {
                    if ((text[i] >= '0' && text[i] <= '9'))
                    { }
                    else
                    {
                        return false;
                    }
                }
                this.phone = text;
                return true;

            }
            public bool setdob(string dob)
            {
                string[] temp = dob.Split("/");
                int year = int.Parse(temp[2]);
                int curr = System.DateTime.Now.Year;
                if ((curr - year) < 18)
                {
                    return false;
                }
                else
                {
                    this.dob = dob;
                    return true;
                }
            }
            public string getfname() { return fname; }
            public string getlname() { return lname; }
            public string getemail() { return email; }
            public string getpassword() { return password; }
            public string getdob() { return dob; }
            public string getphone() { return phone; }

        }




        public create()
        {
            InitializeComponent();
            conn = new SQLiteConnection($"Data Source={dbp}; Version=3;");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void create_Load(object sender, EventArgs e)
        {

            invfnamelbl.ForeColor = Color.Red;
            invlnamelbl.ForeColor = Color.Red;
            invemail_lbl.ForeColor = Color.Red;
            invphone_lbl.ForeColor = Color.Red;
            invpass2_lbl.ForeColor = Color.Red;
            invpass_lbl.ForeColor = Color.Red; 
        }

        private void invfnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void lname_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dob_pick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pass2_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passport_txt_TextChanged(object sender, EventArgs e)
        {
            

        }




        

        client c1 = new client();
        bool validateall()
        {
            bool [] arr={true,true,true,true,true,true,true};


            string email = email_txt.Text.ToUpper();
            string pass = pass_txt.Text;
            string fname = fname_txt.Text;
            string lname = lname_txt.Text;
            string dob = dob_pick.Value.ToShortDateString();
            int year = dob_pick.Value.Year;
            string phone = phone_txt.Text;
            string pass2 = pass2_txt.Text;

            if (c1.setfname(fname))
            {
                invfnamelbl.Hide();
                invfname_pic.Hide();
            }
            else
            {
                invfnamelbl.Show();
                invfname_pic.Show();
                arr[0] = false;
            }
            if (c1.setlname(lname))
            {
                invlnamelbl.Hide();
                invlname_pic.Hide();
            }
            else
            {
                invlnamelbl.Show();
                invlname_pic.Show();
                arr[1] = false;
            }
            if (c1.setemail(email)) 
            {
                invemail_lbl.Hide();
                invemail_pic.Hide();
            }
            else
            {
                invemail_lbl.Show();
                invemail_pic.Show();
                arr[2] = false;
            }
            if (c1.setpass(pass)==0)
            {
                invpass_lbl.Text = "Please enter a password";
                invpass_lbl.Show();
                invpass_pic.Show();
                arr[3] = false;
            }
            else if(c1.setpass(pass) == 1)
            {
                invpass_lbl.Text = "Enter at lease 8 characters";
                invpass_lbl.Show();
                invpass_pic.Show();
                arr[3] = false;
            }
            else
            {
                invpass_lbl.Hide();
                invpass_pic.Hide();
            }
            if (c1.setpass2(pass2))
            {
                invpass2_pic.Hide();
                invpass2_lbl.Hide();
            }
            else
            {
                invpass2_lbl.Show();
                invpass2_pic.Show();
                arr[4] = false;
            }
            if (c1.setdob(dob))
            {
                invdob_pic.Hide();
                invdob_lbl.Hide();
            }
            else
            {
                invdob_lbl.Show();
                invdob_pic.Show();
                arr[5] = false;
            }
            if (c1.setphone(phone))
            {
                invphone_lbl.Hide();
                invphone_pic.Hide();
            }
            else
            {
                invphone_lbl.Show();
                invphone_pic.Show();
                arr[6] = false;
            }

            foreach(bool i in arr)
            {
                if(i==false)
                    return false;
            }
            return true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (validateall())
            {
                string [] info = {email_txt.Text.ToString().ToUpper(), pass_txt.Text, fname_txt.Text, lname_txt.Text, phone_txt.Text, dob_pick.Value.ToShortDateString()};

                try
                {
                    conn.Open();
                    string sql = $"INSERT INTO client values('{info[0]}','{info[1]}','{info[2]}','{info[3]}','{info[4]}','{info[5]}')";
                    SQLiteCommand command = new SQLiteCommand(sql, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    Form form = new login();
                    form.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        
                        //if email is already taken
                        invemail_lbl.Text = "Email is already taken!";
                        invemail_lbl.Show();
                        invemail_pic.Show();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void pass_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back button
            Form form = new Form1();
            form.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
