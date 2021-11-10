namespace Baitaplonhsk
{
    partial class frmNhanvien
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
            this.dgrNhanvien = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayvaolam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuongcoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.errorNhanvien = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHotenNV = new System.Windows.Forms.TextBox();
            this.txtDiachiNV = new System.Windows.Forms.TextBox();
            this.txtLcb = new System.Windows.Forms.TextBox();
            this.dtpNgaysinhnv = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayvaolam = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.txtSdt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrNhanvien
            // 
            this.dgrNhanvien.AllowUserToAddRows = false;
            this.dgrNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colNgaysinh,
            this.colGioitinh,
            this.colDiachi,
            this.colDienthoai,
            this.colNgayvaolam,
            this.colLuongcoban});
            this.dgrNhanvien.Location = new System.Drawing.Point(52, 260);
            this.dgrNhanvien.Name = "dgrNhanvien";
            this.dgrNhanvien.RowHeadersVisible = false;
            this.dgrNhanvien.RowTemplate.Height = 24;
            this.dgrNhanvien.Size = new System.Drawing.Size(918, 263);
            this.dgrNhanvien.TabIndex = 0;
            this.dgrNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrNhanvien_CellClick);
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "sMaNV";
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 70;
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "sTenNV";
            this.colTenNV.HeaderText = "Tên nhân viên";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Width = 140;
            // 
            // colNgaysinh
            // 
            this.colNgaysinh.DataPropertyName = "dNgaysinh";
            this.colNgaysinh.HeaderText = "Ngày sinh";
            this.colNgaysinh.Name = "colNgaysinh";
            // 
            // colGioitinh
            // 
            this.colGioitinh.DataPropertyName = "sGioitinh";
            this.colGioitinh.HeaderText = "Giới tính";
            this.colGioitinh.Name = "colGioitinh";
            this.colGioitinh.Width = 70;
            // 
            // colDiachi
            // 
            this.colDiachi.DataPropertyName = "sDiachi";
            this.colDiachi.HeaderText = "Địa chỉ";
            this.colDiachi.Name = "colDiachi";
            // 
            // colDienthoai
            // 
            this.colDienthoai.DataPropertyName = "sDienthoai";
            this.colDienthoai.HeaderText = "Số điện thoại";
            this.colDienthoai.Name = "colDienthoai";
            // 
            // colNgayvaolam
            // 
            this.colNgayvaolam.DataPropertyName = "dNgayvaolam";
            this.colNgayvaolam.HeaderText = "Ngày vào làm";
            this.colNgayvaolam.Name = "colNgayvaolam";
            // 
            // colLuongcoban
            // 
            this.colLuongcoban.DataPropertyName = "fLuongcoban";
            this.colLuongcoban.HeaderText = "Lương cơ bản";
            this.colLuongcoban.Name = "colLuongcoban";
            this.colLuongcoban.Width = 120;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(51, 557);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(215, 557);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 43);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(377, 557);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(873, 557);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(97, 43);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(713, 557);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(97, 43);
            this.btnBoqua.TabIndex = 3;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnTimkiem.Location = new System.Drawing.Point(542, 557);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(97, 43);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // errorNhanvien
            // 
            this.errorNhanvien.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(732, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày vào làm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(732, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lương cơ bản:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(151, 109);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(145, 22);
            this.txtMaNV.TabIndex = 8;
            this.txtMaNV.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaNV_Validating);
            // 
            // txtHotenNV
            // 
            this.txtHotenNV.Location = new System.Drawing.Point(151, 153);
            this.txtHotenNV.Name = "txtHotenNV";
            this.txtHotenNV.Size = new System.Drawing.Size(145, 22);
            this.txtHotenNV.TabIndex = 9;
            this.txtHotenNV.Validating += new System.ComponentModel.CancelEventHandler(this.txtHotenNV_Validating);
            // 
            // txtDiachiNV
            // 
            this.txtDiachiNV.Location = new System.Drawing.Point(504, 153);
            this.txtDiachiNV.Name = "txtDiachiNV";
            this.txtDiachiNV.Size = new System.Drawing.Size(145, 22);
            this.txtDiachiNV.TabIndex = 10;
            this.txtDiachiNV.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiachiNV_Validating);
            // 
            // txtLcb
            // 
            this.txtLcb.Location = new System.Drawing.Point(849, 150);
            this.txtLcb.Name = "txtLcb";
            this.txtLcb.Size = new System.Drawing.Size(121, 22);
            this.txtLcb.TabIndex = 11;
            this.txtLcb.Validating += new System.ComponentModel.CancelEventHandler(this.txtLcb_Validating);
            // 
            // dtpNgaysinhnv
            // 
            this.dtpNgaysinhnv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinhnv.Location = new System.Drawing.Point(504, 195);
            this.dtpNgaysinhnv.Name = "dtpNgaysinhnv";
            this.dtpNgaysinhnv.Size = new System.Drawing.Size(145, 22);
            this.dtpNgaysinhnv.TabIndex = 12;
            this.dtpNgaysinhnv.Value = new System.DateTime(2020, 10, 1, 23, 51, 50, 0);
            this.dtpNgaysinhnv.ValueChanged += new System.EventHandler(this.dtpNgaysinhnv_ValueChanged);
            // 
            // dtpNgayvaolam
            // 
            this.dtpNgayvaolam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayvaolam.Location = new System.Drawing.Point(849, 107);
            this.dtpNgayvaolam.Name = "dtpNgayvaolam";
            this.dtpNgayvaolam.Size = new System.Drawing.Size(121, 22);
            this.dtpNgayvaolam.TabIndex = 13;
            this.dtpNgayvaolam.ValueChanged += new System.EventHandler(this.dtpNgayvaolam_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(151, 198);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 21);
            this.rdbNam.TabIndex = 17;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(249, 198);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(47, 21);
            this.rdbNu.TabIndex = 18;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(504, 107);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(145, 22);
            this.txtSdt.TabIndex = 19;
            this.txtSdt.Validating += new System.ComponentModel.CancelEventHandler(this.txtSdt_Validating);
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1022, 638);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgrNhanvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtDiachiNV);
            this.Controls.Add(this.txtLcb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHotenNV);
            this.Controls.Add(this.dtpNgayvaolam);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.dtpNgaysinhnv);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "frmNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgrNhanvien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ErrorProvider errorNhanvien;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiachiNV;
        private System.Windows.Forms.TextBox txtLcb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHotenNV;
        private System.Windows.Forms.DateTimePicker dtpNgayvaolam;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaysinhnv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayvaolam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuongcoban;
        private System.Windows.Forms.TextBox txtSdt;
    }
}