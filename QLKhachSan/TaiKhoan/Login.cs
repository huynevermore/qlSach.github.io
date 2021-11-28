using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLKhachSan.TaiKhoan
{
    /* 
     Nhóm 6 QLKS lớp DHTI12A1 HN
     Đỗ Minh Đạo 18103100053
     Chu Quang Huy 18103100042
     Trần Quang Khánh 18103100028
     */
    public partial class Login : Form
    {
        public static string sqlcon = chuoiketnoi.sqlcon;
        public static SqlConnection mycon;
        public static SqlCommand com;
        public static string full_name = "";
        public static int sate = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql1 = "Select count(*) from DangNhap where Taikhoan='" + txt_tk.Text.Trim() + "' and Matkhau='" + txt_mk.Text.Trim() + "' and phanquyen = 1  ";
            string sql2 = "Select count(*) from DangNhap where Taikhoan ='" + txt_tk.Text + "'and Matkhau ='" + txt_mk.Text + "' and phanquyen = 3  ";
            string chuoi4 = "Select FullName from DangNhap where Taikhoan ='" + txt_tk.Text.Trim() + "'";
            string chuoi5 = "Select trangthai from DangNhap where Taikhoan ='" + txt_tk.Text.Trim() + "'";

            if (txt_tk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản ", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txt_mk.Text == "")
                MessageBox.Show("Bạn chưa nhập Mật khẩu  ", "Thông báo", MessageBoxButtons.OK);
            else
            {

                int a = 0, b = 0 ;
                mycon = new SqlConnection(chuoiketnoi.sqlcon);
                mycon.Open();


                com = new SqlCommand(sql1, mycon);
                a = (int)com.ExecuteScalar();

                SqlCommand com1 = new SqlCommand(sql2, mycon);

                b = (int)com1.ExecuteScalar();

                if (a > 0)
                {
                    int trangthai = chuoiketnoi.check(chuoi5, sate);

                    if (trangthai == 0)
                    {
                        MessageBox.Show("Tài khoản của bạn đang bị khóa , hay liên lạc với Admin để được mở khóa ! xin cảm ơn.", "Thông Báo ", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string tendaydu = chuoiketnoi.load(chuoi4, full_name);
                        MessageBox.Show("Ban dang nhap vao tai khoan Admin", "Thong bao ", MessageBoxButtons.OK);
                        Trang_chu a1 = new Trang_chu();
                        a1.Show();
                        this.Hide();
                        a1.lb_name.Text = "Xin Chào : " + tendaydu;
                        a1.lb_quyen.Text = "Quyền sử dụng : Admin";
                        a1.taikhoan_Tooltip.Visible = true;
                    }
                }
               
                else if (b > 0)
                {
                    int trangthai = chuoiketnoi.check(chuoi5, sate);
                    if (trangthai == 0)
                    {
                        MessageBox.Show("Tài khoản của bạn đang bị khóa , hay liên lạc với Admin để được mở khóa ! xin cảm ơn.", "Thông Báo ", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string tendaydu = chuoiketnoi.load(chuoi4, full_name);
                        MessageBox.Show("Ban dang nhap vao quyền người dùng ", "Thong bao ", MessageBoxButtons.OK);
                        Trang_chu a2 = new Trang_chu();
                        a2.Show();
                        a2.lb_name.Text = "Xin Chào : " + tendaydu;
                        a2.lb_quyen.Text = "Quyền sử dụng : Người dùng";
                        a2.taikhoan_Tooltip.Visible = false;

                    }

                }
                if (a == 0 && b == 0 )
                {
                    string t = "Username hoặc password sai !,Bạn vui lòng kiểm tra lại ";
                    MessageBox.Show((t), "thong báo", MessageBoxButtons.OK);
                    txt_tk.Text = "";
                    txt_mk.Text = "";
                    txt_tk.Focus();
                }

            }



        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                txt_mk.UseSystemPasswordChar = true;

            }
            else
                txt_mk.UseSystemPasswordChar = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TaiKhoan.Registration a = new TaiKhoan.Registration();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn Thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                Form a = new form_Main();
                a.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
