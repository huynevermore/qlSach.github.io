using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKhachSan.Nhanvien
{
    /* 
     Nhóm 6 QLKS lớp DHTI12A1 HN
     Đỗ Minh Đạo 18103100053
     Chu Quang Huy 18103100042
     Trần Quang Khánh 18103100028
     */
    public partial class Nhanvien_Manager : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From nhanvien";

        public Nhanvien_Manager()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, data_nhanvien);
            Namecolumn();
            Load_mapb();
           
        }
        // load thông tin mã phongban ra combobox
        void Load_mapb()
        {
            string load1 = "Select mapb from phongban ";
            chuoiketnoi.xulycbx(load1, cb_mapb);
            cb_mapb.DisplayMember = "mapb";
            cb_mapb.ValueMember = "mapb";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            
        }
        

        // binding data -> texbox
        private void data_book_Click(object sender, EventArgs e)
        {

            index = data_nhanvien.CurrentRow.Index;
            PopulateData(index);
        }

        private void PopulateData(int curow)
        {
            txt_manv.Text = data_nhanvien.Rows[curow].Cells[0].Value.ToString();
            txt_hoten.Text = data_nhanvien.Rows[curow].Cells[1].Value.ToString();
            ngaysinh.Text = data_nhanvien.Rows[curow].Cells[2].Value.ToString();
            cb_gioitinh.Text = data_nhanvien.Rows[curow].Cells[3].Value.ToString();
            txt_quequan.Text = data_nhanvien.Rows[curow].Cells[4].Value.ToString();
            nambatdaulv.Text = data_nhanvien.Rows[curow].Cells[5].Value.ToString();
            txt_luong.Text = data_nhanvien.Rows[curow].Cells[6].Value.ToString();
            cb_mapb.Text = data_nhanvien.Rows[curow].Cells[7].Value.ToString();
            txt_manv.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

        //them du lieu
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text == "" || txt_hoten.Text == "" || txt_quequan.Text == "" || txt_luong.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string manv = txt_manv.Text.Trim();
                if (manv.Length > 15)
                {
                    MessageBox.Show("mã nhân viên quá dài ! chỉ nhập nhiều nhất 15 ký tự", "Error", MessageBoxButtons.OK);
                    txt_manv.Text = "";
                    txt_manv.Focus();

                }
                else
                {
                    string sql = "Select count(*) from nhanvien where manhanvien ='" + manv + "'";
                    string sql1 = "Insert into nhanvien values(N'" + txt_manv.Text + "',";
                    sql1 += "N'" + txt_hoten.Text + "',N'" + ngaysinh.Value + "',N'" + cb_gioitinh.SelectedValue + "','" + txt_quequan.Text + "','" + nambatdaulv.Value + "',";
                    sql1 += "'" + txt_luong.Text + "','" + cb_mapb.SelectedValue + "' )";
                    chuoiketnoi.them(sql, sql1, data_nhanvien);
                    chuoiketnoi.Chuoiketnoi(chuoi, data_nhanvien);
                    Namecolumn();
                    Clear();

                }
            }
        }
        // đặt lại colums, và độ rộng datagridview 
        private void Namecolumn()
        {
            data_nhanvien.Columns[0].HeaderText = "Mã Nhân Viên"; data_nhanvien.Columns[0].Width = 100;
            data_nhanvien.Columns[1].HeaderText = "Tên Nhân Viên"; data_nhanvien.Columns[1].Width = 150;
            data_nhanvien.Columns[2].HeaderText = "Ngày sinh"; data_nhanvien.Columns[2].Width = 100;
            data_nhanvien.Columns[3].HeaderText = "Giới tính"; data_nhanvien.Columns[3].Width = 70;
            data_nhanvien.Columns[4].HeaderText = "Quê Quán"; data_nhanvien.Columns[4].Width = 100;
            data_nhanvien.Columns[5].HeaderText = "Năm bắt đầu làm việc"; data_nhanvien.Columns[5].Width = 150;
            data_nhanvien.Columns[6].HeaderText = "Lương"; data_nhanvien.Columns[6].Width = 100;
            data_nhanvien.Columns[7].HeaderText = "Mã Phòng ban"; data_nhanvien.Columns[7].Width = 150;
            int sc = data_nhanvien.Rows.Count;
            index = 0;
            last = sc - 1;
            lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
        }
        //xoa du lieu
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from nhanvien where manhanvien = '" + txt_manv.Text + "'";
            chuoiketnoi.Xoa(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, data_nhanvien);
            Namecolumn();
            Load_mapb();
            Clear();
        }
        // update du lieu
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update nhanvien set hoten = N'" + txt_hoten.Text + "',";
            sql += "ngaysinh = N'" + ngaysinh.Value + "', gioitinh = N'" + cb_gioitinh.SelectedItem + "',";
            sql += "quequan = N'" + txt_quequan.Text + "',luong = '" + txt_luong.Text + "',";
            sql += "nambatdaulv = N'" + nambatdaulv.Value + "',mapb = '" + cb_mapb.SelectedValue + "'";
            sql += "where manhanvien = '" + txt_manv.Text + "'";
            chuoiketnoi.Sua(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, data_nhanvien);
            Namecolumn();
            Load_mapb();
            Clear();
        }
        // sắp xếp giảm dần theo trường
        private void btn_desc_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (cb_sapxep.SelectedItem == "MA NHAN VIEN" || cb_sapxep.SelectedItem == null)
            {
                sql = "SELECT * FROM nhanvien ORDER BY manhanvien DESC";
            }
            else if (cb_sapxep.SelectedItem == "TEN NHAN VIEN")
            {
                sql = "SELECT * FROM nhanvien ORDER BY hoten DESC";
            }
            else if (cb_sapxep.SelectedItem == "QUE QUAN")
            {
                sql = "SELECT * FROM nhanvien ORDER BY quequan DESC";
            }
            else if (cb_sapxep.SelectedItem == "MA PHONG BAN")
            {
                sql = "SELECT * FROM nhanvien ORDER BY mapb DESC";
            }
            if (cb_sapxep.SelectedItem == "LUONG")
            {
                sql = "SELECT * FROM nhanvien ORDER BY luong DESC";
            }

            chuoiketnoi.Chuoiketnoi(sql, data_nhanvien);
            Namecolumn();
            Load_mapb();
        }
        // sắp xếp tăng dần theo trường
        private void btn_ASC_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (cb_sapxep.SelectedItem == "MA NHAN VIEN" || cb_sapxep.SelectedItem == null)
            {
                sql = "SELECT * FROM nhanvien ORDER BY manhanvien ASC";
            }
            else if (cb_sapxep.SelectedItem == "TEN NHAN VIEN")
            {
                sql = "SELECT * FROM nhanvien ORDER BY hoten ASC";
            }
            else if (cb_sapxep.SelectedItem == "QUE QUAN")
            {
                sql = "SELECT * FROM nhanvien ORDER BY quequan ASC";
            }
            if (cb_sapxep.SelectedItem == "MA PHONG BAN")
            {
                sql = "SELECT * FROM nhanvien ORDER BY mapb ASC";
            }
            if (cb_sapxep.SelectedItem == "LUONG")
            {
                sql = "SELECT * FROM nhanvien ORDER BY luong ASC";
            }

            chuoiketnoi.Chuoiketnoi(sql, data_nhanvien);
            Namecolumn();
            Load_mapb();
        }
        // tìm kiếm dữ liệu
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (cb_luachon.SelectedItem == "MA NHAN VIEN" || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from nhanvien where manhanvien like N'%" + tukhoa + "%'";

            }
            else if (cb_luachon.SelectedItem == "TEN NHAN VIEN")
            {
                chuoi1 = "Select * from nhanvien where hoten like N'%" + tukhoa + "%'";

            }
            else if (cb_luachon.SelectedItem == "QUE QUAN")
            {
                chuoi1 = "Select * from nhanvien where quequan like N'%" + tukhoa + "%'";

            }
            if (cb_luachon.SelectedItem == "MA PHONG BAN")
            {
                chuoi1 = "Select * from nhanvien where mapb like N'%" + tukhoa + "%'";

            }

            chuoiketnoi.timkiem(chuoi1, data_nhanvien);
            Namecolumn();
            Load_mapb();
        }
        // làm mới
        private void Clear()
        {
            txt_manv.Enabled = true;
            txt_luong.Text = "";
            txt_manv.Text = "";
            txt_luong.Text = "";
            txt_quequan.Text = "";
            txt_hoten.Text = "";
            txt_search.Text = "";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
            txt_manv.Focus();

        }
        //nhaplai
        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //thoat
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn Xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
        // dau,cuoi,truoc,sau
        private void dau_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData(index);
            data_nhanvien.CurrentCell = data_nhanvien.Rows[index].Cells[0];
        }

        private void cuoi_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData(index);
            data_nhanvien.CurrentCell = data_nhanvien.Rows[index].Cells[0];
        }

        private void truoc_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            data_nhanvien.CurrentCell = data_nhanvien.Rows[index].Cells[0];
        }

        private void sau_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                data_nhanvien.CurrentCell = data_nhanvien.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                data_nhanvien.CurrentCell = data_nhanvien.Rows[index].Cells[0];
            }
        }
        // chặn người dùng nhập ký tự
        private void txt_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // chỉ cho người dùng nhập số
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txt_luong_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_nhanvien_Click(object sender, EventArgs e)
        {
            index = data_nhanvien.CurrentRow.Index;
            PopulateData(index);
        }
        // chặn người dùng nhập ký tự
        private void txt_luong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Nhanvien_Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
