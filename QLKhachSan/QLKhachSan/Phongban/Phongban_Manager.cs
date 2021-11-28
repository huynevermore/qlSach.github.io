using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLKhachSan.Phongban
{
    public partial class Phongban_Manager : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From phongban";
        public Phongban_Manager()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, data_phongban);
            Namecolumn();
         
        }
        // đặt tên cột của datagridview 
        private void Namecolumn()
        {

            data_phongban.Columns[0].HeaderText = "Mã Phòng Ban"; data_phongban.Columns[0].Width = 130;
            data_phongban.Columns[1].HeaderText = "Tên Phòng Ban"; data_phongban.Columns[1].Width = 130;
            data_phongban.Columns[2].HeaderText = "Email Phòng Ban"; data_phongban.Columns[2].Width = 130;
            data_phongban.Columns[3].HeaderText = "Số Điện Thoại"; data_phongban.Columns[3].Width = 120;
            int sc = data_phongban.Rows.Count;
            index = 0;
            last = sc - 1;
            lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_mapb.Text == "" || txt_tenpb.Text == "" || txt_emailpb.Text == "" || txt_dienthoai.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string mapb = txt_mapb.Text.Trim();
                if (mapb.Length > 15)
                {
                    MessageBox.Show("mã sách quá dài ! chỉ nhập nhiều nhất 15 ký tự", "Error", MessageBoxButtons.OK);
                    txt_mapb.Text = "";
                    txt_mapb.Focus();

                }
                else if (isEmail(txt_emailpb.Text) == false)
                {
                    MessageBox.Show("Định dạng mail sai vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
                    txt_emailpb.Text = "";
                    txt_emailpb.Focus();
                }
                else
                {
                    string sql = "Select count(*) from phongban where mapb ='" + mapb + "'";
                    string sql1 = "Insert into phongban values(N'" + txt_mapb.Text + "',N'" + txt_tenpb.Text + "',";
                    sql1 += "'" + txt_emailpb.Text + "','" + txt_dienthoai.Text + "')";
                    chuoiketnoi.them(sql, sql1, data_phongban);
                    chuoiketnoi.Chuoiketnoi(chuoi, data_phongban);
                    Namecolumn();
                    Clear();
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";

            if (cb_luachon.SelectedItem == "Ma Phong Ban" || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from phongban where mapb like N'%" + tukhoa + "%'";
            }
            else if (cb_luachon.SelectedItem == "Ten Phong Ban")
            {
                chuoi1 = "Select * from phongban where tenpb like N'%" + tukhoa + "%'";
            }
            else if (cb_luachon.SelectedItem == "Email")
            {
                chuoi1 = "Select * from phongban where emailpb like N'%" + tukhoa + "%'";
            }

            chuoiketnoi.timkiem(chuoi1, data_phongban);
            Namecolumn();
        }
        private void PopulateData(int curow)
        {
            txt_mapb.Text = data_phongban.Rows[curow].Cells[0].Value.ToString();
            txt_tenpb.Text = data_phongban.Rows[curow].Cells[1].Value.ToString();
            txt_emailpb.Text = data_phongban.Rows[curow].Cells[2].Value.ToString();
            txt_dienthoai.Text = data_phongban.Rows[curow].Cells[3].Value.ToString();
            txt_mapb.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

        }

        private void dau_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData(index);
            data_phongban.CurrentCell = data_phongban.Rows[index].Cells[0];
        }

        private void cuoi_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData(index);
            data_phongban.CurrentCell = data_phongban.Rows[index].Cells[0];
        }

        private void truoc_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            data_phongban.CurrentCell = data_phongban.Rows[index].Cells[0];
        }

        private void sau_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                data_phongban.CurrentCell = data_phongban.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                data_phongban.CurrentCell = data_phongban.Rows[index].Cells[0];
            }
        }
        private void data_Author_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = data_phongban.CurrentRow.Index;
            PopulateData(index);
        }
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void btn_desc_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (cb_sapxep.SelectedItem == "MA PHONG BAN" || cb_sapxep.SelectedItem == null)
            {
                sql = "SELECT * FROM phongban ORDER BY  mapb DESC";
            }
            else if (cb_sapxep.SelectedItem == "TEN PHONG BAN")
            {
                sql = "SELECT * FROM phongban ORDER BY tenpb DESC";
            }
            else if (cb_sapxep.SelectedItem == "EMAIL")
            {
                sql = "SELECT * FROM phongban ORDER BY emailpb DESC";
            }
            chuoiketnoi.Chuoiketnoi(sql, data_phongban);
            Namecolumn();
        }

        private void btn_ASC_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (cb_sapxep.SelectedItem == "MA PHONG BAN" || cb_sapxep.SelectedItem == null)
            {
                sql = "SELECT * FROM phongban ORDER BY  mapb ASC";
            }
            else if (cb_sapxep.SelectedItem == "TEN PHONG BAN")
            {
                sql = "SELECT * FROM phongban ORDER BY tenpb ASC";
            }
            else if (cb_sapxep.SelectedItem == "EMAIL")
            {
                sql = "SELECT * FROM phongban ORDER BY emailpb ASC";
            }
            chuoiketnoi.Chuoiketnoi(sql, data_phongban);
            Namecolumn();
        }
        // làm mới textbox
        private void Clear()
        {
            txt_mapb.Enabled = true;
            txt_mapb.Text = "";
            txt_tenpb.Text = "";
            txt_emailpb.Text = "";
            txt_dienthoai.Text = "";
            txt_search.Text = "";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
            txt_mapb.Focus();

        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (isEmail(txt_emailpb.Text) == false)
            {
                MessageBox.Show("Định dạng mail sai vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
                txt_emailpb.Text = "";
                txt_emailpb.Focus();
            }
            else
            {
                string sql = "Update phongban set tenpb = N'" + txt_tenpb.Text + "',";
                sql += "emailpb = '" + txt_emailpb.Text + "',";
                sql += "dienthoai = '" + txt_dienthoai.Text + "' where mapb = '" + txt_mapb.Text + "'";
                chuoiketnoi.Sua(sql);
                chuoiketnoi.Chuoiketnoi(chuoi, data_phongban);
                Namecolumn();
                Clear();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from phongban where mapb = '" + txt_mapb.Text + "'";
            chuoiketnoi.Xoa(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, data_phongban);
            Namecolumn();
            Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn Xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void data_phongban_Click(object sender, EventArgs e)
        {
            index = data_phongban.CurrentRow.Index;
            PopulateData(index);
        }

        private void data_phongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_dienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Phongban_Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
