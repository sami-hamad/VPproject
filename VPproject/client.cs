using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace VPproject
{
    public partial class client : Form
    {
        private SQLiteConnection conn2;

        //db path
        string dbp = "C:\\Users\\samim\\source\\repos\\VPproject\\VPproject\\bin\\Debug\\customer.db";

        //text file path
        string txtp = "C:\\Users\\samim\\source\\repos\\VPproject\\VPproject\\bin\\Debug\\client_info.txt";

        //email is passed to constructor to keep track of the user.
        public client(string email)
        {
            InitializeComponent();
            conn2 = new SQLiteConnection($"Data Source={dbp}; Version=3;");
            //passed email is saved in the email textbox
            email_txt.Text = email;
        }

        private void client_Load(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                string email = email_txt.Text.ToUpper();
                
                //query to get user's information using his email
                string sql = $"SELECT fname,lname,phone,dob FROM client where email='{email}'";

                SQLiteCommand command = new SQLiteCommand(sql, conn2);
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //information appears in textboxes
                        fname_txt.Text = reader["fname"].ToString();
                        lname_txt.Text = reader["lname"].ToString();
                        phone_txt.Text = reader["phone"].ToString();
                        dob_pick.Text = reader["dob"].ToString();
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn2.Close();
            }

            // writing to the text file:

            string[] info = { email_txt.Text, fname_txt.Text, lname_txt.Text, phone_txt.Text, dob_pick.Text };

            string[] arr = { "Email: ", "First Name: ", "Last Name: ", "Phone Number: ", "Date of Birth: " };

            //to clear text file
            File.Create(txtp).Close();
            StreamWriter sw = new StreamWriter(txtp);

            //fill the text file
            for (int i = 0; i < info.Length; i++)
            {
                string a = arr[i] + info[i];
                sw.WriteLine(a);
            }

            sw.Close();
            ///////////////////////////////////////////////////////////
        }
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
            return true;

        }
        public bool setlname(string lname)
        {

            string tex = lname.Trim();
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
            return true;

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
            return true;

        }
        public bool setdob(string dob)
        {

            string[] temp = dob.Split("/");
            //dob year
            int year = int.Parse(temp[2]);
            //current year
            int curr = System.DateTime.Now.Year;
            if ((curr - year) < 18)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        bool validateall()
        {
            // this array was made to validate all conditions at once, in other words so that the program don't return false before checking the other conditions 
            bool[] arr = { true, true, true, true, true}; 
            string fname = fname_txt.Text;
            string lname = lname_txt.Text;
            string dob = dob_pick.Value.ToShortDateString();
            string phone = phone_txt.Text;
            

            if (setfname(fname))//if first name is valid
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

            if (setlname(lname))//if last name is valid
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

            if (setdob(dob))// if dob is valid
            {
                invdob_lbl.Hide();
                invdob_pic.Hide();
            }
            else
            {
                invdob_lbl.Show();
                invdob_pic.Show();
                arr[2] = false;
            }

            if (setphone(phone))//if phone is valid
            {
                invphone_lbl.Hide();
                invphone_pic.Hide();
            }
            else
            {
                invphone_lbl.Show();
                invphone_pic.Show();
                arr[3] = false;
            }

            foreach (bool i in arr)//if any of the boxes is invalid the func will return false
            {
                if (i == false)
                    return false;
            }
            return true;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (validateall())
            {

                string[] info = { email_txt.Text, fname_txt.Text, lname_txt.Text, phone_txt.Text, dob_pick.Text };
                try
                {
                    conn2.Open();

                    string sql = $"UPDATE client SET fname='{info[1]}',lname='{info[2]}',phone='{info[3]}',dob='{info[4]}' WHERE email='{info[0]}';";

                    SQLiteCommand command = new SQLiteCommand(sql, conn2);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Information Updated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn2.Close();
                }

                //text file is updated after information is updated

                string[] arr = { "Email: ", "First Name: ", "Last Name: ", "Phone Number: ", "Date of Birth: "};

                //to clear text file
                File.Create(txtp).Close();
                StreamWriter sw = new StreamWriter(txtp);

                //fill the text file
                for (int i = 0; i < info.Length; i++)
                {
                    string a = arr[i] + info[i];
                    sw.WriteLine(a);
                }

                sw.Close();
                //////////////////////////////////////////////////////
            }
        }

        private void deactivate_btn_Click(object sender, EventArgs e)
        {
            string email = email_txt.Text.ToUpper();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your account?", "ACCOUNT DEACTIVATION",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn2.Open();
                    string sql = $"DELETE FROM client WHERE email='{email}';";

                    SQLiteCommand command = new SQLiteCommand(sql, conn2);
                
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account Deactivated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn2.Close();
                }
                //clearing text file
                File.Create(txtp).Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void myacc_btn_Click(object sender, EventArgs e)
        {
            

        }

        private void bookc_btn_Click(object sender, EventArgs e)
        {
            book book = new book(email_txt.Text);
            book.Show();
            this.Close();
        }

        private void mycourses_btn_Click(object sender, EventArgs e)
        {
            mycourses c = new mycourses(email_txt.Text);
            c.Show();
            this.Close();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
