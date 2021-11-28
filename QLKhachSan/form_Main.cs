using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QLKhachSan
{
    /* 
     Nhóm 6 QLKS lớp DHTI12A1 HN
     Đỗ Minh Đạo 18103100053
     Chu Quang Huy 18103100042
     Trần Quang Khánh 18103100028
     */
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan.Login a = new TaiKhoan.Login();
            a.Show();
            this.Hide();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
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
            tt += "\nMã sinh viên : 18103100028 \n\n" ;
            tt += "version : 1.1 @ năm 2021";

            tt += "\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK);
        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new TaiKhoan.Registration();
            a.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            TaiKhoan.Login a = new TaiKhoan.Login();
            a.Show();
            this.Hide();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            Form a = new TaiKhoan.Registration();
            a.Show();
            this.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thóat không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void form_Main_Load(object sender, EventArgs e)
        {

        }

        private void lbform_Click(object sender, EventArgs e)
        {

        }
    }
}
