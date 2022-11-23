using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Tester:Staff
    {
        private double soGioOT;
        private double luongCoBan;
        public double SoGioOT { get => soGioOT; set => soGioOT = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public Tester()
        {
            this.soGioOT = 0;
            this.luongCoBan = 0;
        }
        ~Tester()
        {

        }
        public Tester(double soGioOT, double luongCoBan)
        {
            SoGioOT = soGioOT;
            LuongCoBan = luongCoBan;
        }
        public Tester(string maNhanVien, string hoTen, DateTime ngaySinh, string gioiTinh, string soNha, string tenDuong, string tenPhuong, string tenQuan, string tenThanhPho, string soDienThoai, string viTriCongViec, string noiDaLamViec, int soNamKinhNghiem, string khaNangNgoaiNgu, string trinhDoChuyenMon, string capDo, double soGioOT, double luongCoBan) : base(maNhanVien, hoTen, ngaySinh, gioiTinh, soNha, tenDuong, tenPhuong, tenQuan, tenThanhPho, soDienThoai, viTriCongViec, noiDaLamViec, soNamKinhNghiem, khaNangNgoaiNgu, trinhDoChuyenMon, capDo)
        {
            SoGioOT = soGioOT;
            LuongCoBan = luongCoBan;
        }

        public double GetSoGioOT()
        {
            return soGioOT;
        }

        public void SetSoGioOT(double soGioOT)
        {
            this.soGioOT = soGioOT;
        }

        public double GetLuongCoBan()
        {
            return luongCoBan;
        }

        public void SetLuongCoBan(double luongCB)
        {
            this.luongCoBan = luongCB;
        }

        public override string toString()
        {
            return base.toString() + $"==> Số giờ OT: {soGioOT} - Lương cơ bản: {luongCoBan}";

        }
        
        public override double TinhLuongHangThang()
        {
            // luong thang = luong co ban + so gio overtime*200.000(VND)
            return LuongCoBan + SoGioOT * 200000;
        }
        

    }
}
