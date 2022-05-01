
namespace HotelManagement
{
    partial class ReservationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReserIdtb = new System.Windows.Forms.TextBox();
            this.datein = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateout = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ReservationSearchtb = new System.Windows.Forms.TextBox();
            this.ReservationGridView = new System.Windows.Forms.DataGridView();
            this.RoomDeleteBtn = new System.Windows.Forms.Button();
            this.RoomEditBtn = new System.Windows.Forms.Button();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.Clientcb = new System.Windows.Forms.ComboBox();
            this.roomcb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(389, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            // 
            // ReserIdtb
            // 
            this.ReserIdtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReserIdtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReserIdtb.Location = new System.Drawing.Point(32, 180);
            this.ReserIdtb.Name = "ReserIdtb";
            this.ReserIdtb.Size = new System.Drawing.Size(157, 32);
            this.ReserIdtb.TabIndex = 8;
            this.ReserIdtb.Text = "ReservationId";
            // 
            // datein
            // 
            this.datein.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datein.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.datein.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.datein.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datein.Location = new System.Drawing.Point(101, 432);
            this.datein.Name = "datein";
            this.datein.Size = new System.Drawing.Size(174, 23);
            this.datein.TabIndex = 9;
            this.datein.ValueChanged += new System.EventHandler(this.datein_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(13, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "DateIn";
            // 
            // dateout
            // 
            this.dateout.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dateout.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateout.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateout.Location = new System.Drawing.Point(101, 488);
            this.dateout.Name = "dateout";
            this.dateout.Size = new System.Drawing.Size(174, 23);
            this.dateout.TabIndex = 9;
            this.dateout.ValueChanged += new System.EventHandler(this.dateout_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(13, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "DateOut";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(761, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
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
            this.button4.TabIndex = 22;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReservationSearchtb
            // 
            this.ReservationSearchtb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReservationSearchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReservationSearchtb.Location = new System.Drawing.Point(500, 142);
            this.ReservationSearchtb.Name = "ReservationSearchtb";
            this.ReservationSearchtb.Size = new System.Drawing.Size(157, 28);
            this.ReservationSearchtb.TabIndex = 21;
            this.ReservationSearchtb.Text = "ReservationSearch";
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.AllowUserToAddRows = false;
            this.ReservationGridView.AllowUserToDeleteRows = false;
            this.ReservationGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGridView.Location = new System.Drawing.Point(281, 180);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.ReadOnly = true;
            this.ReservationGridView.RowHeadersVisible = false;
            this.ReservationGridView.RowHeadersWidth = 51;
            this.ReservationGridView.RowTemplate.Height = 29;
            this.ReservationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationGridView.Size = new System.Drawing.Size(731, 526);
            this.ReservationGridView.TabIndex = 20;
            this.ReservationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridView_CellContentClick);
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
            this.RoomDeleteBtn.TabIndex = 25;
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
            this.RoomEditBtn.TabIndex = 26;
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
            this.AddRoomBtn.TabIndex = 27;
            this.AddRoomBtn.Text = "ADD";
            this.AddRoomBtn.UseVisualStyleBackColor = true;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // Clientcb
            // 
            this.Clientcb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clientcb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Clientcb.FormattingEnabled = true;
            this.Clientcb.Location = new System.Drawing.Point(118, 275);
            this.Clientcb.Name = "Clientcb";
            this.Clientcb.Size = new System.Drawing.Size(157, 31);
            this.Clientcb.TabIndex = 28;
            this.Clientcb.Text = "ClientName";
            // 
            // roomcb
            // 
            this.roomcb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomcb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roomcb.FormattingEnabled = true;
            this.roomcb.Location = new System.Drawing.Point(118, 351);
            this.roomcb.Name = "roomcb";
            this.roomcb.Size = new System.Drawing.Size(157, 31);
            this.roomcb.TabIndex = 28;
            this.roomcb.Text = "RoomID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(13, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(12, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(113, 707);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "BACK";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roomcb);
            this.Controls.Add(this.Clientcb);
            this.Controls.Add(this.RoomDeleteBtn);
            this.Controls.Add(this.RoomEditBtn);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ReservationSearchtb);
            this.Controls.Add(this.ReservationGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datein);
            this.Controls.Add(this.ReserIdtb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationInfo";
            this.Load += new System.EventHandler(this.ReservationInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReserIdtb;
        private System.Windows.Forms.DateTimePicker datein;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ReservationSearchtb;
        private System.Windows.Forms.DataGridView ReservationGridView;
        private System.Windows.Forms.Button RoomDeleteBtn;
        private System.Windows.Forms.Button RoomEditBtn;
        private System.Windows.Forms.Button AddRoomBtn;
        private System.Windows.Forms.ComboBox Clientcb;
        private System.Windows.Forms.ComboBox roomcb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}