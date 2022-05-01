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
    public partial class StaffInfo : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");

        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        public StaffInfo()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_tbl values(" + staffidtbl.Text + ",'" + staffnametbl.Text + "','" + staffphonetbl.Text + "','" + staffgendercb.SelectedItem.ToString() + "','"+passwordtb.Text+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Added");
            Con.Close();
            populate();
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            populate();
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

        }

        private void StaffEditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Staff_tbl set Staffname = '" + staffnametbl.Text + "', staffphone='" + staffphonetbl.Text + "', gender='"+staffgendercb.SelectedItem.ToString()+"', Staffpassword='"+passwordtb.Text+"' where StaffId=" + staffidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Edited");
            Con.Close();
            populate();
        }

        private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            staffidtbl.Text = StaffGridView.SelectedRows[0].Cells[0].Value.ToString();
            staffnametbl.Text = StaffGridView.SelectedRows[0].Cells[1].Value.ToString();
            staffphonetbl.Text = StaffGridView.SelectedRows[0].Cells[2].Value.ToString();
            passwordtb.Text = StaffGridView.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Staff_tbl where StaffId=" + staffidtbl.Text + " ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Deleted");
            Con.Close();
            populate();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Staff_tbl where StaffName='" + StaffSearchtb.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];
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
    }
}
