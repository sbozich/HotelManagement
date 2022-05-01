﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagement
{
    public partial class ClientInfo : Form
    {
        //SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-N5IF2SJ\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");
        SqlConnection Con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery,Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            //Datelbl.Text = DateTime.Now.ToLongTimeString();
            //timer1.Start();
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values("+clientidtbl.Text+",'"+clientnametbl.Text+"','"+clientphonetbl.Text+"','"+clientctrycb.SelectedItem.ToString()+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();
            populate();
        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


                clientidtbl.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
                clientnametbl.Text = ClientGridView.SelectedRows[0].Cells[1].Value.ToString();
                clientphonetbl.Text = ClientGridView.SelectedRows[0].Cells[2].Value.ToString();
           
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query="delete from Client_tbl where Clientid="+clientidtbl.Text+" ";
            SqlCommand cmd = new SqlCommand(query,Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Deleted");
            Con.Close();
            populate();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery="UPDATE Client_tbl set ClientName = '"+clientnametbl.Text+"', ClientPhone='"+clientphonetbl.Text+"', ClientCountry='"+clientctrycb.SelectedItem.ToString()+"' where ClientId="+clientidtbl.Text+";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Edited");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Client_tbl where ClientName='"+ClientSearchtb.Text+"' ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MainForm mform = new MainForm();
            mform.Show();
            this.Hide();

        }
    }
}
