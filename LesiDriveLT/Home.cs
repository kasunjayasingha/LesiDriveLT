using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesiDriveLT
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void butView_Click(object sender, EventArgs e)
        {
            View_Hire vi = new View_Hire();
            this.Hide();
            vi.Show();

        }

        private void butRent_Click(object sender, EventArgs e)
        {
            Rent re = new Rent();
            this.Hide();
            re.Show();
        }

        private void butADDVeh_Click(object sender, EventArgs e)
        {
            Add_Vehical add = new Add_Vehical();
            this.Hide();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vehicle_Charge cha = new Vehicle_Charge();
            this.Hide();
            cha.Show();
           
        }

        private void butHire_Click(object sender, EventArgs e)
        {
            User_Set set = new User_Set();
            this.Hide();
            set.Show();
        }
    }
}
