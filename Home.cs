﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ViewEmployee Vemp = new ViewEmployee();
            Vemp.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ViewEmployee Vemp = new ViewEmployee();
            Vemp.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
