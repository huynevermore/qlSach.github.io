namespace QLKhachSan
{
    partial class Trang_chu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trang_chu));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_quyen = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.hethongtv = new System.Windows.Forms.ToolStripMenuItem();
            this.taikhoan_Tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.repass_Tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_Tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.quanly_tt = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanvien_Tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.phongban_Tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.Baocao_Tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.bb_nhanvien_Tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.bb_tacgia_Tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.tienich_tt = new System.Windows.Forms.ToolStripMenuItem();
            this.ex_tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.wd_tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.paint_tooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.thongtin_tt = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảnQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1252, 62);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyen.Location = new System.Drawing.Point(1263, 193);
            this.lb_quyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(235, 31);
            this.lb_quyen.TabIndex = 5;
            this.lb_quyen.Text = "Quyền sử dụng : ";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(1263, 126);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(452, 31);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "Tên người truy cập : ...................";
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongtv,
            this.quanly_tt,
            this.Baocao_Tooltip,
            this.tienich_tt,
            this.thongtin_tt});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1763, 36);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // hethongtv
            // 
            this.hethongtv.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taikhoan_Tooltip,
            this.repass_Tooltip,
            this.toolStripMenuItem3,
            this.exit_Tooltip});
            this.hethongtv.Image = ((System.Drawing.Image)(resources.GetObject("hethongtv.Image")));
            this.hethongtv.Name = "hethongtv";
            this.hethongtv.Size = new System.Drawing.Size(131, 32);
            this.hethongtv.Text = "Hệ Thống";
            this.hethongtv.Click += new System.EventHandler(this.hethongtv_Click);
            // 
            // taikhoan_Tooltip
            // 
            this.taikhoan_Tooltip.Image = ((System.Drawing.Image)(resources.GetObject("taikhoan_Tooltip.Image")));
            this.taikhoan_Tooltip.Name = "taikhoan_Tooltip";
            this.taikhoan_Tooltip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.taikhoan_Tooltip.Size = new System.Drawing.Size(332, 32);
            this.taikhoan_Tooltip.Text = "- Quản lý tài khoản";
            this.taikhoan_Tooltip.Click += new System.EventHandler(this.taikhoan_Tooltip_Click);
            // 
            // repass_Tooltip
            // 
            this.repass_Tooltip.Image = ((System.Drawing.Image)(resources.GetObject("repass_Tooltip.Image")));
            this.repass_Tooltip.Name = "repass_Tooltip";
            this.repass_Tooltip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.repass_Tooltip.Size = new System.Drawing.Size(332, 32);
            this.repass_Tooltip.Text = "- Đổi mật khẩu";
            this.repass_Tooltip.Click += new System.EventHandler(this.repass_Tooltip_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(329, 6);
            // 
            // exit_Tooltip
            // 
            this.exit_Tooltip.Image = ((System.Drawing.Image)(resources.GetObject("exit_Tooltip.Image")));
            this.exit_Tooltip.Name = "exit_Tooltip";
            this.exit_Tooltip.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.exit_Tooltip.Size = new System.Drawing.Size(332, 32);
            this.exit_Tooltip.Text = "- Thoát";
            this.exit_Tooltip.Click += new System.EventHandler(this.exit_Tooltip_Click);
            // 
            // quanly_tt
            // 
            this.quanly_tt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanvien_Tooltip,
            this.phongban_Tooltip});
            this.quanly_tt.Image = ((System.Drawing.Image)(resources.GetObject("quanly_tt.Image")));
            this.quanly_tt.Name = "quanly_tt";
            this.quanly_tt.Size = new System.Drawing.Size(199, 32);
            this.quanly_tt.Text = "Quản lý thông tin";
            // 
            // nhanvien_Tooltip
            // 
            this.nhanvien_Tooltip.Name = "nhanvien_Tooltip";
            this.nhanvien_Tooltip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.nhanvien_Tooltip.Size = new System.Drawing.Size(275, 32);
            this.nhanvien_Tooltip.Text = "- Phòng Ban";
            this.nhanvien_Tooltip.Click += new System.EventHandler(this.tacgia_Tooltip_Click);
            // 
            // phongban_Tooltip
            // 
            this.phongban_Tooltip.Name = "phongban_Tooltip";
            this.phongban_Tooltip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.phongban_Tooltip.Size = new System.Drawing.Size(275, 32);
            this.phongban_Tooltip.Text = "- Nhân viên";
            this.phongban_Tooltip.Click += new System.EventHandler(this.phongban_Tooltip_Click_1);
            // 
            // Baocao_Tooltip
            // 
            this.Baocao_Tooltip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bb_nhanvien_Tooltip,
            this.bb_tacgia_Tooltip});
            this.Baocao_Tooltip.Image = ((System.Drawing.Image)(resources.GetObject("Baocao_Tooltip.Image")));
            this.Baocao_Tooltip.Name = "Baocao_Tooltip";
            this.Baocao_Tooltip.Size = new System.Drawing.Size(115, 32);
            this.Baocao_Tooltip.Text = "Báo cáo";
            // 
            // bb_nhanvien_Tooltip
            // 
            this.bb_nhanvien_Tooltip.Name = "bb_nhanvien_Tooltip";
            this.bb_nhanvien_Tooltip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.bb_nhanvien_Tooltip.Size = new System.Drawing.Size(274, 32);
            this.bb_nhanvien_Tooltip.Text = "- Nhân viên";
            this.bb_nhanvien_Tooltip.Click += new System.EventHandler(this.bb_nhanvien_Tooltip_Click);
            // 
            // bb_tacgia_Tooltip
            // 
            this.bb_tacgia_Tooltip.Name = "bb_tacgia_Tooltip";
            this.bb_tacgia_Tooltip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.bb_tacgia_Tooltip.Size = new System.Drawing.Size(274, 32);
            this.bb_tacgia_Tooltip.Text = "- Phòng ban";
            this.bb_tacgia_Tooltip.Click += new System.EventHandler(this.bb_tacgia_Tooltip_Click);
            // 
            // tienich_tt
            // 
            this.tienich_tt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex_tooltip,
            this.wd_tooltip,
            this.paint_tooltip});
            this.tienich_tt.Image = ((System.Drawing.Image)(resources.GetObject("tienich_tt.Image")));
            this.tienich_tt.Name = "tienich_tt";
            this.tienich_tt.Size = new System.Drawing.Size(112, 32);
            this.tienich_tt.Text = "Tiện ích";
            // 
            // ex_tooltip
            // 
            this.ex_tooltip.Image = ((System.Drawing.Image)(resources.GetObject("ex_tooltip.Image")));
            this.ex_tooltip.Name = "ex_tooltip";
            this.ex_tooltip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ex_tooltip.Size = new System.Drawing.Size(236, 32);
            this.ex_tooltip.Text = "- Excel";
            this.ex_tooltip.Click += new System.EventHandler(this.ex_tooltip_Click);
            // 
            // wd_tooltip
            // 
            this.wd_tooltip.Image = ((System.Drawing.Image)(resources.GetObject("wd_tooltip.Image")));
            this.wd_tooltip.Name = "wd_tooltip";
            this.wd_tooltip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.wd_tooltip.Size = new System.Drawing.Size(236, 32);
            this.wd_tooltip.Text = "- Word";
            this.wd_tooltip.Click += new System.EventHandler(this.wd_tooltip_Click);
            // 
            // paint_tooltip
            // 
            this.paint_tooltip.Image = ((System.Drawing.Image)(resources.GetObject("paint_tooltip.Image")));
            this.paint_tooltip.Name = "paint_tooltip";
            this.paint_tooltip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.paint_tooltip.Size = new System.Drawing.Size(236, 32);
            this.paint_tooltip.Text = "- Paint";
            this.paint_tooltip.Click += new System.EventHandler(this.paint_tooltip_Click);
            // 
            // thongtin_tt
            // 
            this.thongtin_tt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tácGiảToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.bảnQuyềnToolStripMenuItem});
            this.thongtin_tt.Image = ((System.Drawing.Image)(resources.GetObject("thongtin_tt.Image")));
            this.thongtin_tt.Name = "thongtin_tt";
            this.thongtin_tt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.thongtin_tt.Size = new System.Drawing.Size(118, 32);
            this.thongtin_tt.Text = "Trợ giúp";
            this.thongtin_tt.Click += new System.EventHandler(this.thongtin_tt_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.tácGiảToolStripMenuItem.Text = "- Tác giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.tácGiảToolStripMenuItem_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.hướngDẫnToolStripMenuItem.Text = "- Hướng dẫn";
            // 
            // bảnQuyềnToolStripMenuItem
            // 
            this.bảnQuyềnToolStripMenuItem.Name = "bảnQuyềnToolStripMenuItem";
            this.bảnQuyềnToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.bảnQuyềnToolStripMenuItem.Text = "- Bản quyền";
            this.bảnQuyềnToolStripMenuItem.Click += new System.EventHandler(this.bảnQuyềnToolStripMenuItem_Click);
            // 
            // Trang_chu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1763, 694);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_quyen);
            this.Controls.Add(this.lb_name);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Trang_chu";
            this.Text = "Tranng chủ nhóm 6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Trang_chu_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label lb_quyen;
        public System.Windows.Forms.Label lb_name;
        public System.Windows.Forms.MenuStrip menu;
        public System.Windows.Forms.ToolStripMenuItem hethongtv;
        public System.Windows.Forms.ToolStripMenuItem taikhoan_Tooltip;
        private System.Windows.Forms.ToolStripMenuItem repass_Tooltip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exit_Tooltip;
        public System.Windows.Forms.ToolStripMenuItem quanly_tt;
        public System.Windows.Forms.ToolStripMenuItem nhanvien_Tooltip;
        public System.Windows.Forms.ToolStripMenuItem phongban_Tooltip;
        public System.Windows.Forms.ToolStripMenuItem Baocao_Tooltip;
        private System.Windows.Forms.ToolStripMenuItem bb_nhanvien_Tooltip;
        private System.Windows.Forms.ToolStripMenuItem bb_tacgia_Tooltip;
        public System.Windows.Forms.ToolStripMenuItem tienich_tt;
        private System.Windows.Forms.ToolStripMenuItem ex_tooltip;
        private System.Windows.Forms.ToolStripMenuItem wd_tooltip;
        private System.Windows.Forms.ToolStripMenuItem paint_tooltip;
        public System.Windows.Forms.ToolStripMenuItem thongtin_tt;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảnQuyềnToolStripMenuItem;
    }
}