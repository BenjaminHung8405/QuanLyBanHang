namespace QuanLyBanHang.Reports
{
    partial class frmThongKeSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;

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
            this.panelTop = new System.Windows.Forms.Panel();
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
            this.panelTop.Controls.Add(this.btnLocKetQua);
            this.panelTop.Controls.Add(this.cboLoaiSanPham);
            this.panelTop.Controls.Add(this.lblLoaiSanPham);
            this.panelTop.Controls.Add(this.cboHangSanXuat);
            this.panelTop.Controls.Add(this.lblHangSanXuat);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 60);
            this.panelTop.TabIndex = 1;
            // 
            // lblHangSanXuat
            // 
            this.lblHangSanXuat.AutoSize = true;
            this.lblHangSanXuat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHangSanXuat.Location = new System.Drawing.Point(12, 20);
            this.lblHangSanXuat.Name = "lblHangSanXuat";
            this.lblHangSanXuat.Size = new System.Drawing.Size(117, 21);
            this.lblHangSanXuat.TabIndex = 0;
            this.lblHangSanXuat.Text = "Hãng sản xuất:";
            // 
            // cboHangSanXuat
            // 
            this.cboHangSanXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHangSanXuat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboHangSanXuat.FormattingEnabled = true;
            this.cboHangSanXuat.Location = new System.Drawing.Point(135, 17);
            this.cboHangSanXuat.Name = "cboHangSanXuat";
            this.cboHangSanXuat.Size = new System.Drawing.Size(150, 29);
            this.cboHangSanXuat.TabIndex = 1;
            // 
            // lblLoaiSanPham
            // 
            this.lblLoaiSanPham.AutoSize = true;
            this.lblLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLoaiSanPham.Location = new System.Drawing.Point(308, 20);
            this.lblLoaiSanPham.Name = "lblLoaiSanPham";
            this.lblLoaiSanPham.Size = new System.Drawing.Size(114, 21);
            this.lblLoaiSanPham.TabIndex = 2;
            this.lblLoaiSanPham.Text = "Loại sản phẩm:";
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(428, 17);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(150, 29);
            this.cboLoaiSanPham.TabIndex = 3;
            // 
            // btnLocKetQua
            // 
            this.btnLocKetQua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLocKetQua.Location = new System.Drawing.Point(604, 16);
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
            // frmThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panelTop);
            this.Name = "frmThongKeSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sản phẩm";
            this.Load += new System.EventHandler(this.frmThongKeSanPham_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblHangSanXuat;
        private System.Windows.Forms.ComboBox cboHangSanXuat;
        private System.Windows.Forms.Label lblLoaiSanPham;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private System.Windows.Forms.Button btnLocKetQua;
    }
}
