using System;

namespace BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SANPHAM sp;
            int chon = 0;
            QLSANPHAM ql = new QLSANPHAM();
            do
            {

                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1. Them san pham");
                Console.WriteLine("2. Xoa san pham");
                Console.WriteLine("3. Hien thi san pham co ton kho thap nhap");
                Console.WriteLine("4. Sap xep gia ban tu thap den cao");
                Console.WriteLine("5. Tinh gia trung binh va hien thi danh sach san pham");
                Console.WriteLine("6. Thoat");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.ThemSP(sp = new SANPHAM());
                        break;
                    case 2:
                        ql.XoaSP();
                        break;
                    case 3:
                        ql.SoluongTonThapNhat();
                        break;
                    case 4:
                        ql.SapXepGiaBan();
                        break;
                    case 5:
                        ql.TinhTrungBinhGiaBanvaHienTHi();
                        break;
                    case 6:
                        Console.WriteLine("Duy Khanh code bai nay");
                        break;
                }
            }
            while (chon != 6);



        }
    }
}
