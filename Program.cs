using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static DanhSachSieuXe ds = new DanhSachSieuXe();
        static void Main(string[] args)
        {
            Console.Title = "Chương trình quản lý kho xe";
            Console.OutputEncoding = Encoding.Unicode;
            ChayChuongTrinh();
        }
        enum Menu
        {
            ThoatChuongTrinh,
            NhapDuLieuTuFile,
            XemDanhSach,
            TimXeTheoKieu,
            SapTangDanhSachTheoGia,
            XoaXeTheoLoai
        }
        static void XuatMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n========================= MENU =========================");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("0. ".PadRight(3) + " Thoát chương trình!");
            Console.WriteLine("1. ".PadRight(3) + " Nhập dữ liệu từ file");
            Console.WriteLine("2. ".PadRight(3) + " Xem danh sách xe");
            Console.WriteLine("3. ".PadRight(3) + " Tìm xe theo kiểu");
            Console.WriteLine("4. ".PadRight(3) + " Sắp tăng danh sách theo giá");
            Console.WriteLine("5. ".PadRight(3) + " Xóa 1 loại xe bất kì");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("========================= END =========================");
            Console.ResetColor();
        }
        static void ChayChuongTrinh()
        {
            while (true)
            {
                Console.Clear();
                XuatMenu();
                Console.Write(">>>Chọn chức năng: ");
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("\n========================= CHƯƠNG TRÌNH ĐÃ XỬ LÝ XONG =========================");
                Console.ResetColor();
                switch (menu)
                {
                    case Menu.ThoatChuongTrinh:
                        Console.WriteLine("0. ".PadRight(3) + " Thoát chương trình!");
                        return;
                    case Menu.NhapDuLieuTuFile:
                        {
                            Console.WriteLine("1. ".PadRight(3) + " Nhập dữ liệu từ file");
                            ds.NhapDuLieuTuFile();
                            Console.WriteLine("Dữ liệu vừa nhập là:\n" + ds);
                            break;
                        }
                    case Menu.XemDanhSach:
                        {
                            Console.WriteLine("2. ".PadRight(3) + " Xem danh sách xe");
                            Console.WriteLine(ds);
                            break;
                        }
                    case Menu.TimXeTheoKieu:
                        {
                            Console.WriteLine("3. ".PadRight(3) + " Tìm xe theo kiểu");
                            Console.WriteLine("Nhập kiểu xe muốn tìm: ");
                            string kieu = Console.ReadLine();
                            Console.WriteLine("Danh sách xe có kiểu " + kieu + " là: " + ds.TimXeTheoLoai(kieu));
                            break;
                        }
                    case Menu.SapTangDanhSachTheoGia:
                        {
                            Console.WriteLine("4. ".PadRight(3) + " Sắp tăng danh sách theo giá");
                            ds.SapTangDanhSachXeTheoGia();
                            Console.WriteLine("Danh sách sau khi sắp tăng:\n" + ds);
                            break;
                        }
                    case Menu.XoaXeTheoLoai:
                        {
                            Console.WriteLine("5. ".PadRight(3) + " Xóa 1 loại xe bất kì");
                            Console.Write("Nhập loại xe muốn xóa: ");
                            string loai = Console.ReadLine();
                            ds.XoaXeTheoLoai(loai);
                            Console.WriteLine("Danh sách sau khi xóa:\n" + ds);
                            break;
                        }
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter any key to back Menu...");
                Console.ReadKey();
            }
        }
    }
}
