using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKhachSan.Baocao
{
    /* 
     Nhóm 6 QLKS lớp DHTI12A1 HN
     Đỗ Minh Đạo 18103100053
     Chu Quang Huy 18103100042
     Trần Quang Khánh 18103100028
     */
    public partial class Baocao_PhongBan : Form
    {
        public Baocao_PhongBan()
        {
            InitializeComponent();
        }

        private void Baocao_PhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.phongban' table. You can move, or remove it, as needed.
            this.phongbanTableAdapter.Fill(this.dataSet1.phongban);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
