namespace Baitaplonhsk
{
    partial class frmLoairem
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
            this.errorLoairem = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.dgrLoairem = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenloairem = new System.Windows.Forms.TextBox();
            this.txtMaloairem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.cbbTenncc = new System.Windows.Forms.ComboBox();
            this.colMaloairem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenloairem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoairem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrLoairem)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLoairem
            // 
            this.errorLoairem.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Honeydew;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.errorLoairem.SetIconAlignment(this.label9, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.label9.Location = new System.Drawing.Point(293, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 32);
            this.label9.TabIndex = 80;
            this.label9.Text = "DANH MỤC HÀNG HÓA";
            // 
            // dgrLoairem
            // 
            this.dgrLoairem.AllowUserToAddRows = false;
            this.dgrLoairem.AllowUserToDeleteRows = false;
            this.dgrLoairem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrLoairem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaloairem,
            this.colTenloairem,
            this.colTenNcc,
            this.colSoluong,
            this.colDongia});
            this.dgrLoairem.Location = new System.Drawing.Point(87, 265);
            this.dgrLoairem.Name = "dgrLoairem";
            this.dgrLoairem.RowHeadersWidth = 51;
            this.dgrLoairem.RowTemplate.Height = 24;
            this.dgrLoairem.Size = new System.Drawing.Size(718, 278);
            this.dgrLoairem.TabIndex = 66;
            this.dgrLoairem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrLoairem_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "Số lượng:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnTimkiem.Location = new System.Drawing.Point(462, 577);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(97, 43);
            this.btnTimkiem.TabIndex = 74;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(660, 162);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(145, 22);
            this.txtDongia.TabIndex = 78;
            this.txtDongia.Validating += new System.ComponentModel.CancelEventHandler(this.txtDongia_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Đơn giá:";
            // 
            // txtTenloairem
            // 
            this.txtTenloairem.Location = new System.Drawing.Point(219, 162);
            this.txtTenloairem.Name = "txtTenloairem";
            this.txtTenloairem.Size = new System.Drawing.Size(145, 22);
            this.txtTenloairem.TabIndex = 77;
            this.txtTenloairem.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenloairem_Validating);
            // 
            // txtMaloairem
            // 
            this.txtMaloairem.Location = new System.Drawing.Point(219, 116);
            this.txtMaloairem.Name = "txtMaloairem";
            this.txtMaloairem.Size = new System.Drawing.Size(145, 22);
            this.txtMaloairem.TabIndex = 76;
            this.txtMaloairem.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaloairem_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tên sản phẩm";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(708, 577);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(97, 43);
            this.btnDong.TabIndex = 73;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(86, 577);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 43);
            this.btnThem.TabIndex = 65;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(215, 577);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 43);
            this.btnSua.TabIndex = 67;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(337, 577);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 43);
            this.btnXoa.TabIndex = 70;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "Tên nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mã sản phẩm";
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(584, 577);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(97, 43);
            this.btnBoqua.TabIndex = 71;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(660, 116);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(145, 22);
            this.txtSoluong.TabIndex = 82;
            this.txtSoluong.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoluong_Validating);
            // 
            // cbbTenncc
            // 
            this.cbbTenncc.FormattingEnabled = true;
            this.cbbTenncc.Location = new System.Drawing.Point(219, 206);
            this.cbbTenncc.Name = "cbbTenncc";
            this.cbbTenncc.Size = new System.Drawing.Size(145, 24);
            this.cbbTenncc.TabIndex = 83;
            // 
            // colMaloairem
            // 
            this.colMaloairem.DataPropertyName = "sMaloairem";
            this.colMaloairem.HeaderText = "Mã sản phẩm";
            this.colMaloairem.MinimumWidth = 6;
            this.colMaloairem.Name = "colMaloairem";
            this.colMaloairem.Width = 70;
            // 
            // colTenloairem
            // 
            this.colTenloairem.DataPropertyName = "sTenloairem";
            this.colTenloairem.HeaderText = "Tên sản phẩm";
            this.colTenloairem.MinimumWidth = 6;
            this.colTenloairem.Name = "colTenloairem";
            this.colTenloairem.Width = 150;
            // 
            // colTenNcc
            // 
            this.colTenNcc.DataPropertyName = "sTenNcc";
            this.colTenNcc.HeaderText = "Tên nhà cung cấp";
            this.colTenNcc.MinimumWidth = 6;
            this.colTenNcc.Name = "colTenNcc";
            this.colTenNcc.Width = 120;
            // 
            // colSoluong
            // 
            this.colSoluong.DataPropertyName = "fSoluong";
            this.colSoluong.HeaderText = "Số lượng";
            this.colSoluong.MinimumWidth = 6;
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.Width = 70;
            // 
            // colDongia
            // 
            this.colDongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDongia.DataPropertyName = "fDongia";
            this.colDongia.HeaderText = "Đơn giá";
            this.colDongia.MinimumWidth = 6;
            this.colDongia.Name = "colDongia";
            // 
            // frmLoairem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(891, 659);
            this.Controls.Add(this.cbbTenncc);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgrLoairem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenloairem);
            this.Controls.Add(this.txtMaloairem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoqua);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmLoairem";
            this.Text = "Danh mục rèm cửa";
            this.Load += new System.EventHandler(this.frmLoairem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorLoairem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrLoairem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorLoairem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgrLoairem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenloairem;
        private System.Windows.Forms.TextBox txtMaloairem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.ComboBox cbbTenncc;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaloairem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenloairem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDongia;
    }
}