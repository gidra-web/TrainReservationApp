using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace TrainReservationApp
{
    public partial class TrainPassenger : Form
    {
        public TrainPassenger()
        {
            InitializeComponent();
            selectPassengers();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dragan\Documents\TrainDb.mdf;Integrated Security=True;Connect Timeout=30");

        public void selectPassengers()
        {
            conn.Open();
            string query = "SELECT * FROM PassengerTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_passenger.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void reset()
        {
            tb_name.Text = "";
            tb_address.Text = "";
            rbtn_male.Checked = false;
            rbtm_female.Checked = false;
            tb_phone.Text = "";
            key = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_address.Text == "" || tb_phone.Text == "")
            {
                MessageBox.Show("Fill up entire fileds");
            }
            else
            {
                string rbitGender = "";
                if (rbtn_male.Checked == true) rbitGender = "Male";
                else if (rbtm_female.Checked == true) rbitGender = "Female";
                try
                {
                    conn.Open();
                    string querry = "INSERT INTO PassengerTb values('" + tb_name.Text + "','" + tb_address.Text + "','" + rbitGender + "','" + tb_phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully");
                    conn.Close();
                    selectPassengers();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int key = 0;
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (key == 0)
                MessageBox.Show("Select the passenger to be deleted");
            else
            {
                try
                {
                    conn.Open();
                    string querry = "DELETE FROM PassengerTb WHERE PId=" + key + "";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    conn.Close();
                    selectPassengers();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_address.Text == "" || tb_phone.Text == "")
            {
                MessageBox.Show("Fill up entire fileds");
            }
            else
            {
                string rbitGender = "";
                if (rbtn_male.Checked == true) rbitGender = "Male";
                else if (rbtm_female.Checked == true) rbitGender = "Female";
                try
                {
                    conn.Open();
                    string querry = "UPDATE PassengerTb SET PName='" + tb_name.Text + "', PAddress='" + tb_address.Text + "', PGender='" + rbitGender + "', PPhone='" + tb_phone.Text + "' WHERE PId=" + key + "";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                    conn.Close();
                    selectPassengers();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgv_passenger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_name.Text = dgv_passenger.SelectedRows[0].Cells[1].Value.ToString();
            tb_address.Text = dgv_passenger.SelectedRows[0].Cells[2].Value.ToString();
            tb_phone.Text = dgv_passenger.SelectedRows[0].Cells[4].Value.ToString();
            if (tb_name.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgv_passenger.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
