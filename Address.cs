using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace finalProject
{
    internal class Address
    {
        private string soNha;
        private string tenDuong;
        private string tenPhuong;
        private string tenQuan;
        private string tenThanhPho;
        public string SoNha { get => soNha; set => soNha = value; }
        public string TenDuong { get => tenDuong; set => tenDuong = value; }
        public string TenPhuong { get => tenPhuong; set => tenPhuong = value; }
        public string TenQuan { get => tenQuan; set => tenQuan = value; }
        public string TenThanhPho { get => tenThanhPho; set => tenThanhPho = value; }

        public Address()
        {
            this.soNha = "";
            this.tenDuong = "";
            this.tenPhuong = "";
            this.tenQuan = "";
            this.tenThanhPho = "";

        }
        ~Address()
        {

        }
        public Address(string soNha, string tenDuong, string tenPhuong, string tenQuan, string tenThanhPho)
        {
            SoNha = soNha;
            TenDuong = tenDuong;
            TenPhuong = tenPhuong;
            TenQuan = tenQuan;
            TenThanhPho = tenThanhPho;
        }
        public string GetSoNha()
        {
            return soNha;
        }
        public void SetSoNha(string soNha)
        {
            this.soNha = soNha;
        }

        public string GetTenDuong()
        {
            return tenDuong;
        }
        public void SetTenDuong(string tenDuong)
        {
            this.tenDuong = tenDuong;
        }

        public string GetTenPhuong()
        {
            return tenPhuong;
        }
        public void SetTenPhuong(string tenPhuong)
        {
            this.tenPhuong = tenPhuong;
        }

        public string GetTenQuan()
        {
            return tenQuan;
        }
        public void SetTenQuan(string tenQuan)
        {
            this.tenQuan = tenQuan;
        }

        public string GetTenTP()
        {
            return tenThanhPho;
        }
        public void SetTenTP(string tenTP)
        {
            this.tenThanhPho = tenTP;
        }

        public override string ToString()
        {
            return $"| {SoNha}{new string(' ', 26 - 2 - SoNha.Length)}| {TenDuong}{new string(' ', 26 - 2 - TenDuong.Length)}| {TenPhuong}{new string(' ', 26 - 2 - TenPhuong.Length)}| {TenQuan}{new string(' ', 26 - 2 - TenQuan.Length)}| {TenThanhPho}{new string(' ', 26 - 2 - TenThanhPho.Length)}|";
        }
    }
}
