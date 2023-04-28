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

    
    public partial class mycourses : Form
    {
        private SQLiteConnection conn;
        
        string email = "";
        

        //email is sent to constructer to trace the user
        public mycourses(string e)
        {
            conn = new SQLiteConnection("Data Source=C:\\Users\\samim\\source\\repos\\VPproject\\VPproject\\bin\\Debug\\customer.db; Version=3;");
            InitializeComponent();
            email = e;
        }

        private void myacc_btn_Click(object sender, EventArgs e)
        {
            //redirect to manage account page
            client client = new client(email);
            client.Show();
            this.Close();
        }

        private void bookc_btn_Click(object sender, EventArgs e)
        {
            //redirect to book a course page
            book book = new book(email);
            book.Show();
            this.Close();
        }

        private void mycourses_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //retrieve rows from db and give them aliases(header names)
                string sql = $"select course_name AS 'Course Name', instructor AS Instructor, start_date AS Date, hours as Hours, level as Level, req as Comments, total as Total from course where cl_email='{email}'";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)//if theres data retrieved
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                    DataSet set = new DataSet();
                    
                    //filling adapter from table course
                    adapter.Fill(set, "Course");
                    //setting the data source from dataset course
                    courses_data.DataSource = set.Tables["course"]!.DefaultView;
                }
                else//if no data retrieved
                {
                    courses_data.DataSource = null;
                    courses_data.Hide();
                    nodata_lbl.Show();
                    bnow_llbl.Show();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {//logout button clicked

            //redirect to login page
            login login = new login();
            login.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //redirect to book a course page
            book book = new book(email);
            book.Show();
            this.Close();
        }

        private void courses_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
