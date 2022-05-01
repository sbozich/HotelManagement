using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagement
{
    public partial class RoomInfo : Form
    {
        public RoomInfo()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");

        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Yesradio.Checked == true)
                isfree = "free";
            else
                isfree = "busy";
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Room_tbl values(" + Roomnumtb.Text + ", " + Roomphonetb.Text + ",'" + isfree + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Added");
            Con.Close();
            populate();

        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

            populate();
        }

        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Roomnumtb.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
            Roomphonetb.Text = RoomGridView.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void RoomDeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Room_tbl where RoomId=" + Roomnumtb.Text + " ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Deleted");
            Con.Close();
            populate();

        }

        private void RoomEditBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Yesradio.Checked == true)
                isfree = "free";
            else
                isfree = "busy";

            Con.Open();
            string myquery = "UPDATE Room_tbl set RoomPhone = '" + Roomphonetb.Text + "', RoomFree='" + isfree + "' where RoomId=" + Roomnumtb.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Edited");
            Con.Close();
            populate();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Room_tbl where RoomId='" + RoomSearchtb.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
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
