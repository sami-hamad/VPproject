using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPproject
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // redirect to home page
            Form1 b = new Form1();
            b.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //redirect to privacy page
            privacy b = new privacy();
            b.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //redirect to help page
            help b = new help();
            b.Show();
            this.Close();
        }
    }
}
