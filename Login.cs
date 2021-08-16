using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_project_3rd_sem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UidTb.Text==""|| PassTb.Text=="")
            {
                MessageBox.Show("Enter Correct ID and Password");
            }
            else if(UidTb.Text=="Admin"&& PassTb.Text=="admin")

            {
                this.Hide();
                Home home = new Home();
                home.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
