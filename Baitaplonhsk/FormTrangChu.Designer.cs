
namespace Baitaplonhsk
{
    partial class FormTrangChu
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
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.blockUser = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.qlNcc = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐơnĐặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnĐặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donnhaphang = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(273, 85);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(444, 32);
            this.label9.TabIndex = 83;
            this.label9.Text = "Quản Lý Kho hàng siêu thị MiniSo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.qlNcc,
            this.quảnLýĐơnĐặtHàngToolStripMenuItem,
            this.donnhaphang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1371, 31);
            this.menuStrip1.TabIndex = 82;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUser,
            this.blockUser,
            this.changePassword,
            this.logOut,
            this.đăngXuấtToolStripMenuItem});
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(161, 27);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // addUser
            // 
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(224, 28);
            this.addUser.Text = "Cấp tài khoản";
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // blockUser
            // 
            this.blockUser.Name = "blockUser";
            this.blockUser.Size = new System.Drawing.Size(224, 28);
            this.blockUser.Text = "Khóa tài khoản";
            this.blockUser.Click += new System.EventHandler(this.blockUser_Click);
            // 
            // changePassword
            // 
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(224, 28);
            this.changePassword.Text = "Đổi mật khẩu";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // logOut
            // 
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(224, 28);
            this.logOut.Text = "Nhân viên";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // qlNcc
            // 
            this.qlNcc.Name = "qlNcc";
            this.qlNcc.Size = new System.Drawing.Size(193, 27);
            this.qlNcc.Text = "Quản lý nhà cung cấp";
            this.qlNcc.Click += new System.EventHandler(this.qlNcc_Click);
            // 
            // quảnLýĐơnĐặtHàngToolStripMenuItem
            // 
            this.quảnLýĐơnĐặtHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiSảnPhẩmToolStripMenuItem,
            this.đơnĐặtHàngToolStripMenuItem});
            this.quảnLýĐơnĐặtHàngToolStripMenuItem.Name = "quảnLýĐơnĐặtHàngToolStripMenuItem";
            this.quảnLýĐơnĐặtHàngToolStripMenuItem.Size = new System.Drawing.Size(196, 27);
            this.quảnLýĐơnĐặtHàngToolStripMenuItem.Text = "Quản Lý đơn đặt hàng";
            this.quảnLýĐơnĐặtHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐơnĐặtHàngToolStripMenuItem_Click);
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            this.loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            this.loạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.loạiSảnPhẩmToolStripMenuItem.Text = " Sản phẩm";
            this.loạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.loạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // đơnĐặtHàngToolStripMenuItem
            // 
            this.đơnĐặtHàngToolStripMenuItem.Name = "đơnĐặtHàngToolStripMenuItem";
            this.đơnĐặtHàngToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.đơnĐặtHàngToolStripMenuItem.Text = "Đơn đặt hàng";
            this.đơnĐặtHàngToolStripMenuItem.Click += new System.EventHandler(this.đơnĐặtHàngToolStripMenuItem_Click);
            // 
            // donnhaphang
            // 
            this.donnhaphang.Name = "donnhaphang";
            this.donnhaphang.Size = new System.Drawing.Size(144, 27);
            this.donnhaphang.Text = "Đơn nhập hàng";
            this.donnhaphang.Click += new System.EventHandler(this.donnhaphang_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUser;
        private System.Windows.Forms.ToolStripMenuItem blockUser;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
        private System.Windows.Forms.ToolStripMenuItem logOut;
        private System.Windows.Forms.ToolStripMenuItem qlNcc;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐơnĐặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donnhaphang;
        private System.Windows.Forms.ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnĐặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}