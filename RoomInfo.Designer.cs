
namespace HotelManagement
{
    partial class RoomInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Roomphonetb = new System.Windows.Forms.TextBox();
            this.Roomnumtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Yesradio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Noradio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomDeleteBtn = new System.Windows.Forms.Button();
            this.RoomEditBtn = new System.Windows.Forms.Button();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.RoomSearchtb = new System.Windows.Forms.TextBox();
            this.RoomGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 125);
            this.panel1.TabIndex = 2;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datelbl.Location = new System.Drawing.Point(889, 77);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(56, 28);
            this.Datelbl.TabIndex = 0;
            this.Datelbl.Text = "Date";
            this.Datelbl.Click += new System.EventHandler(this.Datelbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(346, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information";
            // 
            // Roomphonetb
            // 
            this.Roomphonetb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Roomphonetb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Roomphonetb.Location = new System.Drawing.Point(32, 260);
            this.Roomphonetb.Name = "Roomphonetb";
            this.Roomphonetb.Size = new System.Drawing.Size(157, 32);
            this.Roomphonetb.TabIndex = 5;
            this.Roomphonetb.Text = "Room Phone";
            // 
            // Roomnumtb
            // 
            this.Roomnumtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Roomnumtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Roomnumtb.Location = new System.Drawing.Point(32, 180);
            this.Roomnumtb.Name = "Roomnumtb";
            this.Roomnumtb.Size = new System.Drawing.Size(157, 32);
            this.Roomnumtb.TabIndex = 6;
            this.Roomnumtb.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(28, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Free";
            // 
            // Yesradio
            // 
            this.Yesradio.AutoSize = true;
            this.Yesradio.Location = new System.Drawing.Point(77, 330);
            this.Yesradio.Name = "Yesradio";
            this.Yesradio.Size = new System.Drawing.Size(17, 16);
            this.Yesradio.TabIndex = 7;
            this.Yesradio.TabStop = true;
            this.Yesradio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(89, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yes";
            // 
            // Noradio
            // 
            this.Noradio.AutoSize = true;
            this.Noradio.Location = new System.Drawing.Point(131, 331);
            this.Noradio.Name = "Noradio";
            this.Noradio.Size = new System.Drawing.Size(17, 16);
            this.Noradio.TabIndex = 7;
            this.Noradio.TabStop = true;
            this.Noradio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(145, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "No";
            // 
            // RoomDeleteBtn
            // 
            this.RoomDeleteBtn.FlatAppearance.BorderSize = 0;
            this.RoomDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomDeleteBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomDeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomDeleteBtn.Location = new System.Drawing.Point(180, 654);
            this.RoomDeleteBtn.Name = "RoomDeleteBtn";
            this.RoomDeleteBtn.Size = new System.Drawing.Size(78, 40);
            this.RoomDeleteBtn.TabIndex = 13;
            this.RoomDeleteBtn.Text = "DELETE";
            this.RoomDeleteBtn.UseVisualStyleBackColor = true;
            this.RoomDeleteBtn.Click += new System.EventHandler(this.RoomDeleteBtn_Click);
            // 
            // RoomEditBtn
            // 
            this.RoomEditBtn.FlatAppearance.BorderSize = 0;
            this.RoomEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomEditBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomEditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomEditBtn.Location = new System.Drawing.Point(106, 654);
            this.RoomEditBtn.Name = "RoomEditBtn";
            this.RoomEditBtn.Size = new System.Drawing.Size(68, 40);
            this.RoomEditBtn.TabIndex = 14;
            this.RoomEditBtn.Text = "EDIT";
            this.RoomEditBtn.UseVisualStyleBackColor = true;
            this.RoomEditBtn.Click += new System.EventHandler(this.RoomEditBtn_Click);
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.FlatAppearance.BorderSize = 0;
            this.AddRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRoomBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddRoomBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddRoomBtn.Location = new System.Drawing.Point(32, 654);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.Size = new System.Drawing.Size(68, 40);
            this.AddRoomBtn.TabIndex = 15;
            this.AddRoomBtn.Text = "ADD";
            this.AddRoomBtn.UseVisualStyleBackColor = true;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(761, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(667, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 40);
            this.button4.TabIndex = 18;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RoomSearchtb
            // 
            this.RoomSearchtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomSearchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomSearchtb.Location = new System.Drawing.Point(500, 142);
            this.RoomSearchtb.Name = "RoomSearchtb";
            this.RoomSearchtb.Size = new System.Drawing.Size(157, 32);
            this.RoomSearchtb.TabIndex = 17;
            this.RoomSearchtb.Text = "RoomSearch";
            // 
            // RoomGridView
            // 
            this.RoomGridView.AllowUserToAddRows = false;
            this.RoomGridView.AllowUserToDeleteRows = false;
            this.RoomGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridView.Location = new System.Drawing.Point(274, 180);
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.ReadOnly = true;
            this.RoomGridView.RowHeadersVisible = false;
            this.RoomGridView.RowHeadersWidth = 51;
            this.RoomGridView.RowTemplate.Height = 29;
            this.RoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomGridView.Size = new System.Drawing.Size(738, 526);
            this.RoomGridView.TabIndex = 16;
            this.RoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGridView_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(116, 700);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "BACK";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RoomSearchtb);
            this.Controls.Add(this.RoomGridView);
            this.Controls.Add(this.RoomDeleteBtn);
            this.Controls.Add(this.RoomEditBtn);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.Noradio);
            this.Controls.Add(this.Yesradio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Roomphonetb);
            this.Controls.Add(this.Roomnumtb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Roomphonetb;
        private System.Windows.Forms.TextBox Roomnumtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Yesradio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Noradio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RoomDeleteBtn;
        private System.Windows.Forms.Button RoomEditBtn;
        private System.Windows.Forms.Button AddRoomBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox RoomSearchtb;
        private System.Windows.Forms.DataGridView RoomGridView;
        private System.Windows.Forms.Label label6;
    }
}