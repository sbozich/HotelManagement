
namespace HotelManagement
{
    partial class StaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.staffphonetbl = new System.Windows.Forms.TextBox();
            this.staffnametbl = new System.Windows.Forms.TextBox();
            this.staffidtbl = new System.Windows.Forms.TextBox();
            this.staffgendercb = new System.Windows.Forms.ComboBox();
            this.StaffGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.StaffSearchtb = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.StaffEditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(346, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information";
            // 
            // staffphonetbl
            // 
            this.staffphonetbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffphonetbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffphonetbl.Location = new System.Drawing.Point(32, 339);
            this.staffphonetbl.Name = "staffphonetbl";
            this.staffphonetbl.Size = new System.Drawing.Size(157, 32);
            this.staffphonetbl.TabIndex = 2;
            this.staffphonetbl.Text = "Phone Number";
            // 
            // staffnametbl
            // 
            this.staffnametbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffnametbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffnametbl.Location = new System.Drawing.Point(32, 260);
            this.staffnametbl.Name = "staffnametbl";
            this.staffnametbl.Size = new System.Drawing.Size(157, 32);
            this.staffnametbl.TabIndex = 3;
            this.staffnametbl.Text = "Staff Name";
            // 
            // staffidtbl
            // 
            this.staffidtbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffidtbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffidtbl.Location = new System.Drawing.Point(32, 180);
            this.staffidtbl.Name = "staffidtbl";
            this.staffidtbl.Size = new System.Drawing.Size(157, 32);
            this.staffidtbl.TabIndex = 4;
            this.staffidtbl.Text = "StaffId";
            // 
            // staffgendercb
            // 
            this.staffgendercb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffgendercb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffgendercb.FormattingEnabled = true;
            this.staffgendercb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.staffgendercb.Location = new System.Drawing.Point(32, 480);
            this.staffgendercb.Name = "staffgendercb";
            this.staffgendercb.Size = new System.Drawing.Size(157, 31);
            this.staffgendercb.TabIndex = 5;
            this.staffgendercb.Text = "Gender";
            // 
            // StaffGridView
            // 
            this.StaffGridView.AllowUserToAddRows = false;
            this.StaffGridView.AllowUserToDeleteRows = false;
            this.StaffGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGridView.Location = new System.Drawing.Point(274, 180);
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.ReadOnly = true;
            this.StaffGridView.RowHeadersVisible = false;
            this.StaffGridView.RowHeadersWidth = 51;
            this.StaffGridView.RowTemplate.Height = 29;
            this.StaffGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffGridView.Size = new System.Drawing.Size(738, 526);
            this.StaffGridView.TabIndex = 6;
            this.StaffGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGridView_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(761, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
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
            this.button4.TabIndex = 8;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StaffSearchtb
            // 
            this.StaffSearchtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffSearchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StaffSearchtb.Location = new System.Drawing.Point(500, 142);
            this.StaffSearchtb.Name = "StaffSearchtb";
            this.StaffSearchtb.Size = new System.Drawing.Size(157, 32);
            this.StaffSearchtb.TabIndex = 7;
            this.StaffSearchtb.Text = "StaffSearch";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(171, 517);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(78, 40);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // StaffEditBtn
            // 
            this.StaffEditBtn.FlatAppearance.BorderSize = 0;
            this.StaffEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffEditBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffEditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StaffEditBtn.Location = new System.Drawing.Point(97, 517);
            this.StaffEditBtn.Name = "StaffEditBtn";
            this.StaffEditBtn.Size = new System.Drawing.Size(68, 40);
            this.StaffEditBtn.TabIndex = 11;
            this.StaffEditBtn.Text = "EDIT";
            this.StaffEditBtn.UseVisualStyleBackColor = true;
            this.StaffEditBtn.Click += new System.EventHandler(this.StaffEditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.Location = new System.Drawing.Point(23, 517);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(68, 40);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // passwordtb
            // 
            this.passwordtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.passwordtb.Location = new System.Drawing.Point(32, 417);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(157, 32);
            this.passwordtb.TabIndex = 2;
            this.passwordtb.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(102, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "BACK";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.StaffEditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.StaffSearchtb);
            this.Controls.Add(this.StaffGridView);
            this.Controls.Add(this.staffgendercb);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.staffphonetbl);
            this.Controls.Add(this.staffnametbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.staffidtbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInfo";
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox staffphonetbl;
        private System.Windows.Forms.TextBox staffnametbl;
        private System.Windows.Forms.TextBox staffidtbl;
        private System.Windows.Forms.ComboBox staffgendercb;
        private System.Windows.Forms.DataGridView StaffGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox StaffSearchtb;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button StaffEditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Label label6;
    }
}