using BT3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SANPHAM sp;
            int chon = 0;
            QLSANPHAM ql = new QLSANPHAM();
            ql.Taodulieu();
            string masp;
            do
            {

                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1. Them san pham");
                Console.WriteLine("2. Xoa san pham");
                Console.WriteLine("3. Hien thi san pham co ton kho thap nhap");
                Console.WriteLine("4. Tinh gia trung binh gia ban");
                Console.WriteLine("5. Xuat man hinh");
                Console.WriteLine("6. Thoat");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sp = Nhap();
                        ql.ThemSP(sp);
                        break;
                    case 2:
                        Console.WriteLine("Cho biet ma san pham can xoa");
                       masp=Console.ReadLine();
                        ql.XoaSP(masp);
                        break;
                    case 3:

                       List<SANPHAM>kq =ql.SoluongTonThapNhat();
                        XuatSXtonthapnhat(kq);
                        break;
                    case 4:
                        Console.WriteLine("Gia trung binh: " + ql.TinhTrungBinh());
                        break;
                    case 5:
                        ql.HienThi();
                        break;
                    case 6:
                        Console.WriteLine("Duy Khanh code bai nay");
                        break;
                }
            }
            while (chon != 6);

        }

         static  SANPHAM Nhap()
        {
            SANPHAM sp =new SANPHAM();
            Console.WriteLine("Nhap ma sp:");
            sp.Masp = Console.ReadLine();
            Console.WriteLine("Nhap ten sp: ");
            sp.Tensp = Console.ReadLine();
            Console.WriteLine("Nhap gia ban: ");
            sp.Giaban=Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong ton:");
            sp.Soluongton = int.Parse(Console.ReadLine());
            return sp;
        }
        static void XuatSXtonthapnhat(List<SANPHAM>ds)
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} ",
               "Ma san pham", "Ten san pham", "Gia ban", "So luong ton");
            foreach (SANPHAM sp in ds )
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}",
                    sp.Masp, sp.Tensp, sp.Giaban, sp.Soluongton);
            }
        }
    }
}
