using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BT3
{
    public class QLSANPHAM
    {
        private List<SANPHAM> listSP = new List<SANPHAM>
     {
         new SANPHAM("1", "SP1", 1000, 10),
            new SANPHAM("2", "SP2", 2000, 20),
            new SANPHAM("3", "SP3", 3000, 30),
        };
        public QLSANPHAM()
        {
            List<SANPHAM> listSANPHAM = listSP;
        }
        public void ThemSP(SANPHAM sp)
        {
            sp = new SANPHAM();
            Console.WriteLine("Nhap ma san pham: ");
            sp.setmasp(Console.ReadLine());
            Console.WriteLine("Nhap ten san pham: ");
            sp.settensp(Console.ReadLine());
            Console.WriteLine("Nhap gia ban: ");
            sp.setgiaban(double.Parse(Console.ReadLine()));
            Console.WriteLine("Nhap so luong ton: ");
            sp.setsoluongton(int.Parse(Console.ReadLine()));
            bool dem = false;
            for (int i = 0; i < listSP.Count; i++)
            {
                if (listSP[i].getmasp() == sp.getmasp())
                {
                    Console.WriteLine("San pham da ton tai");
                    dem = true;
                    return;
                }

            }
            if (dem == false)
            {
                listSP.Add(sp);
                Console.WriteLine("Them san pham thanh cong");
            }
        }
        public void XoaSP()
        {
            Console.WriteLine("Nhap ma san pham can xoa: ");
            string maSPXoa = Console.ReadLine();
            bool dem = false;
            for (int i = 0; i < listSP.Count; i++)
            {
                if (listSP[i].getmasp() == maSPXoa)
                {
                    listSP.RemoveAt(i);
                    Console.WriteLine("Xoa san pham thanh cong");
                    dem=true;
                    break;
                }
            }
            if (dem ==false)
            {
                Console.WriteLine("San pham khong ton tai");
            }
        }
        public void SoluongTonThapNhat()
        {
            int min = listSP[0].getsoluongton();
            for (int i = 0; i < listSP.Count; i++)
            {
                if (listSP[i].getsoluongton() < min)
                {
                    min = listSP[i].getsoluongton();           
                }
            }
            Console.WriteLine("San pham co so luong ton it nhat la: ");
            for (int i = 0; i < listSP.Count; i++)
            {
                if (listSP[i].getsoluongton() == min)
                {
                    Console.WriteLine("Ma san pham: " + listSP[i].getmasp());
                    Console.WriteLine("Ten san pham: " + listSP[i].gettensp());
                    Console.WriteLine("Gia ban: " + listSP[i].getgiaban());
                    Console.WriteLine("So luong ton: " + listSP[i].getsoluongton());

                }
            }
        }
        public void SapXepGiaBan()
        {
            for (int i = 0; i < listSP.Count - 1; i++)
            {
                for (int j = i + 1; j < listSP.Count; j++)
                {
                    if (listSP[i].getgiaban() > listSP[j].getgiaban())
                    {
                        SANPHAM temp = listSP[i];
                        listSP[i] = listSP[j];
                        listSP[j] = temp;
                    }
                }
            }
            Console.WriteLine("Danh sach san pham sau khi sap xep lai la: ");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}",
                "Ma san pham", "Ten san pham", "Gia ban", "So luong ton");
            for (int i = 0; i < listSP.Count; i++)
            {

                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} ",

                    listSP[i].getmasp(), listSP[i].gettensp(), listSP[i].getgiaban(), listSP[i].getsoluongton());
            }
        }
        public void TinhTrungBinhGiaBanvaHienTHi()
        {
            double sum = 0;
            for (int i = 0; i < listSP.Count; i++)
            {
                sum += listSP[i].getgiaban();
            }
            double avg = sum / listSP.Count;
            Console.WriteLine("Gia ban trung binh cua cac san pham la: " + avg);     
            Console.WriteLine("Danh sach san pham: ");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}{4,-15}",
                "Ma san pham", "Ten san pham", "Gia ban", "So luong ton","Gia Ban TB");
            for (int i = 0; i < listSP.Count; i++)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}",
                    
                    listSP[i].getmasp(), listSP[i].gettensp(), listSP[i].getgiaban(), listSP[i].getsoluongton(),avg);
            }
        }



    }
}
