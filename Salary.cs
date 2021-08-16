using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace main_project_3rd_sem
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aayus\Documents\MyEmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
        private void fetchempdata()
        {
            if(EmpIdTb.Text=="")
            {
                MessageBox.Show("Enter Employee ID");
            }else
            {
                Con.Open();
                string query = "select * from EmployeeTbl where EmpId='" + EmpIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    //EmpIdTb.Text = dr["Empid"].ToString();
                    EmpNameTb.Text = dr["Empname"].ToString();

                    EmpPosTb.Text = dr["Emppos"].ToString();





                }
                Con.Close();
            }
            
        }
        private void Salary_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
        int Dailybase, total;
        private void button2_Click(object sender, EventArgs e)
        {
           if(EmpPosTb.Text=="")
            {
                MessageBox.Show("Select An Employee");

            }
           else if(WorkedTb.Text==""|| Convert.ToInt32(WorkedTb.Text)>28)
            {
                MessageBox.Show("Select a valid number of days");
            }
            else
            {
                if(EmpPosTb.Text=="Manager")
                {
                    Dailybase = 2500;
                }else if(EmpPosTb.Text=="Senior Developer")
                {
                    Dailybase = 2300;
                }else if(EmpPosTb.Text=="Junior Developer")
                {
                    Dailybase = 2000;
                }else
                {
                    Dailybase = 1500;
                }
                total = Dailybase * Convert.ToInt32(WorkedTb.Text);
                SalarySlip.Text ="ID: "+ EmpIdTb.Text + "\n" + "Name: "+EmpNameTb.Text + "\n" +"Position: "+ EmpPosTb.Text + "\n" +"Days worked: "+ WorkedTb.Text + "\n"  + "Rs. "+total;

            }
        }
    }
}
