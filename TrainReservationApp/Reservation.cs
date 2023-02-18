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

namespace TrainReservationApp
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            selectReservations();
            fillPid();
            fillTravelCode();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dragan\Documents\TrainDb.mdf;Integrated Security=True;Connect Timeout=30");
        public void selectReservations()
        {
            conn.Open();
            string query = "SELECT * FROM ReservationTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_reservation.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void reset()
        {
            cb_passingerid.SelectedIndex = -1;
            cb_travelId.SelectedIndex = -1;
            //key = 0;
        }

        public void fillPid()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT PId FROM PassengerTb", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PId", typeof(int));
            dt.Load(rdr);
            cb_passingerid.ValueMember = "PId";
            cb_passingerid.DataSource = dt;
            conn.Close();
        }
        public void fillTravelCode()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TrainCode FROM TravelTb", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainCode", typeof(int));
            dt.Load(rdr);
            cb_travelId.ValueMember = "TrainCode";
            cb_travelId.DataSource = dt;
            conn.Close();
        }
        string pName;
        private void getPName()
        {   
            conn.Open();
            string query = "SELECT * FROM PassengerTb where Pid=" + cb_passingerid.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                pName = dr["PName"].ToString();
            }
            conn.Close();
            //MessageBox.Show(pName);
        }
        string date,src,dest;
        double cost;

        private void getTravelCode()
        {
            conn.Open();
            string query = "SELECT * FROM TravelTb where TrainCode=" + cb_travelId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                date = dr["TrainDate"].ToString();
                src = dr["Source"].ToString();
                dest = dr["Destination"].ToString();
                cost = Convert.ToDouble(dr["Cost"].ToString());
            }
            conn.Close();
            //MessageBox.Show(date + " "+ src + " " + dest + " " + cost);
        }

        private void cb_passingerid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getPName();
        }
        private void cb_travelId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getTravelCode();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cb_passingerid.SelectedIndex == -1 || cb_travelId.SelectedIndex == -1)
            {
                MessageBox.Show("Fill up entire fileds");
            }
            else
            {
                try
                {
                    conn.Open();
                    string querry = "INSERT INTO ReservationTb values('" + cb_passingerid.SelectedValue.ToString() + "','" + pName + "','" + cb_travelId.SelectedValue.ToString() + "','" + date + "','" + src + "','" + dest + "','" + cost + "')";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation Accepted");
                    conn.Close();
                    selectReservations();
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
