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

namespace LesiDriveLT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TTVI20JH\SQLEXPRESS;Initial Catalog=LesiDriveLT;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From [Account_Details] where UserName='" + TXTuser.Text + "' and UserPassword='" + USERpass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Home GRS = new Home();
                this.Hide();
                GRS.Show();
                


            }
            else
            {
                MessageBox.Show("Invalid User Name Or Password.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                USERpass.Clear();
                TXTuser.Clear();
                TXTuser.Focus();
                this.Show();
            }
        }

        private void TXTuser_Leave(object sender, EventArgs e)
        {
            if (TXTuser.Text == "")
            {
                TXTuser.Text = "Username";
            }
        }

        private void TXTuser_Enter(object sender, EventArgs e)
        {
             TXTuser.Text = "";
        }

        private void USERpass_Enter(object sender, EventArgs e)
        {
            USERpass.Text = "";
        }

        private void USERpass_Leave(object sender, EventArgs e)
        {
            if (USERpass.Text == "")
            {
                USERpass.Text = "Password";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
