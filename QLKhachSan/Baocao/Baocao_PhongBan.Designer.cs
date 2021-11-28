namespace QLKhachSan.Baocao
{
    partial class Baocao_PhongBan
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
            this.phongbanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QLKhachSan.Baocao.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1 = new QLKhachSan.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1();
            this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongbanTableAdapter = new QLKhachSan.Baocao.DataSet1TableAdapters.phongbanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phongbanBindingSource1
            // 
            this.phongbanBindingSource1.DataMember = "phongban";
            this.phongbanBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.phongbanBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKhachSan.Baocao.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1065, 631);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1
            // 
            this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1.DataSetName = "qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1";
            this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlksNhom6dominhdaochuquanghuytranquangkhanhDataSet1BindingSource
            // 
            this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSet1BindingSource.DataSource = this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1;
            this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSet1BindingSource.Position = 0;
            // 
            // phongbanBindingSource
            // 
            this.phongbanBindingSource.DataMember = "phongban";
            this.phongbanBindingSource.DataSource = this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1;
            // 
            // phongbanTableAdapter
            // 
            this.phongbanTableAdapter.ClearBeforeFill = true;
            // 
            // Baocao_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 631);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Baocao_PhongBan";
            this.Text = "Baocao_PhongBan";
            this.Load += new System.EventHandler(this.Baocao_PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlksNhom6dominhdaochuquanghuytranquangkhanhDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource phongbanBindingSource;
        private qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1 qlks_Nhom6_dominhdao_chuquanghuy_tranquangkhanhDataSet1;
        private System.Windows.Forms.BindingSource qlksNhom6dominhdaochuquanghuytranquangkhanhDataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource phongbanBindingSource1;
        private DataSet1TableAdapters.phongbanTableAdapter phongbanTableAdapter;
    }
}