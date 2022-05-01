using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class ReservationInfo : Form
    {
        public ReservationInfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");

        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void fillRoomcombo()
        {
            string roomstate = "free";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select RoomId from Room_tbl where RoomFree='"+roomstate+"' ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);
            roomcb.ValueMember = "RoomId";
            roomcb.DataSource = dt;
            Con.Close();

        }

        public void fillClientcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from Client_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);
            Clientcb.ValueMember = "ClientName";
            Clientcb.DataSource = dt;
            Con.Close();

        }



        DateTime today;
        private void ReservationInfo_Load(object sender, EventArgs e)
        {
            today = datein.Value;
            fillRoomcombo();
            fillClientcombo();
            populate();
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString()+"-"+DateTime.Today.Year.ToString();

        }

        private void datein_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(datein.Value, today);
            if (res < 0)
                MessageBox.Show("Wrong Date For Reservation");
        }

        private void dateout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateout.Value, datein.Value);
            if (res < 0)
                MessageBox.Show("Wrong DateOut. Check once more");

        }
        public void updateroomstate()
        {
            Con.Open();
            string newstate = "busy";

            string myquery = "UPDATE Room_tbl SET RoomFree = '" + newstate + "' where RoomId=" + Convert.ToInt32(roomcb.SelectedValue.ToString()) + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            
            Con.Close();
            fillRoomcombo();

        }

        public void updateroomondelete()
        {
            Con.Open();
            string newstate = "free";
            int roomid = Convert.ToInt32(ReservationGridView.SelectedRows[0].Cells[2].Value.ToString());


            string myquery = "UPDATE Room_tbl SET RoomFree = '" + newstate + "' where RoomId=" + roomid + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();

            Con.Close();
            fillRoomcombo();

        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values(" + ReserIdtb.Text + ",'" + Clientcb.SelectedValue.ToString() + "','" + roomcb.SelectedValue.ToString() + "','" + datein.Value + "','" + dateout.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Successfully Added");
            Con.Close();
            updateroomstate();
            populate();

        }

        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReserIdtb.Text = ReservationGridView.SelectedRows[0].Cells[0].Value.ToString();


        }

        private void RoomDeleteBtn_Click(object sender, EventArgs e)
        {
            if (ReserIdtb.Text == "")
            {
                MessageBox.Show("Enter the Reservation to be deleted");
            }
            else
            {
                Con.Open();
                string query = "delete from Reservation_tbl where ResId=" + ReserIdtb.Text + " ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully Deleted");
                Con.Close();
                updateroomondelete();
                populate();
            }

        }

        private void RoomEditBtn_Click(object sender, EventArgs e)
        {
            if (ReserIdtb.Text=="")
            {
                MessageBox.Show("Empty ResId, Enther the Reservation Id");
            }
            else
            {
                Con.Open();
                string myquery = "UPDATE Reservation_tbl set Client = '" + Clientcb.SelectedValue.ToString() + "', Room='" + roomcb.SelectedValue.ToString() + "', DateIn='" + datein.Value.ToString() + "', DateOut='" + dateout.Value.ToString() + "' where ResId=" + ReserIdtb.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Successfully Edited");
                Con.Close();
                populate();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl where ResId='" + ReservationSearchtb.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridView.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MainForm mform = new MainForm();
            mform.Show();
            this.Hide();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
