namespace Baitaplonhsk
{
    partial class frmKhachhang
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
            this.components = new System.ComponentModel.Container();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.errorKhachhang = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgrKhachhang = new System.Windows.Forms.DataGridView();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtDiachiKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHotenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.txtSdt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorKhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(277, 194);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(47, 21);
            this.rdbNu.TabIndex = 43;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(179, 194);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 21);
            this.rdbNam.TabIndex = 42;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 32);
            this.label9.TabIndex = 41;
            this.label9.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // errorKhachhang
            // 
            this.errorKhachhang.ContainerControl = this;
            // 
            // dgrKhachhang
            // 
            this.dgrKhachhang.AllowUserToAddRows = false;
            this.dgrKhachhang.AllowUserToDeleteRows = false;
            this.dgrKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colGioitinh,
            this.colDiachi,
            this.colDienthoai});
            this.dgrKhachhang.Location = new System.Drawing.Point(63, 247);
            this.dgrKhachhang.Name = "dgrKhachhang";
            this.dgrKhachhang.RowTemplate.Height = 24;
            this.dgrKhachhang.Size = new System.Drawing.Size(718, 278);
            this.dgrKhachhang.TabIndex = 21;
            this.dgrKhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrKhachhang_CellClick);
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "sMaKH";
            this.colMaKH.HeaderText = "Mã khách hàng";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Width = 65;
            // 
            // colTenKH
            // 
            this.colTenKH.DataPropertyName = "sTenKH";
            this.colTenKH.HeaderText = "Tên khách hàng";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Width = 150;
            // 
            // colGioitinh
            // 
            this.colGioitinh.DataPropertyName = "sGioitinhKH";
            this.colGioitinh.HeaderText = "Giới tính";
            this.colGioitinh.Name = "colGioitinh";
            this.colGioitinh.Width = 60;
            // 
            // colDiachi
            // 
            this.colDiachi.DataPropertyName = "sDiachi";
            this.colDiachi.HeaderText = "Địa chỉ";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Width = 110;
            // 
            // colDienthoai
            // 
            this.colDienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDienthoai.DataPropertyName = "sDienthoai";
            this.colDienthoai.HeaderText = "Số điện thoại";
            this.colDienthoai.Name = "colDienthoai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số điện thoại:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnTimkiem.Location = new System.Drawing.Point(439, 564);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(97, 43);
            this.btnTimkiem.TabIndex = 30;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtDiachiKH
            // 
            this.txtDiachiKH.Location = new System.Drawing.Point(637, 149);
            this.txtDiachiKH.Name = "txtDiachiKH";
            this.txtDiachiKH.Size = new System.Drawing.Size(145, 22);
            this.txtDiachiKH.TabIndex = 36;
            this.txtDiachiKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiachiKH_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtHotenKH
            // 
            this.txtHotenKH.Location = new System.Drawing.Point(179, 149);
            this.txtHotenKH.Name = "txtHotenKH";
            this.txtHotenKH.Size = new System.Drawing.Size(145, 22);
            this.txtHotenKH.TabIndex = 35;
            this.txtHotenKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtHotenKH_Validating);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(179, 105);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(145, 22);
            this.txtMaKH.TabIndex = 34;
            this.txtMaKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaKH_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Họ và tên:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(685, 564);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(97, 43);
            this.btnDong.TabIndex = 28;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(63, 564);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 43);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(192, 564);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 43);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(314, 564);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 43);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã khách hàng:";
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(561, 564);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(97, 43);
            this.btnBoqua.TabIndex = 26;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(637, 103);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(145, 22);
            this.txtSdt.TabIndex = 44;
            this.txtSdt.Validating += new System.ComponentModel.CancelEventHandler(this.txtSdt_Validating);
            // 
            // frmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 640);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgrKhachhang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtDiachiKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHotenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoqua);
            this.Name = "frmKhachhang";
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.frmKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorKhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorKhachhang;
        private System.Windows.Forms.DataGridView dgrKhachhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtDiachiKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHotenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienthoai;
    }
}