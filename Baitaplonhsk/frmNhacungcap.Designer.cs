namespace Baitaplonhsk
{
    partial class frmNhacungcap
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
            this.label9 = new System.Windows.Forms.Label();
            this.dgrNhacungcap = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.errorNhacungcap = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.txtTengiaodich = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTengiaodich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhacungcap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhacungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(384, 32);
            this.label9.TabIndex = 60;
            this.label9.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // dgrNhacungcap
            // 
            this.dgrNhacungcap.AllowUserToAddRows = false;
            this.dgrNhacungcap.AllowUserToDeleteRows = false;
            this.dgrNhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNhacungcap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNCC,
            this.colTenNCC,
            this.colTengiaodich,
            this.colDiachi,
            this.colDienthoai});
            this.dgrNhacungcap.Location = new System.Drawing.Point(87, 262);
            this.dgrNhacungcap.Name = "dgrNhacungcap";
            this.dgrNhacungcap.RowTemplate.Height = 24;
            this.dgrNhacungcap.Size = new System.Drawing.Size(718, 278);
            this.dgrNhacungcap.TabIndex = 46;
            this.dgrNhacungcap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrNhacungcap_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Số điện thoại:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnTimkiem.Location = new System.Drawing.Point(462, 574);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(97, 43);
            this.btnTimkiem.TabIndex = 54;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(660, 159);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(145, 22);
            this.txtDiachi.TabIndex = 58;
            this.txtDiachi.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiachi_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(219, 159);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(145, 22);
            this.txtTenNCC.TabIndex = 57;
            this.txtTenNCC.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenNCC_Validating);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(219, 113);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(145, 22);
            this.txtMaNCC.TabIndex = 56;
            this.txtMaNCC.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaNCC_Validating);
            // 
            // errorNhacungcap
            // 
            this.errorNhacungcap.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(708, 574);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(97, 43);
            this.btnDong.TabIndex = 53;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(86, 574);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 43);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(215, 574);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 43);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(337, 574);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 43);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Tên giao dịch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã nhà cung cấp:";
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(584, 574);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(97, 43);
            this.btnBoqua.TabIndex = 51;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // txtTengiaodich
            // 
            this.txtTengiaodich.Location = new System.Drawing.Point(219, 205);
            this.txtTengiaodich.Name = "txtTengiaodich";
            this.txtTengiaodich.Size = new System.Drawing.Size(145, 22);
            this.txtTengiaodich.TabIndex = 63;
            this.txtTengiaodich.Validating += new System.ComponentModel.CancelEventHandler(this.txtTengiaodich_Validating);
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(660, 113);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(145, 22);
            this.txtSdt.TabIndex = 64;
            this.txtSdt.Validating += new System.ComponentModel.CancelEventHandler(this.txtSdt_Validating);
            // 
            // colMaNCC
            // 
            this.colMaNCC.DataPropertyName = "sMaNcc";
            this.colMaNCC.HeaderText = "Mã nhà cung cấp";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Width = 80;
            // 
            // colTenNCC
            // 
            this.colTenNCC.DataPropertyName = "sTenNcc";
            this.colTenNCC.HeaderText = "Tên nhà cung cấp";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.Width = 170;
            // 
            // colTengiaodich
            // 
            this.colTengiaodich.DataPropertyName = "sTengiaodich";
            this.colTengiaodich.HeaderText = "Tên giao dịch";
            this.colTengiaodich.Name = "colTengiaodich";
            this.colTengiaodich.Width = 150;
            // 
            // colDiachi
            // 
            this.colDiachi.DataPropertyName = "sDiachi";
            this.colDiachi.HeaderText = "Địa chỉ";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Width = 130;
            // 
            // colDienthoai
            // 
            this.colDienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDienthoai.DataPropertyName = "sDienthoai";
            this.colDienthoai.HeaderText = "Số điện thoại";
            this.colDienthoai.Name = "colDienthoai";
            // 
            // frmNhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 659);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtTengiaodich);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgrNhacungcap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoqua);
            this.Name = "frmNhacungcap";
            this.Text = "Danh mục nhà cung cấp";
            this.Load += new System.EventHandler(this.frmNhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhacungcap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhacungcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgrNhacungcap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.ErrorProvider errorNhacungcap;
        private System.Windows.Forms.TextBox txtTengiaodich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTengiaodich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienthoai;
    }
}