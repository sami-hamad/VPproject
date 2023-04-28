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


namespace VPproject
{
    public partial class login : Form
    {
        
        private SQLiteConnection conn;
        public login()
        {
            conn = new SQLiteConnection("Data Source=C:\\Users\\samim\\source\\repos\\VPproject\\VPproject\\bin\\Debug\\customer.db; Version=3;");
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {//login button

            try
            {
                conn.Open();


                string email = email_txt.Text.ToUpper(); ;
                string password = pass_txt.Text;
                
                //retrieve password from database by email       VVVVV
                string sql = $"SELECT password FROM client where email='{email}'";

                SQLiteCommand command = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.HasRows)//if email exists in db then the reader must have rows
                {
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == password)// if password in db matches entered password
                        {
                            //redirect to client page
                            client cl = new client(email);
                            cl.Show();
                            this.Close();
                        }
                        else
                        {
                            //if password in db don't match entered password
                            invinfo_lbl.Show();
                            invinfo_pic.Show();
                        }
                    }
                    reader.Close();
                }
                else
                {
                    //if entered email is not found in db
                    invinfo_lbl.Show();
                    invinfo_pic.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //create an account link label (sign up)
            Form form = new create();
            form.Show();
            this.Hide();
        }
    }
    
}
