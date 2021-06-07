using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class DanhSachSieuXe
    {
        List<SieuXe> collection = new List<SieuXe>();

        // Override 
        public override string ToString()
        {
            string s = "\n" + XuatKeNgang('=') + "\n";
            s += "|" + "Hãng".PadRight(12) + "|" + "Loại".PadRight(12) + "|" + "Giá".PadRight(12) + "|" + "Kiểu xe".PadRight(12) + "|" + "Tốc độ".PadRight(12) + "|\n";
            s += XuatKeNgang('=') + "\n";
            foreach (var item in collection)
                s += item + "\n" + XuatKeNgang('-') + "\n";
            s += "|Tổng số xe trong kho là: " + collection.Count.ToString().PadRight(39) + "|\n";
            s += XuatKeNgang('=');
            return s;
        }

        // Methods
        string XuatKeNgang(char k)
        {
            string s = "";
            s += "|";
            for (int i = 0; i < 64; i++)
                s += k;
            s += "|";
            return s;
        }
        /// <summary>
        /// Nhập dữ liệu từ file
        /// </summary>
        public void NhapDuLieuTuFile()
        {
            StreamReader nhap = new StreamReader("SieuXe.txt");
            string s;
            while ((s = nhap.ReadLine()) != null)
                collection.Add(new SieuXe(s));
            nhap.Close();
        }
        /// <summary>
        /// Tìm xe theo kiểu xe
        /// </summary>
        /// <param name="kieu">kiểu xe</param>
        /// <returns></returns>
        public DanhSachSieuXe TimXeTheoLoai(string kieu)
        {
            DanhSachSieuXe kq = new DanhSachSieuXe();
            kq.collection = collection.FindAll(item => string.Compare(item.KieuXe, kieu, true) == 0);
            return kq;
        }
        /// <summary>
        /// Sắp tăng danh sách xe theo giá
        /// </summary>
        public void SapTangDanhSachXeTheoGia()
        {
            collection = collection.OrderBy(item => item.Gia).ToList();
        }
        /// <summary>
        /// Xóa xe theo loại
        /// </summary>
        /// <param name="loai"></param>
        public void XoaXeTheoLoai(string loai)
        {
            collection.RemoveAll(item => string.Compare(item.Loai, loai, true) == 0);
        }
    }
}
