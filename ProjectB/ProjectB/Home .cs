using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStudent m = new ManageStudent();
            this.Hide();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageClo m = new ManageClo();
            this.Hide();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageRubric r = new ManageRubric();
            this.Hide();
            r.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageAssessment m = new ManageAssessment();
            this.Hide();
            m.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RubricLevel r = new RubricLevel();
            this.Hide();
            r.Show();
        }
    }
}

