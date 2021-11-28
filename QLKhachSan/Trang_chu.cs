using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QLKhachSan
{
    /* 
     Nhóm 6 QLKS lớp DHTI12A1 HN
     Đỗ Minh Đạo 18103100053
     Chu Quang Huy 18103100042
     Trần Quang Khánh 18103100028
     */
    public partial class Trang_chu : Form
    {
        public Trang_chu()
        {
            InitializeComponent();
        }

        private void taikhoan_Tooltip_Click(object sender, EventArgs e)
        {
            Form a = new TaiKhoan.Account_Management();
            a.MdiParent = this;
            a.Show();
        }

        private void thongtin_tt_Click(object sender, EventArgs e)
        {
            
        }

        private void repass_Tooltip_Click(object sender, EventArgs e)
        {
            Form childForm = new TaiKhoan.RePasss();
            childForm.MdiParent = this;//Đặt form cha cho childForm là form này
            childForm.Show();//Hiển thị nó lên
        }

        private void exit_Tooltip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn Thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                Form m = new form_Main();
                m.Show();
            }
        }

        private void ex_tooltip_Click(object sender, EventArgs e)
        {
            Process.Start("excel");
        }

        private void wd_tooltip_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void paint_tooltip_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void tacgia_Tooltip_Click(object sender, EventArgs e)
        {
            Form a = new Phongban.Phongban_Manager();
            a.MdiParent = this;
            a.Show();
        }

        private void phongban_Tooltip_Click(object sender, EventArgs e)
        {
         
        }

        private void phongban_Tooltip_Click_1(object sender, EventArgs e)
        {
            Form a = new Nhanvien.Nhanvien_Manager();
            a.MdiParent = this;
            a.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tt = "";
            tt += "Phần mềm : Quản lý khách sạn \n";
            tt += "\n ";
            tt += "version : 1.1";
            tt += "\n\n";
            tt += " Học phần : Lập trình .net HKP 2021 ";
            tt += "\t";
            tt += " ____Bài tập lớn____ ";
            tt += "\n";
            tt += "\nNhóm: 6";
            tt += "\nSinh viên thực hiện : - Đỗ Minh Đạo (Leader)";
            tt += "\nNgày Sinh : 19/11/2000";
            tt += "\nMã sinh viên : 18103100053";
            tt += "\nEmail : minhdaodo2201@gmail.com   ";
            tt += "\n---------------------";
            tt += "\nSinh viên thực hiện : - Chu Quang Huy";
            tt += "\nNgày Sinh : 07/01/2000";
            tt += "\nMã sinh viên : 18103100042";
            tt += "\n---------------------";
            tt += "\nSinh viên thực hiện : - Trần Quang Khánh";
            tt += "\nNgày Sinh : 09/12/2000";
            tt += "\nMã sinh viên : 18103100028 \n\n";
            tt += "version : 1.1 @ năm 2021";

            tt += "\n";
            MessageBox.Show((tt), "Tác giả", MessageBoxButtons.OK);
        }

        private void bảnQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tt = "";
            tt += "Copyright © 2021 dominhdao";

            tt += "\n";
            MessageBox.Show((tt), "Bản quyền", MessageBoxButtons.OK);
        }

        private void bb_nhanvien_Tooltip_Click(object sender, EventArgs e)
        {
            Form a = new Baocao.Baocao_Nhanvien();
            a.MdiParent = this;
            a.Show();
        }

        private void bb_tacgia_Tooltip_Click(object sender, EventArgs e)
        {
            Form a = new Baocao.Baocao_PhongBan();
            a.MdiParent = this;
            a.Show();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tt = "";
            tt += "Hướng dẫn phần mềm : Quản lý khách sạn \n";
            tt += "\n ";
            tt += "version : 1.1";
            tt += "\n\n";
            tt += "\n-Menu Hệ thống";
            tt += "\n+Quản lý tài khoản (để thêm bớt sửa, xóa được tài khoản)";
            tt += "\n+Đổi mật khẩu (cho phép đổi mật khẩu tài khoản của mình)";
            tt += "\n+Thoát";
            tt += "\n";
            tt += "\n-Menu Quản lý thông tin";
            tt += "\n";
            tt += "\n+Form Nhân viên; Sử dụng các nút điều hướng (đầu, trước, sau, cuối) để điều hướng dữ liệu; Nút Nhập lại để nhập lại, Nút Thoát để đóng ứng dụng, Nút Tìm kiếm (gọi đến form tìm kiếm cho phép tìm kiếm theo Tên và theo Quê quán), Nút Sắp xếpkhi click vào cho phép sắp xếp Lương theo thứ tự giảm dần.";
            tt += "\n+Form Phòng ban; Sử dụng các nút điều hướng (đầu, trước, sau, cuối) để điều hướng dữ liệu; Nút Nhập lại để nhập lại, Nút Thoát để đóng ứng dụng, Nút Tìm kiếm (gọi đến form tìm kiếm cho phép tìm kiếm theo Tên phòng ban) Nút Sắp xếp khi click vào cho phép sắp xếp Tên phòng ban theo thứ tự tăng dần.";
            tt += "\n";
            tt += "\n-Menu Báo cáo";
            tt += "\n";
            tt += "\n+Nhân viên có đầy đủ báo cáo chi tiết";
            tt += "\n+Phòng ban có đầy đủ báo cáo chi tiết";
            tt += "\n";
            tt += "\n-Menu tiện ích";
            tt += "\n";
            tt += "\n+ Word: Cho phép mở word";
            tt += "\n+ Excel: Cho phép mở Excel";
            tt += "\n+ Paint: Cho phép mở Paint";
            tt += "\n";
            tt += "\n-Menu trợ giúp";
            tt += "\n";
            tt += "\n+ Tác giả";
            tt += "\n+ Hướng dẫn";
            tt += "\n+ Bản quyền";

            tt += "\n";
            MessageBox.Show((tt), "Hướng dẫn", MessageBoxButtons.OK);
        }

        private void Trang_chu_Load(object sender, EventArgs e)
        {

        }

        private void tienich_tt_Click(object sender, EventArgs e)
        {

        }

        private void Baocao_Tooltip_Click(object sender, EventArgs e)
        {

        }
    }
}
