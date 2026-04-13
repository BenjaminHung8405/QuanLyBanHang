namespace QuanLyBanHang.Reports
{
    partial class frmThongKeSanPham
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
            this.lblHangSanXuat = new System.Windows.Forms.Label();
            this.cboHangSanXuat = new System.Windows.Forms.ComboBox();
            this.lblLoaiSanPham = new System.Windows.Forms.Label();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.btnLocKetQua = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.ColumnCount = 5;
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelTop.Controls.Add(this.lblHangSanXuat, 0, 0);
            this.panelTop.Controls.Add(this.cboHangSanXuat, 1, 0);
            this.panelTop.Controls.Add(this.lblLoaiSanPham, 2, 0);
            this.panelTop.Controls.Add(this.cboLoaiSanPham, 3, 0);
            this.panelTop.Controls.Add(this.btnLocKetQua, 4, 0);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.RowCount = 1;
            this.panelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTop.Size = new System.Drawing.Size(800, 60);
            this.panelTop.TabIndex = 1;
            this.lblHangSanXuat.AutoSize = true;
            this.lblHangSanXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHangSanXuat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHangSanXuat.Location = new System.Drawing.Point(3, 0);
            this.lblHangSanXuat.Name = "lblHangSanXuat";
            this.lblHangSanXuat.Size = new System.Drawing.Size(117, 60);
            this.lblHangSanXuat.TabIndex = 0;
            this.lblHangSanXuat.Text = "Hãng sản xuất:";
            this.lblHangSanXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboHangSanXuat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboHangSanXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHangSanXuat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboHangSanXuat.FormattingEnabled = true;
            this.cboHangSanXuat.Location = new System.Drawing.Point(126, 15);
            this.cboHangSanXuat.Name = "cboHangSanXuat";
            this.cboHangSanXuat.Size = new System.Drawing.Size(150, 29);
            this.cboHangSanXuat.TabIndex = 1;
            this.lblLoaiSanPham.AutoSize = true;
            this.lblLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLoaiSanPham.Location = new System.Drawing.Point(308, 0);
            this.lblLoaiSanPham.Name = "lblLoaiSanPham";
            this.lblLoaiSanPham.Size = new System.Drawing.Size(114, 60);
            this.lblLoaiSanPham.TabIndex = 2;
            this.lblLoaiSanPham.Text = "Loại sản phẩm:";
            this.lblLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboLoaiSanPham.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(428, 15);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(150, 29);
            this.cboLoaiSanPham.TabIndex = 3;
            this.btnLocKetQua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLocKetQua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLocKetQua.Location = new System.Drawing.Point(645, 14);
            this.btnLocKetQua.Name = "btnLocKetQua";
            this.btnLocKetQua.Size = new System.Drawing.Size(120, 31);
            this.btnLocKetQua.TabIndex = 4;
            this.btnLocKetQua.Text = "Lọc kết quả";
            this.btnLocKetQua.UseVisualStyleBackColor = true;
            this.btnLocKetQua.Click += new System.EventHandler(this.btnLocKetQua_Click);
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
            // frmThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panelTop);
            this.helpProvider.SetShowHelp(this, true);
            this.Name = "frmThongKeSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sản phẩm";
            this.Load += new System.EventHandler(this.frmThongKeSanPham_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel panelTop;
        private System.Windows.Forms.Label lblHangSanXuat;
        private System.Windows.Forms.ComboBox cboHangSanXuat;
        private System.Windows.Forms.Label lblLoaiSanPham;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private System.Windows.Forms.Button btnLocKetQua;
    }
}
