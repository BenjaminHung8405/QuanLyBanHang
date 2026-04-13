using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        private QLBHDbContext context = new QLBHDbContext();
        private QLBHDataSet.DoanhThuDataTable doanhThuDataTable = new QLBHDataSet.DoanhThuDataTable();

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var queryDoanhThu = context.HoaDon_ChiTiet
                .Select(ct => new { 
                    Thang = ct.HoaDon.NgayLap.Month, 
                    Nam = ct.HoaDon.NgayLap.Year, 
                    ThanhTien = ct.SoLuongBan * ct.DonGiaBan 
                })
                .GroupBy(x => new { x.Nam, x.Thang })
                .Select(g => new { 
                    Nam = g.Key.Nam, 
                    Thang = g.Key.Thang, 
                    TongTien = g.Sum(x => x.ThanhTien) 
                })
                .OrderBy(x => x.Nam).ThenBy(x => x.Thang)
                .ToList();

            doanhThuDataTable.Clear();
            foreach (var row in queryDoanhThu)
            {
                doanhThuDataTable.AddDoanhThuRow(row.Thang, row.Nam, row.TongTien);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DoanhThu";
            reportDataSource.Value = doanhThuDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);

            reportViewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "Reports", "rptThongKeDoanhThu.rdlc");

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }
    }
}
