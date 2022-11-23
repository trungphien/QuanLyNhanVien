using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    abstract class Staff
    {
        private string maNhanVien;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private Address diaChi;
        private string soDienThoai;
        private Job job; // bien dung de mo ta kinh nghiem, trinh do lam viec cua nhan vien
        private string capDo; // junior - senior - technical lead - manager 
        private static int countOfPerson = 0; // bien tinh dem so luong doi tuong duoc khoi tao
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string CapDo { get => capDo; set => capDo = value; }
        internal Address DiaChi { get => diaChi; set => diaChi = value; }
        internal Job Job { get => job; set => job = value; }
        public static int CountOfPerson { get => countOfPerson; set => countOfPerson = value; }
        public static int GetSoNguoi()
        {
            return countOfPerson;
        }
        public Staff()
        {
            this.maNhanVien = "";
            this.hoTen = "";
            this.gioiTinh = "";
            this.soDienThoai = "";
            this.ngaySinh = new DateTime();
            this.diaChi = new Address();
            this.job = new Job();
            this.capDo = "";
            countOfPerson++;
        }
        ~Staff()
        {

        }
        public Staff(string maNhanVien, string hoTen, DateTime ngaySinh, string gioiTinh, string soNha, string tenDuong, string tenPhuong, string tenQuan, string tenThanhPho, string soDienThoai, string viTriCongViec, string noiDaLamViec, int soNamKinhNghiem, string khaNangNgoaiNgu, string trinhDoChuyenMon, string capDo)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = new Address(soNha, tenDuong, tenPhuong, tenQuan, tenThanhPho);
            SoDienThoai = soDienThoai;
            Job = new Job(viTriCongViec, noiDaLamViec, soNamKinhNghiem, khaNangNgoaiNgu, trinhDoChuyenMon);
            CapDo = capDo;
            CountOfPerson++;
        }
        public virtual string toString()
        {
            return $"| {maNhanVien}{new string(' ', 26 - 2 - MaNhanVien.Length)}| {hoTen}{new string(' ', 26 - 2 - HoTen.Length)}|{ngaySinh:dd//MM/yyyy}{new string(' ', 26 - 2 - 10)}| {gioiTinh}{new string(' ', 26 - 2 - GioiTinh.Length)}| {soDienThoai}{new string(' ', 26 - 2 - SoDienThoai.Length)}| {capDo}{new string(' ', 26 - 2 - CapDo.Length)}|";
        }
        public abstract double TinhLuongHangThang();

        // In dia chi
        public virtual void PrintAddress()
        {
            int space = 26;
            Console.WriteLine(" " + new string('_', space - 1) + " " + new string('_', space - 1) + " " + new string('_', space - 1) + " " + new string('_', space - 1) + " " + new string('_', space - 1) + " ");
            Console.WriteLine("|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|");
            Console.WriteLine("| Số nhà" + new string(' ', space - 8) + "| Đường" + new string(' ', space - 7) + "| Phường" + new string(' ', space - 8) + "| Quận" + new string(' ', space - 6) + "| Thành phố" + new string(' ', space - 11) + "|");
            Console.WriteLine("|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|");
            Console.WriteLine(DiaChi.ToString());
            Console.WriteLine("|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|");
        }
        // In thong tin ve kinh nghiem, trinh do lam viec của nhan vien
        public virtual void PrintJob()
        {
            int space = 26;
            Console.WriteLine(" " + new string('_', space - 1) + " " + new string('_', space - 1) + " " + new string('_', space - 1) + " " + new string('_', space - 1) + " " + new string('_', space - 1) + " ");
            Console.WriteLine("|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|");
            Console.WriteLine("| Vị trí làm việc" + new string(' ', space - 17) + "| Nơi đã làm việc" + new string(' ', space - 17) + "| Số năm kinh nghiệm" + new string(' ', space - 20) + "| Khả năng ngoại ngữ" + new string(' ', space - 20) + "| Trình độ chuyên môn" + new string(' ', space - 21) + "|");
            Console.WriteLine("|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|");
            Console.WriteLine(Job.ToString());
            Console.WriteLine("|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|");
        }
        // In thong tin cua nhan vien
        public virtual void PrintStaff()
        {
            int space = 26;
            Console.WriteLine(" " + new string('_', space - 1) + " " + new string('_', space - 1) + " " + new string('_', space - 1) + " " + new string('_', space - 1) + " " + new string('_', space - 1) + " " + new string('_', space - 1) + " ");
            Console.WriteLine("|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|");
            Console.WriteLine("| Mã nhân viên" + new string(' ', space - 14) + "| Họ tên" + new string(' ', space - 8) + "| Ngày sinh" + new string(' ', space - 11) + "| Giới tính" + new string(' ', space - 11) + "| Số điện thoại" + new string(' ', space - 15) + "| Cấp dộ" + new string(' ', space - 8) + "|");
            Console.WriteLine("|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|");
            Console.WriteLine(toString());
            Console.WriteLine("|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|");
        }
       
        // Tim nhan vien theo ten
        public virtual bool SearchName(string name)
        {
            if(name == hoTen)
            {
                PrintAddress();
                PrintJob();
                PrintStaff();
                return true;
            }
            return false;
        }
        // Tim nhan vien theo ma so
        public virtual bool SearchId(string id)
        {
            if (id == maNhanVien)
            {
                PrintAddress();
                PrintJob();
                PrintStaff();
                return true;
            }
            return false;
        }
        // Tim nhan vien theo cap do
        public virtual bool SearchLevel(string level)
        {
            if (level ==capDo)
            {
                PrintAddress();
                PrintJob();
                PrintStaff();
                return true;
            }
            return false;
        }
    }
}
