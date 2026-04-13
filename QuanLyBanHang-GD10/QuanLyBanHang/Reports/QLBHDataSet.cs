using System.Data;

namespace QuanLyBanHang.Reports
{
    public class QLBHDataSet
    {
        public class DanhSachSanPhamDataTable : DataTable
        {
            public DanhSachSanPhamDataTable()
            {
                TableName = "DanhSachSanPham";
                Columns.Add("ID", typeof(int));
                Columns.Add("HangSanXuatID", typeof(int));
                Columns.Add("TenHangSanXuat", typeof(string));
                Columns.Add("LoaiSanPhamID", typeof(int));
                Columns.Add("TenLoai", typeof(string));
                Columns.Add("TenSanPham", typeof(string));
                Columns.Add("DonGia", typeof(int));
                Columns.Add("SoLuong", typeof(int));
                Columns.Add("HinhAnh", typeof(string));
                Columns.Add("MoTa", typeof(string));
            }

            public void AddDanhSachSanPhamRow(int id, int hangSanXuatID, string tenHangSanXuat, int loaiSanPhamID, string tenLoai, string tenSanPham, int donGia, int soLuong, string hinhAnh, string moTa)
            {
                Rows.Add(id, hangSanXuatID, tenHangSanXuat, loaiSanPhamID, tenLoai, tenSanPham, donGia, soLuong, hinhAnh, moTa);
            }
        }

        public class DoanhThuDataTable : DataTable
        {
            public DoanhThuDataTable()
            {
                TableName = "DoanhThu";
                Columns.Add("Thang", typeof(int));
                Columns.Add("Nam", typeof(int));
                Columns.Add("TongTien", typeof(decimal));
            }

            public void AddDoanhThuRow(int thang, int nam, decimal tongTien)
            {
                Rows.Add(thang, nam, tongTien);
            }
        }

        public class DanhSachHoaDon_ChiTietDataTable : DataTable
        {
            public DanhSachHoaDon_ChiTietDataTable()
            {
                TableName = "DanhSachHoaDon_ChiTiet";
                Columns.Add("ID", typeof(int));
                Columns.Add("HoaDonID", typeof(int));
                Columns.Add("SanPhamID", typeof(int));
                Columns.Add("TenSanPham", typeof(string));
                Columns.Add("SoLuongBan", typeof(int));
                Columns.Add("DonGiaBan", typeof(int));
                Columns.Add("ThanhTien", typeof(int));
            }

            public void AddDanhSachHoaDon_ChiTietRow(int id, int hoaDonId, int sanPhamId, string tenSanPham, int soLuongBan, int donGiaBan, int thanhTien)
            {
                Rows.Add(id, hoaDonId, sanPhamId, tenSanPham, soLuongBan, donGiaBan, thanhTien);
            }
        }
    }
}
