namespace QuanLyBanHang.Reports
{
    partial class frmThongKeDoanhThu
    {
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.HelpProvider helpProvider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnLocKetQua = new System.Windows.Forms.Button();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.ColumnCount = 6;
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelTop.Controls.Add(this.lblTuNgay, 0, 0);
            this.panelTop.Controls.Add(this.dtpTuNgay, 1, 0);
            this.panelTop.Controls.Add(this.lblDenNgay, 2, 0);
            this.panelTop.Controls.Add(this.dtpDenNgay, 3, 0);
            this.panelTop.Controls.Add(this.btnLocKetQua, 4, 0);
            this.panelTop.Controls.Add(this.btnHienTatCa, 5, 0);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.RowCount = 1;
            this.panelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTop.Size = new System.Drawing.Size(800, 60);
            this.panelTop.TabIndex = 1;
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTuNgay.Location = new System.Drawing.Point(3, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(68, 60);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            this.lblTuNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpTuNgay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(77, 15);
            this.dtpTuNgay.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpTuNgay.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 29);
            this.dtpTuNgay.TabIndex = 1;
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDenNgay.Location = new System.Drawing.Point(232, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(79, 60);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            this.lblDenNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpDenNgay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(317, 15);
            this.dtpDenNgay.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDenNgay.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 29);
            this.dtpDenNgay.TabIndex = 3;
            this.btnLocKetQua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLocKetQua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLocKetQua.Location = new System.Drawing.Point(472, 14);
            this.btnLocKetQua.Name = "btnLocKetQua";
            this.btnLocKetQua.Size = new System.Drawing.Size(120, 31);
            this.btnLocKetQua.TabIndex = 4;
            this.btnLocKetQua.Text = "Lọc kết quả";
            this.btnLocKetQua.UseVisualStyleBackColor = true;
            this.btnLocKetQua.Click += new System.EventHandler(this.btnLocKetQua_Click);
            this.btnHienTatCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHienTatCa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHienTatCa.Location = new System.Drawing.Point(645, 14);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(120, 31);
            this.btnHienTatCa.TabIndex = 5;
            this.btnHienTatCa.Text = "Hiện tất cả";
            this.btnHienTatCa.UseVisualStyleBackColor = true;
            this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 60);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(800, 390);
            this.reportViewer.TabIndex = 0;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "Help\\index.html";
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panelTop);
            this.helpProvider.SetShowHelp(this, true);
            this.Name = "frmThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel panelTop;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnLocKetQua;
        private System.Windows.Forms.Button btnHienTatCa;
    }
}
