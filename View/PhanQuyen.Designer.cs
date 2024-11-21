namespace PPPTPMHDT.View
{
    partial class PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanQuyen));
            this.BS_MS = new System.Windows.Forms.MenuStrip();
            this.MS_BS_File = new System.Windows.Forms.ToolStripMenuItem();
            this.BS_MS_F_Logi = new System.Windows.Forms.ToolStripMenuItem();
            this.BS_MS_F_Logo = new System.Windows.Forms.ToolStripMenuItem();
            this.BS_MS_F_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_BS_Syst = new System.Windows.Forms.ToolStripMenuItem();
            this.BS_MS_S_Empl = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_BS_Bank = new System.Windows.Forms.ToolStripMenuItem();
            this.BS_MS_B_Cust = new System.Windows.Forms.ToolStripMenuItem();
            this.BS_MS_B_TrLo = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Empl_B_Save = new System.Windows.Forms.Button();
            this.Empl_B_Upda = new System.Windows.Forms.Button();
            this.Empl_B_Load = new System.Windows.Forms.Button();
            this.Empl_DGV = new System.Windows.Forms.DataGridView();
            this.Empl_TB_EmNa = new System.Windows.Forms.TextBox();
            this.Empl_B_Clos = new System.Windows.Forms.Button();
            this.Empl_TB_EmID = new System.Windows.Forms.TextBox();
            this.Empl_L_EmNa = new System.Windows.Forms.Label();
            this.Empl_L_EmID = new System.Windows.Forms.Label();
            this.Empl_B_Dele = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_MS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Empl_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BS_MS
            // 
            this.BS_MS.AutoSize = false;
            this.BS_MS.BackColor = System.Drawing.Color.Azure;
            this.BS_MS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_MS.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.BS_MS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BS_MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_BS_File,
            this.MS_BS_Syst,
            this.MS_BS_Bank});
            this.BS_MS.Location = new System.Drawing.Point(0, 0);
            this.BS_MS.Name = "BS_MS";
            this.BS_MS.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.BS_MS.Size = new System.Drawing.Size(878, 40);
            this.BS_MS.TabIndex = 4;
            this.BS_MS.Text = "MS_BS";
            // 
            // MS_BS_File
            // 
            this.MS_BS_File.BackColor = System.Drawing.Color.Azure;
            this.MS_BS_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BS_MS_F_Logi,
            this.BS_MS_F_Logo,
            this.BS_MS_F_Exit});
            this.MS_BS_File.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MS_BS_File.Name = "MS_BS_File";
            this.MS_BS_File.Size = new System.Drawing.Size(161, 36);
            this.MS_BS_File.Text = "Tài Khoản";
            // 
            // BS_MS_F_Logi
            // 
            this.BS_MS_F_Logi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_MS_F_Logi.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BS_MS_F_Logi.Name = "BS_MS_F_Logi";
            this.BS_MS_F_Logi.Size = new System.Drawing.Size(261, 36);
            this.BS_MS_F_Logi.Text = "Đăng ký";
            // 
            // BS_MS_F_Logo
            // 
            this.BS_MS_F_Logo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_MS_F_Logo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BS_MS_F_Logo.Name = "BS_MS_F_Logo";
            this.BS_MS_F_Logo.Size = new System.Drawing.Size(261, 36);
            this.BS_MS_F_Logo.Text = "Đăng xuất";
            // 
            // BS_MS_F_Exit
            // 
            this.BS_MS_F_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.BS_MS_F_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_MS_F_Exit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BS_MS_F_Exit.Name = "BS_MS_F_Exit";
            this.BS_MS_F_Exit.Size = new System.Drawing.Size(261, 36);
            this.BS_MS_F_Exit.Text = "Thoát hệ thống";
            // 
            // MS_BS_Syst
            // 
            this.MS_BS_Syst.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BS_MS_S_Empl});
            this.MS_BS_Syst.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MS_BS_Syst.Name = "MS_BS_Syst";
            this.MS_BS_Syst.Size = new System.Drawing.Size(274, 36);
            this.MS_BS_Syst.Text = "Quản Lý Nhân Viên";
            // 
            // BS_MS_S_Empl
            // 
            this.BS_MS_S_Empl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_MS_S_Empl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BS_MS_S_Empl.Name = "BS_MS_S_Empl";
            this.BS_MS_S_Empl.Size = new System.Drawing.Size(364, 36);
            this.BS_MS_S_Empl.Text = "Xem danh sách nhân viên";
            // 
            // MS_BS_Bank
            // 
            this.MS_BS_Bank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BS_MS_B_Cust,
            this.BS_MS_B_TrLo});
            this.MS_BS_Bank.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MS_BS_Bank.Name = "MS_BS_Bank";
            this.MS_BS_Bank.Size = new System.Drawing.Size(182, 36);
            this.MS_BS_Bank.Text = "Phân Quyền";
            // 
            // BS_MS_B_Cust
            // 
            this.BS_MS_B_Cust.BackColor = System.Drawing.SystemColors.Control;
            this.BS_MS_B_Cust.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_MS_B_Cust.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BS_MS_B_Cust.Name = "BS_MS_B_Cust";
            this.BS_MS_B_Cust.Size = new System.Drawing.Size(344, 36);
            this.BS_MS_B_Cust.Text = "Phân quyền nhân viên";
            // 
            // BS_MS_B_TrLo
            // 
            this.BS_MS_B_TrLo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_MS_B_TrLo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BS_MS_B_TrLo.Name = "BS_MS_B_TrLo";
            this.BS_MS_B_TrLo.Size = new System.Drawing.Size(344, 36);
            this.BS_MS_B_TrLo.Text = "Phân quyền người dùng";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.SlateBlue;
            this.textBox2.Location = new System.Drawing.Point(614, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 40);
            this.textBox2.TabIndex = 121;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.SlateBlue;
            this.textBox3.Location = new System.Drawing.Point(614, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 40);
            this.textBox3.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(443, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 34);
            this.label2.TabIndex = 118;
            this.label2.Text = "Ghi Chú";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(443, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 34);
            this.label3.TabIndex = 117;
            this.label3.Text = "Đối Tượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Empl_B_Save
            // 
            this.Empl_B_Save.BackColor = System.Drawing.SystemColors.Window;
            this.Empl_B_Save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empl_B_Save.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Empl_B_Save.Location = new System.Drawing.Point(130, 498);
            this.Empl_B_Save.Name = "Empl_B_Save";
            this.Empl_B_Save.Size = new System.Drawing.Size(112, 40);
            this.Empl_B_Save.TabIndex = 111;
            this.Empl_B_Save.Text = "Lưu";
            this.Empl_B_Save.UseVisualStyleBackColor = false;
            // 
            // Empl_B_Upda
            // 
            this.Empl_B_Upda.BackColor = System.Drawing.SystemColors.Window;
            this.Empl_B_Upda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empl_B_Upda.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Empl_B_Upda.Location = new System.Drawing.Point(518, 498);
            this.Empl_B_Upda.Name = "Empl_B_Upda";
            this.Empl_B_Upda.Size = new System.Drawing.Size(112, 40);
            this.Empl_B_Upda.TabIndex = 116;
            this.Empl_B_Upda.Text = "Cập Nhật";
            this.Empl_B_Upda.UseVisualStyleBackColor = false;
            // 
            // Empl_B_Load
            // 
            this.Empl_B_Load.BackColor = System.Drawing.SystemColors.Window;
            this.Empl_B_Load.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empl_B_Load.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Empl_B_Load.Location = new System.Drawing.Point(12, 498);
            this.Empl_B_Load.Name = "Empl_B_Load";
            this.Empl_B_Load.Size = new System.Drawing.Size(112, 40);
            this.Empl_B_Load.TabIndex = 115;
            this.Empl_B_Load.Text = "Tải Lại";
            this.Empl_B_Load.UseVisualStyleBackColor = false;
            // 
            // Empl_DGV
            // 
            this.Empl_DGV.AllowUserToOrderColumns = true;
            this.Empl_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Empl_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tenQuyen,
            this.doiTuong,
            this.ghiChu});
            this.Empl_DGV.Location = new System.Drawing.Point(12, 153);
            this.Empl_DGV.Name = "Empl_DGV";
            this.Empl_DGV.RowHeadersWidth = 62;
            this.Empl_DGV.Size = new System.Drawing.Size(854, 339);
            this.Empl_DGV.TabIndex = 114;
            // 
            // Empl_TB_EmNa
            // 
            this.Empl_TB_EmNa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empl_TB_EmNa.ForeColor = System.Drawing.Color.SlateBlue;
            this.Empl_TB_EmNa.Location = new System.Drawing.Point(163, 105);
            this.Empl_TB_EmNa.Name = "Empl_TB_EmNa";
            this.Empl_TB_EmNa.Size = new System.Drawing.Size(252, 40);
            this.Empl_TB_EmNa.TabIndex = 112;
            // 
            // Empl_B_Clos
            // 
            this.Empl_B_Clos.BackColor = System.Drawing.SystemColors.Window;
            this.Empl_B_Clos.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Empl_B_Clos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Empl_B_Clos.Location = new System.Drawing.Point(754, 498);
            this.Empl_B_Clos.Name = "Empl_B_Clos";
            this.Empl_B_Clos.Size = new System.Drawing.Size(112, 40);
            this.Empl_B_Clos.TabIndex = 110;
            this.Empl_B_Clos.Text = "Đóng";
            this.Empl_B_Clos.UseVisualStyleBackColor = false;
            // 
            // Empl_TB_EmID
            // 
            this.Empl_TB_EmID.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empl_TB_EmID.ForeColor = System.Drawing.Color.SlateBlue;
            this.Empl_TB_EmID.Location = new System.Drawing.Point(163, 59);
            this.Empl_TB_EmID.Name = "Empl_TB_EmID";
            this.Empl_TB_EmID.Size = new System.Drawing.Size(252, 40);
            this.Empl_TB_EmID.TabIndex = 108;
            // 
            // Empl_L_EmNa
            // 
            this.Empl_L_EmNa.BackColor = System.Drawing.Color.Transparent;
            this.Empl_L_EmNa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empl_L_EmNa.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Empl_L_EmNa.Location = new System.Drawing.Point(12, 107);
            this.Empl_L_EmNa.Name = "Empl_L_EmNa";
            this.Empl_L_EmNa.Size = new System.Drawing.Size(145, 34);
            this.Empl_L_EmNa.TabIndex = 106;
            this.Empl_L_EmNa.Text = "Tên Quyền";
            this.Empl_L_EmNa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Empl_L_EmID
            // 
            this.Empl_L_EmID.BackColor = System.Drawing.Color.Transparent;
            this.Empl_L_EmID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empl_L_EmID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Empl_L_EmID.Location = new System.Drawing.Point(12, 61);
            this.Empl_L_EmID.Name = "Empl_L_EmID";
            this.Empl_L_EmID.Size = new System.Drawing.Size(145, 34);
            this.Empl_L_EmID.TabIndex = 105;
            this.Empl_L_EmID.Text = "ID";
            this.Empl_L_EmID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Empl_B_Dele
            // 
            this.Empl_B_Dele.BackColor = System.Drawing.SystemColors.Window;
            this.Empl_B_Dele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empl_B_Dele.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Empl_B_Dele.Location = new System.Drawing.Point(636, 498);
            this.Empl_B_Dele.Name = "Empl_B_Dele";
            this.Empl_B_Dele.Size = new System.Drawing.Size(112, 40);
            this.Empl_B_Dele.TabIndex = 109;
            this.Empl_B_Dele.Text = "Xóa";
            this.Empl_B_Dele.UseVisualStyleBackColor = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // tenQuyen
            // 
            this.tenQuyen.HeaderText = "tenQuyen";
            this.tenQuyen.MinimumWidth = 8;
            this.tenQuyen.Name = "tenQuyen";
            this.tenQuyen.Width = 150;
            // 
            // doiTuong
            // 
            this.doiTuong.HeaderText = "doiTuong";
            this.doiTuong.MinimumWidth = 8;
            this.doiTuong.Name = "doiTuong";
            this.doiTuong.Width = 150;
            // 
            // ghiChu
            // 
            this.ghiChu.HeaderText = "ghiChu";
            this.ghiChu.MinimumWidth = 8;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Width = 150;
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Empl_B_Save);
            this.Controls.Add(this.Empl_B_Upda);
            this.Controls.Add(this.Empl_B_Load);
            this.Controls.Add(this.Empl_DGV);
            this.Controls.Add(this.Empl_TB_EmNa);
            this.Controls.Add(this.Empl_B_Clos);
            this.Controls.Add(this.Empl_TB_EmID);
            this.Controls.Add(this.Empl_L_EmNa);
            this.Controls.Add(this.Empl_L_EmID);
            this.Controls.Add(this.Empl_B_Dele);
            this.Controls.Add(this.BS_MS);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "PhanQuyen";
            this.Text = "Phân Quyền";
            this.BS_MS.ResumeLayout(false);
            this.BS_MS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Empl_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BS_MS;
        private System.Windows.Forms.ToolStripMenuItem MS_BS_File;
        private System.Windows.Forms.ToolStripMenuItem BS_MS_F_Logi;
        private System.Windows.Forms.ToolStripMenuItem BS_MS_F_Logo;
        private System.Windows.Forms.ToolStripMenuItem BS_MS_F_Exit;
        private System.Windows.Forms.ToolStripMenuItem MS_BS_Syst;
        private System.Windows.Forms.ToolStripMenuItem BS_MS_S_Empl;
        private System.Windows.Forms.ToolStripMenuItem MS_BS_Bank;
        private System.Windows.Forms.ToolStripMenuItem BS_MS_B_Cust;
        private System.Windows.Forms.ToolStripMenuItem BS_MS_B_TrLo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Empl_B_Save;
        private System.Windows.Forms.Button Empl_B_Upda;
        private System.Windows.Forms.Button Empl_B_Load;
        private System.Windows.Forms.DataGridView Empl_DGV;
        private System.Windows.Forms.TextBox Empl_TB_EmNa;
        private System.Windows.Forms.Button Empl_B_Clos;
        private System.Windows.Forms.TextBox Empl_TB_EmID;
        private System.Windows.Forms.Label Empl_L_EmNa;
        private System.Windows.Forms.Label Empl_L_EmID;
        private System.Windows.Forms.Button Empl_B_Dele;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn doiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}