using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.Reports
{
    public partial class frmThongKeSanPham : Form
    {
        private QLBHDbContext context = new QLBHDbContext();
        private QLBHDataSet.DanhSachSanPhamDataTable danhSachSanPhamDataTable = new QLBHDataSet.DanhSachSanPhamDataTable();

        public frmThongKeSanPham()
        {
            InitializeComponent();
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            var loaiSanPham = context.LoaiSanPham.ToList();
            loaiSanPham.Insert(0, new LoaiSanPham { ID = 0, TenLoai = "" }); // Empty option for no filter
            cboLoaiSanPham.DataSource = loaiSanPham;
            cboLoaiSanPham.DisplayMember = "TenLoai";
            cboLoaiSanPham.ValueMember = "ID";
        }

        public void LayHangSanXuatVaoComboBox()
        {
            var hangSanXuat = context.HangSanXuat.ToList();
            hangSanXuat.Insert(0, new HangSanXuat { ID = 0, TenHangSanXuat = "" });
            cboHangSanXuat.DataSource = hangSanXuat;
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
            cboHangSanXuat.ValueMember = "ID";
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();

            var danhSachSanPham = context.SanPham.Select(r => new
            {
                ID = r.ID,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                TenSanPham = r.TenSanPham,
                DonGia = r.DonGia,
                SoLuong = r.SoLuong,
                HinhAnh = r.HinhAnh,
                MoTa = r.MoTa
            }).ToList();

            danhSachSanPhamDataTable.Clear();
            foreach (var row in danhSachSanPham)
            {
                danhSachSanPhamDataTable.AddDanhSachSanPhamRow(
                    row.ID,
                    row.HangSanXuatID,
                    row.TenHangSanXuat,
                    row.LoaiSanPhamID,
                    row.TenLoai,
                    row.TenSanPham,
                    row.DonGia,
                    row.SoLuong,
                    row.HinhAnh,
                    row.MoTa);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachSanPham";
            reportDataSource.Value = danhSachSanPhamDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            
            // Using absolute paths based on application runtime directory since we set CopyToOutputDirectory
            reportViewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "Reports", "rptThongKeSanPham.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả sản phẩm)");
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            if (cboHangSanXuat.Text == "" && cboLoaiSanPham.Text == "")
            {
                // Gọi lại load để hiển thị tất cả
                frmThongKeSanPham_Load(sender, e);
            }
            else
            {
                var danhSachSanPham = context.SanPham.Select(r => new
                {
                    ID = r.ID,
                    HangSanXuatID = r.HangSanXuatID,
                    TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                    LoaiSanPhamID = r.LoaiSanPhamID,
                    TenLoai = r.LoaiSanPham.TenLoai,
                    TenSanPham = r.TenSanPham,
                    DonGia = r.DonGia,
                    SoLuong = r.SoLuong,
                    HinhAnh = r.HinhAnh,
                    MoTa = r.MoTa
                });

                string hangSanXuat = null;
                string loaiSanPham = null;

                if (cboHangSanXuat.Text != "")
                {
                    int hangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue.ToString());
                    hangSanXuat = "Hãng sản xuất: " + cboHangSanXuat.Text;
                    danhSachSanPham = danhSachSanPham.Where(r => r.HangSanXuatID == hangSanXuatID);
                }
                if (cboLoaiSanPham.Text != "")
                {
                    int loaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue.ToString());
                    loaiSanPham += "Phân loại: " + cboLoaiSanPham.Text;
                    danhSachSanPham = danhSachSanPham.Where(r => r.LoaiSanPhamID == loaiSanPhamID);
                }

                danhSachSanPhamDataTable.Clear();
                foreach (var row in danhSachSanPham)
                {
                    danhSachSanPhamDataTable.AddDanhSachSanPhamRow(
                        row.ID,
                        row.HangSanXuatID,
                        row.TenHangSanXuat,
                        row.LoaiSanPhamID,
                        row.TenLoai,
                        row.TenSanPham,
                        row.DonGia,
                        row.SoLuong,
                        row.HinhAnh,
                        row.MoTa);
                }

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachSanPham";
                reportDataSource.Value = danhSachSanPhamDataTable;

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "Reports", "rptThongKeSanPham.rdlc");

                string moTa = "";
                if (hangSanXuat != null && loaiSanPham != null) moTa = hangSanXuat + " - " + loaiSanPham;
                else if (hangSanXuat != null) moTa = hangSanXuat;
                else if (loaiSanPham != null) moTa = loaiSanPham;

                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(" + moTa + ")");
                reportViewer.LocalReport.SetParameters(reportParameter);

                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;

                reportViewer.RefreshReport();
            }
        }
    }
}
