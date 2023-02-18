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
using System.Data.Sql;

namespace TrainReservationApp
{
    public partial class TrainMaster : Form
    {
        public TrainMaster()
        {
            InitializeComponent();
            selectTrains();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dragan\Documents\TrainDb.mdf;Integrated Security=True;Connect Timeout=30");

        public void selectTrains()
        {
            conn.Open();
            string query = "SELECT * FROM TrainTb";
            SqlDataAdapter sda=new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_train.DataSource= ds.Tables[0];
            conn.Close();
        }
        public void reset()
        {
            tb_trainName.Text = "";
            tb_capacity.Text = "";
            rbtn_available.Checked = false;
            rbtn_bussy.Checked = false;
            key = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_trainName.Text == "" || tb_capacity.Text == "")
            {
                MessageBox.Show("Fill up entire fileds");
            }
            else
            {
                string rbitStatus = "";
                if (rbtn_available.Checked == true) rbitStatus = "Available";
                else if (rbtn_bussy.Checked == true) rbitStatus = "Busy";
                try
                {
                    conn.Open();
                    string querry = "INSERT INTO TrainTb values('" + tb_trainName.Text + "','" + tb_capacity.Text + "','" + rbitStatus + "')";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully");
                    conn.Close();
                    selectTrains();
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

        private void dgv_train_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_trainName.Text = dgv_train.SelectedRows[0].Cells[1].Value.ToString();
            tb_capacity.Text = dgv_train.SelectedRows[0].Cells[2].Value.ToString();
            if (tb_trainName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgv_train.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        int key = 0;
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (key == 0)
                MessageBox.Show("Select the train to be deleted");
            else
            {
                try
                {
                    conn.Open();
                    string querry = "DELETE FROM TrainTb WHERE TrainId="+key+"";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    conn.Close();
                    selectTrains();
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
            if (tb_trainName.Text == "" || tb_capacity.Text == "")
            {
                MessageBox.Show("Fill up entire fileds");
            }
            else
            {
                string rbitStatus = "";
                if (rbtn_available.Checked == true) rbitStatus = "Available";
                else if (rbtn_bussy.Checked == true) rbitStatus = "Busy";
                try
                {
                    conn.Open();
                    string querry = "UPDATE TrainTb SET TrainName='" + tb_trainName.Text + "', TrainCapacity='" + tb_capacity.Text + "', TrainStatus='" + rbitStatus + "' WHERE TrainId="+key+"";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                    conn.Close();
                    selectTrains();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
