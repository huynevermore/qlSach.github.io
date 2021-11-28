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
    }
}
