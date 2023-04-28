using System.Data;
using System.Data.SQLite;

namespace VPproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            create newForm = new create();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form newForm = new create();
            
            newForm.Show();
            
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            about newForm = new about();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            privacy newForm = new privacy();
            newForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            help newForm = new help();
            newForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form newForm = new login();
            newForm.Show();
            this.Hide();
        }
    }
}