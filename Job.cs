using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    internal class Job
    {
        private string viTriCongViec; // programmer - tester
        private string noiDaLamViec;
        private int soNamKinhNghiem;
        private string khaNangNgoaiNgu; // trung binh - kha - tot
        private string trinhDoChuyenMon; // cu nhan - thac sy - tien sy
        public string ViTriCongViec { get => viTriCongViec; set => viTriCongViec = value; }
        public string NoiDaLamViec { get => noiDaLamViec; set => noiDaLamViec = value; }
        public int SoNamKinhNghiem { get => soNamKinhNghiem; set => soNamKinhNghiem = value; }
        public string KhaNangNgoaiNgu { get => khaNangNgoaiNgu; set => khaNangNgoaiNgu = value; }
        public string TrinhDoChuyenMon { get => trinhDoChuyenMon; set => trinhDoChuyenMon = value; }
        public Job()
        {
            this.viTriCongViec = "";
            this.noiDaLamViec = "";
            this.soNamKinhNghiem = 0;
            this.khaNangNgoaiNgu = "";
            this.trinhDoChuyenMon = "";
        }
        ~Job()
        {

        }
        public Job(string viTriCongViec, string noiDaLamViec, int soNamKinhNghiem, string khaNangNgoaiNgu, string trinhDoChuyenMon)
        {
            ViTriCongViec = viTriCongViec;
            NoiDaLamViec = noiDaLamViec;
            SoNamKinhNghiem = soNamKinhNghiem;
            KhaNangNgoaiNgu = khaNangNgoaiNgu;
            TrinhDoChuyenMon = trinhDoChuyenMon;
        }
        public string GetViTriCongViec()
        {
            return viTriCongViec;
        }
        public void SetViTriCongViec(string viTriCongViec)
        {
            this.viTriCongViec = viTriCongViec;
        }

        public string GetNoiDaLamViec()
        {
            return noiDaLamViec;
        }
        public void SetNoiDaLamViec(string noiDaLamViec)
        {
            this.noiDaLamViec = noiDaLamViec;
        }

        public int GetSoNamKinhNghiem()
        {
            return soNamKinhNghiem;
        }
        public void SetSoNamKinhNghiem(int soNam)
        {
            this.soNamKinhNghiem = soNam;
        }

        public string GetKhaNangNgoaiNgu()
        {
            return khaNangNgoaiNgu;
        }
        public void SetKhaNangNgoaiNgu(string khaNangNgoaiNgu)
        {
            this.khaNangNgoaiNgu = khaNangNgoaiNgu;
        }

        public string GetTrinhDoChuyenMon()
        {
            return trinhDoChuyenMon;
        }
        public void SetTrinhDoChuyenMon(string trinhDo)
        {
            this.trinhDoChuyenMon = trinhDo;
        }

        public override string ToString()
        {
            return $"| {viTriCongViec}{new string(' ', 26 - 2 - ViTriCongViec.Length)}| {noiDaLamViec}{new string(' ', 26 - 2 - NoiDaLamViec.Length)}| {soNamKinhNghiem}{new string(' ', 23 - (""+soNamKinhNghiem).Length)} | {khaNangNgoaiNgu}{new string(' ', 26 - 2 - KhaNangNgoaiNgu.Length)}| {trinhDoChuyenMon}{new string(' ', 26 - 2 - TrinhDoChuyenMon.Length)}|";
        }
    }
}
