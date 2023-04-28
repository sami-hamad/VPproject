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
    
    public partial class payment : Form
    {
        private SQLiteConnection conn;
        //db path
        string dbp = "C:\\Users\\samim\\source\\repos\\VPproject\\VPproject\\bin\\Debug\\customer.db";
        //to trace the primary key of the customer
        public string email = "";


        public string course = "";
        public string inst = "";
        public string start = "";
        public string end = "";
        int hours = 0;
        string level = "";
        string req = "";
        
        //to be viewed in the course total, level total, net total
        int ctotal = 0;
        int ltotal = 0;
        int total = 0;

        //all course information that is chosen by user is sent to constructor of this page to be traced and registered in db after payment
        public payment(string e, string c, string i, string s, int h, string l, string r, int ct,int lt,int t)
        {
            InitializeComponent();
            conn = new SQLiteConnection($"Data Source={dbp}; Version=3;");
            email = e;
            course = c;
            inst = i;
            start = s;
            hours = h;
            level = l;
            req = r;
            ctotal = ct;
            ltotal = lt;
            total = t;

        }

        private void payment_Load(object sender, EventArgs e)
        {
            //the course total, level total, net total appears when page loads
            ctotal_txt.Text = ctotal.ToString();
            lvl_txt.Text=ltotal.ToString();
            total_txt.Text=total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {//back button is pressed

            book book = new book(email);
            book.Show();
            this.Close();
        }

        private void ccv_TextChanged(object sender, EventArgs e)
        {
            //when cvv text is changed the below func is called
            validatecvv();
        }
        bool validatecvv()
        {

            string c = cvv.Text;
            bool valid = true;

            if (c == "")// if cvv is null
            {
                invcvv_lbl.Text = "Please Enter a CVV";
                valid = false;
            }

            foreach(char i in c)
            {
                if (i < '0' || i > '9')//if a character of cvv is not a number
                {
                    invcvv_lbl.Text = "Invalid CVV number Form";
                    valid=false;
                    break;
                }
            }

            if (!valid)
            {
                invcvv_lbl.Show();
                invcvv_pic.Show();
                return false;
            }
            else
            {
                invcvv_lbl.Hide();
                invcvv_pic.Hide();
                return true;
            }

        }
        bool validateccn()
        {
            string c = ccn.Text;

            bool valid = true;
            if (c == "")//if a cardnumber is not entered
            {
                invccn_lbl.Text = "Please Enter a CCNumber";
                valid = false;
            }

            foreach (char i in c)
            {
                if (i < '0' || i > '9')//if a character of cardnumber is not a number
                {
                    invccn_lbl.Text = "Invalid CCNumber Form";
                    valid = false;
                    break;
                }
            }

            if (!valid)
            {
                invccn_lbl.Show();
                invccn_pic.Show();
                return false;
            }
            else
            {
                invccn_lbl.Hide();
                invccn_pic.Hide();
                return true;
            }
        }

        private void ccn_TextChanged(object sender, EventArgs e)
        {//when text is changed in card number below function is called.
            validateccn();
        }
        bool validatechname()
        {
            string c = chname.Text;

            bool valid = true;
            if (c == "")// if name is empty
            {
                invname_lbl.Text = "Please Enter a Name";
                valid = false;
            }
            
            foreach (char i in c)
            {
                if ((i >= 'a' && i <= 'z') || (i >= 'A' && i <= 'Z') || (i==' '))//if a non alphabet is entered
                {
                }
                else
                {
                    invccn_lbl.Text = "Invalid CCNumber Form";
                    valid = false;
                    break;
                }
            }

            if (!valid)
            {
                invname_lbl.Show();
                invname_pic.Show();
                return false;
            }
            else
            {
                invname_lbl.Hide();
                invname_pic.Hide();
                return true;
            }
        }

        private void chname_TextChanged(object sender, EventArgs e)
        {
            //when the holder name is changed below function is called 
            validatechname();
        }
        bool validateall()
        {
            bool valid1 = validatechname();
            bool valid2 = validatecvv();
            bool valid3 = validateccn();
            if(valid1&&valid2&&valid3)
                return true;
            else return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {//when book my course! button is clicked

            if (validateall())//function to validate all boxes
            {
                try
                {
                    conn.Open();
                    //useremail + course information is entered into course table
                    string sql = $"INSERT INTO course values('{email}','{course}','{inst}','{start}',{hours},'{level}','{req}',{total});";
                    
                    SQLiteCommand command = new SQLiteCommand(sql, conn);
                    command.ExecuteNonQuery();
                    
                    MessageBox.Show("Course Booked Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    //redirect to mycourses page
                    mycourses mycourses = new mycourses(email);
                    mycourses.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    //if course is already booked (primary key is unique)
                    MessageBox.Show("Course Already Booked!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    book form = new book(email);
                    form.Show();
                    this.Close();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }
    }
}
