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

namespace VPproject
{
    public partial class book : Form
    {
        public static string email;
        public book(string e)
        {
            email = e;
            InitializeComponent();
        }

        private void myacc_btn_Click(object sender, EventArgs e)
        {
            //redirect to manage account page, and email is passed there to keep track of his info
            client c = new client(email);
            c.Show();
            this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            //if logout button is clicked
            login login = new login();
            login.Show();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void course_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  (Choose a course)
                Spanish Course
                Chinese Course
                Japanese Course
                Hindi Course
                English Course
                Arabic Course
                Russian Course
            */
            int price = 0;
            string source = "";
            string path = "C:\\Users\\samim\\source\\repos\\VPproject\\VPproject\\bin\\Debug\\";

            //if a course is selected
            switch (course_box.SelectedIndex)
            {
                 
                //the value of path and text file is stored in the source page, based on the selected index in the course list
                case 1:
                    source = path + "spanish.txt";
                    price = 100;//price for the course
                    break;
                case 2:
                    source = path + "chinese.txt";
                    price = 70;//price for the course
                    break;
                case 3:
                    source = path + "japanese.txt";
                    price = 40;//price for the course
                    break;
                case 4:
                    source = path + "hindi.txt";
                    price = 20;//price for the course
                    break;
                case 5:
                    source = path + "english.txt";
                    price = 100;//price for the course
                    break;
                case 6:
                    source = path + "arabic.txt";
                    price = 200;//price for the course
                    break;
                case 7:
                    source = path + "russian.txt";
                    price = 30;//price for the course
                    break;
            }
            
            //instructor list will  be cleared
            ins_box.Items.Clear();

            //if no course is selected
            if (source == "")
            {
                invcourse_lbl.Show();
                invcourse_pic.Show();
            }
            else//if a course is selected
            {
                invcourse_lbl.Hide();
                invcourse_pic.Hide();
                StreamReader sr = new StreamReader(source);
                    
                
                //instructors names will be added to instructor list
                while (!sr.EndOfStream)
                {
                    ins_box.Items.Add(sr.ReadLine());
                }

                sr.Close();

                ctotal_txt.Text = price.ToString();// course total will appear in the text box

                if (level_chosen())//if level is chosen the net total is calculated, otherwise nettotal will not appear
                {
                    total_txt.Text = (hours_numeric.Value * (price + int.Parse(lvl_txt.Text.ToString()))).ToString();
                }
            }

        }
        int priceoflvl()
        {
            //function to return the price of the selected level
            RadioButton[] levels = { A1, A2, B1, B2, C1, C2 };
            int[] prices = { 10, 20, 30, 40, 50, 60 };
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i].Checked)
                    return prices[i];
            }
            return 0;
        }
        bool level_chosen()
        {
            //function that checks if a level is chosen or not
            RadioButton[] levels = { A1, A2, B1, B2, C1, C2 };
            foreach (RadioButton level in levels) {
                if (level.Checked)
                    return true;
            }
            return false;
        }
        string level_chosen_name()
        {
            //function that returns the selected level name
            RadioButton[] levels = { A1, A2, B1, B2, C1, C2 };
            foreach (RadioButton level in levels)
            {
                if (level.Checked)
                    return level.Text;
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool go = true;
            //if course is not selected
            if (course_box.SelectedIndex == -1 || course_box.SelectedIndex == 0)
            {
                go = false;
                invcourse_lbl.Show();
                invcourse_pic.Show();
            }

            //if instructor is not selected
            if (ins_box.SelectedIndex == -1 )
            {
                go=false;
                invins_lbl.Show();
                invins_pic.Show();
            }

            //if instructor and course and level is selected
            if (go && total_txt.Text != "")
            {
                string c =course_box.Text;
                string i =ins_box.Text;
                string s =d_pick.Text;
                int h = (int)hours_numeric.Value;
                string l=level_chosen_name();
                string r = req_txt.Text;
                int ct= int.Parse(ctotal_txt.Text);
                int lt= int.Parse(lvl_txt.Text);
                int t = int.Parse(total_txt.Text);

                //to keep track of the user choices, and to get recorded in db after payment
                //, all info is passed to payment page
                payment p = new payment(email,c, i, s, h, l, r, ct,lt,t);
                p.Show();
                this.Hide();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //if a level is chosen
            if (level_chosen())
            {
                int price = priceoflvl();
                if (price > 0)
                {
                    lvl_txt.Text = price.ToString();
                    if(ctotal_txt.Text != null)//if course is also chosen, net total will appear.
                        total_txt.Text = (hours_numeric.Value * (price + int.Parse(ctotal_txt.Text))).ToString();
                }
            }
        }

        private void hours_numeric_ValueChanged(object sender, EventArgs e)
        {// when hours are increased
            if(total_txt.Text != "")
            {
                int ctotal = int.Parse(ctotal_txt.Text);
                int lvltotal= int.Parse(lvl_txt.Text);
                int sum = ctotal + lvltotal;
                total_txt.Text  = (hours_numeric.Value * sum).ToString();
            }
        }

        private void ins_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if no instructor is chosen
            if(ins_box.SelectedIndex != -1)
            {
                invins_lbl.Hide();
                invins_pic.Hide();
            }
        }

        private void book_Load(object sender, EventArgs e)
        {

        }

        private void mycourses_btn_Click(object sender, EventArgs e)
        {
            //my courses page, and email is sent to keep track of users courses
            mycourses m = new mycourses(email);
            m.Show();
            this.Close();
        }
    }
}
