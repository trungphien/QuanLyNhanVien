using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace finalProject
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            Staff[] staff = new Staff[n];
            NhapDanhSachNhanVien(staff);
            XuatDanhSachNhanVien(staff);
            TimKiemNhanVien(staff);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nTổng có {0} nhân viên trong công ty", Staff.GetSoNguoi());
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void XuatDanhSachNhanVien(Staff[] staff)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n***Thông tin địa chỉ của nhân viên");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0;i<staff.Length;i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                staff[i].PrintAddress();
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nThông tin công việc của nhân viên");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < staff.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                staff[i].PrintJob();
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nThông tin cơ bản của nhân viên");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i =0; i < staff.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                staff[i].PrintStaff();
                staff[i].toString();
            }
            for(int i = 0; i < staff.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n==> Lương mà nhân viên thứ {0} nhận được là: {1}"+" VNĐ",(i+1), staff[i].TinhLuongHangThang()," VNĐ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static void NhapDanhSachNhanVien(Staff[] staff)
        {
            Console.Clear();
            Console.WriteLine(" ______________________________________________________");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("|       CHƯƠNG TRÌNH QUẢN LÝ CÔNG TY PHẦN MỀM C#       |");
            Console.WriteLine("|______________________________________________________|");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("|                      1. Programmer                   |");
            Console.WriteLine("|                      2. Tester                       |");
            Console.WriteLine("|                      3. Thoát                        |");
            Console.WriteLine("|______________________________________________________|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n***Nhập danh sách nhân viên");
            Console.ForegroundColor = ConsoleColor.White;

            int choose;
            string maNhanVien;
            string hoTen;
            string gioiTinh;
            string soDienThoai;

            string viTriCongViec;
            string noiDaLamViec;
            int soNamKinhNghiem;
            string khaNangNgoaiNgu;
            string trinhDoChuyenMon;
            string capDo;
            int namSinh;
            int thangSinh;
            int ngaySinh;

            string soNha;
            string tenDuong;
            string tenPhuong;
            string tenQuan;
            string tenThanhPho;

            double luongThang;
            int soLoiLapTrinh;
            double soGioOT;
            double luongCoBan;

            for (int i = 0; i < staff.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n**Nhập loại nhân viên: ");
                choose = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                while (choose != 1 && choose != 2 && choose != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bạn đã nhập sai vui lòng nhập lại");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n**Nhập loại nhân viên: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    choose =int.Parse(Console.ReadLine());
                   
                }
                if (choose == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBạn đã chọn thoát khỏi chương trình!");
                    return;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n*Nhân viên thứ "+(i + 1));
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("***Nhập thông tin chung");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Nhập mã nhân viên: ");
                maNhanVien = Console.ReadLine();
                Console.Write("Nhập họ tên: ");
                hoTen = Console.ReadLine();
                Console.Write("Nhập giới tính: ");
                gioiTinh=Console.ReadLine();
                Console.Write("Nhập số điện thoại: ");
                soDienThoai = Console.ReadLine();
                Console.Write("Nhập vị trí công việc: ");
                viTriCongViec = Console.ReadLine();
                Console.Write("Nhập nơi đã làm việc: ");
                noiDaLamViec = Console.ReadLine();
                Console.Write("Nhập số năm kinh nghiệm: ");
                soNamKinhNghiem=int.Parse(Console.ReadLine());
                Console.Write("Nhập khả năng ngoại ngữ: ");
                khaNangNgoaiNgu=Console.ReadLine();
                Console.Write("Nhập trình độ chuyên môn: ");
                trinhDoChuyenMon = Console.ReadLine();
                Console.Write("Nhập cấp độ: ");
                capDo = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("***Nhập ngày tháng năm sinh của nhân viên");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Nhập năm sinh: ");
                namSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhập tháng sinh: ");
                thangSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhập ngày sinh: ");
                ngaySinh = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("***Nhập đia chỉ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Nhập số nhà: ");
                soNha = Console.ReadLine();
                Console.Write("Nhập tên đường: ");
                tenDuong = Console.ReadLine();
                Console.Write("Nhập tên phường: ");
                tenPhuong = Console.ReadLine();
                Console.Write("Nhập tên quận: ");
                tenQuan = Console.ReadLine();
                Console.Write("Nhập tên thành phố: ");
                tenThanhPho = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("***Nhập thông tin riêng");
                Console.ForegroundColor = ConsoleColor.White;
                if (choose==1)
                {
                    Console.Write("Nhập lương tháng: ");
                    luongThang = double.Parse(Console.ReadLine());
                    Console.Write("Nhập số lỗi lập trình: ");
                    soLoiLapTrinh = int.Parse(Console.ReadLine());
                    staff[i] = new Programmer(maNhanVien, hoTen, new DateTime(namSinh,thangSinh,ngaySinh), gioiTinh, soNha, tenDuong, tenPhuong, tenQuan, tenThanhPho, soDienThoai, viTriCongViec, noiDaLamViec, soNamKinhNghiem, khaNangNgoaiNgu, trinhDoChuyenMon,capDo, soLoiLapTrinh, luongThang);
                }
                else if(choose==2)
                {
                    Console.Write("Nhập số giờ OT: ");
                    soGioOT=double.Parse(Console.ReadLine());
                    Console.Write("Nhập lương cơ bản: ");
                    luongCoBan=double.Parse(Console.ReadLine());
                    staff[i] = new Tester(maNhanVien, hoTen, new DateTime(namSinh, thangSinh, ngaySinh), gioiTinh, soNha, tenDuong, tenPhuong, tenQuan, tenThanhPho, soDienThoai, viTriCongViec, noiDaLamViec, soNamKinhNghiem, khaNangNgoaiNgu, trinhDoChuyenMon,capDo, soGioOT, luongCoBan);
                }
            }  
        }
        static void TimKiemNhanVien(Staff[] staff)
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n");
                Console.WriteLine(" ______________________________________________________");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                  TÌM KIẾM NHÂN VIÊN                  |");
                Console.WriteLine("|______________________________________________________|");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                       1. Họ tên                      |");
                Console.WriteLine("|                       2. Mã nhân viên                |");
                Console.WriteLine("|                       3. Cấp độ                      |");
                Console.WriteLine("|                       4. Thoát                       |");
                Console.WriteLine("|______________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n***Nhập yêu cầu tìm kiếm nhân viên: ");
                int key = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                switch (key)
                {
                    case 1:
                        Console.Write("\nNhập họ tên nhân viên: ");
                        string hoTen = Console.ReadLine();
                        for (int i = 0; i < staff.Length; i++)
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            staff[i].SearchName(hoTen);
                        }
                        break;
                    case 2:
                        Console.Write("Nhập mã nhân viên: ");
                        string maNhanVien = Console.ReadLine();
                        for (int i = 0; i < staff.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            staff[i].SearchId(maNhanVien);
                        }
                        break;
                    case 3:
                        Console.Write("Nhập cấp độ nhân viên: ");
                        string capDo = Console.ReadLine();
                        for (int i = 0; i < staff.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n*Nhân viên thứ " + (i + 1));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            staff[i].SearchLevel(capDo);
                        }
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nBạn đã chọn thoát khỏi chương trình!");
                        Console.ForegroundColor = ConsoleColor.White;
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nBạn đã nhập sai số, chỉ nhập giá trị từ 1 đến 4");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }

    }
}
