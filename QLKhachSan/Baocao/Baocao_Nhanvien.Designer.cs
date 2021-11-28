namespace QLKhachSan.Baocao
{
    partial class Baocao_Nhanvien
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nhanvienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QLKhachSan.Baocao.DataSet1();
            this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet = new QLKhachSan.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new QLKhachSan.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSetTableAdapters.nhanvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvienBindingSource1
            // 
            this.nhanvienBindingSource1.DataMember = "nhanvien";
            this.nhanvienBindingSource1.DataSource = this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSetBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nhanvienBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKhachSan.Baocao.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1095, 602);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlksNhom6dominhdaochuquanghuytranquangkhanhDataSetBindingSource
            // 
            this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSetBindingSource.DataSource = this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet;
            this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSetBindingSource.Position = 0;
            // 
            // qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet
            // 
            this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet.DataSetName = "qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet";
            this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // Baocao_Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 602);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Baocao_Nhanvien";
            this.Text = "Baocao_Nhanvien";
            this.Load += new System.EventHandler(this.Baocao_Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet;
        private System.Windows.Forms.BindingSource qlksNhom6dominhdaochuquanghuytranquangkhanhDataSetBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nhanvienBindingSource1;
        private qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
    }
}