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
    public partial class Baocao_Nhanvien : Form
    {
        public Baocao_Nhanvien()
        {
            InitializeComponent();
        }

        private void Baocao_Nhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet.nhanvien);

            this.reportViewer1.RefreshReport();
        }
    }
}
