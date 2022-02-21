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
    public partial class Add_Vehical : Form
    {
        string vehid = "";
        public Add_Vehical()
        {
            InitializeComponent();
        }
        DataSet Dset = new DataSet();
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TTVI20JH\SQLEXPRESS;Initial Catalog=LesiDriveLT;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home ho = new Home();
            this.Hide();
            ho.Show();
        }

        private void comboVe_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butadd_Click(object sender, EventArgs e)
        {
            string vehiclereg = "";

            vehiclereg = comboregno.SelectedItem.ToString() + "-" + txtregno.Text;
            if (comboVe_pur.Text.Length < 1 || comboVe_Type.Text.Length < 1 || comboregno.Text.Length < 1 || txtregno.Text.Length < 1)
            {
                MessageBox.Show("Please Fill All Text Fields", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    //Data Uploading
                    con.Open();
                    string ADD = "INSERT INTO VehicleInfo Values ('" + comboVe_pur.SelectedItem.ToString() + "','" + comboVe_Type.SelectedItem.ToString() + "','" + vehiclereg + "')";
                    com = new SqlCommand(ADD, con);
                    com.ExecuteNonQuery();

                    //-------------------------------------------------------------------------------------------------
                    MessageBox.Show("Vehicle Registration Successfull!", "Registration Successfull !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error While Adding." + ex.Message);
                }
                finally
                {
                    con.Close();
                    loadtable();
                    comboVe_pur.Text = "";
                    comboVe_Type.Text = "";
                    comboregno.Text = "";
                    txtregno.Clear();

                }
            }
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            string vehiclereg = "";
            vehiclereg = comboregno.SelectedItem.ToString() + "-" + txtregno.Text;
       
            if (comboVe_pur.Text.Length < 1 || comboVe_Type.Text.Length < 1 || comboregno.Text.Length < 1 || txtregno.Text.Length < 1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Update Details ?", "Update Details ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                try
                {
                    con.Open();
                    string update = "UPDATE VehicleInfo SET VehiclePurpose='" + comboVe_pur.SelectedItem.ToString() + "' , VehicleType='" + comboVe_Type.SelectedItem.ToString() + "', VehicleRegNo='" + vehiclereg + "' WHERE VehicleID='" + vehid + "'";
                    com = new SqlCommand(update, con);
                    com.ExecuteNonQuery();
                   

                    MessageBox.Show("Record Updated Successfully", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error While Adding." + ex.Message);
                }

                finally
                {
                    con.Close();
                    loadtable();
                    comboVe_pur.Text = "";
                    comboVe_Type.Text = "";
                    comboregno.Text = "";
                    txtregno.Clear();

                }
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Are you sure you want to delete Vehicle ?", "Delete Vehicle?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string delete = "DELETE from VehicleInfo WHERE VehicleID='" + vehid + "'";
                    com = new SqlCommand(delete, con);
                    com.ExecuteNonQuery();
                    con.Close();

                

                    MessageBox.Show("Record Deleted Successfully", "Deleted !", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error While Adding." + ex.Message);
                }

                finally
                {
                    con.Close();
                    loadtable();
                    comboVe_pur.Text = "";
                    comboVe_Type.Text = "";
                    comboregno.Text = "";
                    txtregno.Clear();

                }
            }
        }
        private void loadtable()
        {
            try
            {
                con.Open();
                Dset.Reset();
                string vehicles = "Select VehicleID,VehiclePurpose,VehicleType,VehicleRegNo From VehicleInfo";
                SqlDa = new SqlDataAdapter(vehicles, con);
                SqlDa.Fill(Dset, "VehicleInfo");
                SqlDa.Fill(Dset);
                con.Close();
                dataGridView_Veh.DataSource = Dset.Tables["VehicleInfo"];
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error While Adding." + ex.Message);
            }
        }

        private void butclear_Click(object sender, EventArgs e)
        {
            comboVe_pur.Text = "";
            comboVe_Type.Text = "";
            comboregno.Text = "";
            txtregno.Clear();
        }

        private void dataGridView_Veh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


           butadd.Enabled= true;
           butdelete.Enabled= true;
           butclear.Enabled = true;
           txtregno.Visible = true;



           DataGridViewRow row = this.dataGridView_Veh.Rows[e.RowIndex];
           // txtregno.Text = row.Cells["VehicleRegNo"].Value.ToString();
            comboVe_Type.Text = row.Cells["VehicleType"].Value.ToString();
            comboVe_pur.Text = row.Cells["VehiclePurpose"].Value.ToString();
            vehid = row.Cells["VehicleID"].Value.ToString();

        }

        private void Add_Vehical_Load(object sender, EventArgs e)
        {
            loadtable();
          
        }
    }
}
