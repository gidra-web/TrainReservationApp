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
    public partial class TravelMaster : Form
    {
        public TravelMaster()
        {
            InitializeComponent();
            selectTravels();
            fillTrainCode();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dragan\Documents\TrainDb.mdf;Integrated Security=True;Connect Timeout=30");
        public void selectTravels()
        {
            conn.Open();
            string query = "SELECT * FROM TravelTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_travel.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void reset()
        {
            tb_travelCoast.Text = "";
            cb_trainCode.SelectedIndex = -1;
            cb_source.SelectedIndex = -1;
            cb_destination.SelectedIndex = -1;
            key = 0;
        }

        public void fillTrainCode()
        {
            string rbitStatus = "Available";
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TrainId FROM TrainTb WHERE TrainStatus='"+ rbitStatus + "'", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt=new DataTable();
            dt.Columns.Add("TrainId", typeof(int));
            dt.Load(rdr);
            cb_trainCode.ValueMember= "TrainId";
            cb_trainCode.DataSource = dt;
            conn.Close();
        }
        public void ChangeStatus()
        {
            string rbitStatus = "Busy";
            try
            {
                conn.Open();
                string querry = "UPDATE TrainTb SET TrainStatus='" + rbitStatus + "' WHERE TrainId=" + cb_trainCode.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_travelCoast.Text == "" || cb_trainCode.SelectedIndex == -1 || cb_source.SelectedIndex == -1 || cb_destination.SelectedIndex == -1)
            {
                MessageBox.Show("Fill up entire fileds");
            }
            else
            {
                try
                {
                    conn.Open();
                    string querry = "INSERT INTO TravelTb values('" + dateTimeTravel.Value + "','" + cb_trainCode.SelectedValue.ToString() + "','" + cb_source.SelectedItem.ToString() + "','" + cb_destination.SelectedItem.ToString() + "','" + tb_travelCoast.Text + "')";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully");
                    conn.Close();
                    selectTravels();
                    ChangeStatus();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tb_travelCoast.Text == "" || cb_trainCode.SelectedIndex == -1 || cb_source.SelectedIndex == -1 || cb_destination.SelectedIndex == -1)
            {
                MessageBox.Show("Fill up entire fileds");
            }
            else
            {
                try
                {
                    conn.Open();
                    string querry = "UPDATE TravelTb SET TrainId='" + cb_trainCode.SelectedValue.ToString() + "', TrainDate='" + dateTimeTravel.Value + "', Source='" + cb_source.SelectedItem.ToString() + "', Destination='" + cb_destination.SelectedItem.ToString() + "', Cost='" + tb_travelCoast.Text + "' WHERE TrainCode=" + key + ";";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                    conn.Close();
                    ChangeStatus();
                    selectTravels();  
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void dgv_travel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimeTravel.Text = dgv_travel.SelectedRows[0].Cells[1].Value.ToString();
            cb_trainCode.Text = dgv_travel.SelectedRows[0].Cells[2].Value.ToString();
            cb_source.Text = dgv_travel.SelectedRows[0].Cells[3].Value.ToString();
            cb_destination.Text = dgv_travel.SelectedRows[0].Cells[4].Value.ToString();
            tb_travelCoast.Text = dgv_travel.SelectedRows[0].Cells[5].Value.ToString();
            if (cb_trainCode.SelectedIndex == -1)
            {
                key = 0;
                tb_travelCoast.Text = "";
                cb_trainCode.SelectedIndex = -1;
                cb_source.SelectedIndex = -1;
                cb_destination.SelectedIndex = -1;
            }
            else
            {
                key = Convert.ToInt32(dgv_travel.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
