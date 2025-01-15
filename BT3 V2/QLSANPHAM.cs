using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BT3
{
    public class QLSANPHAM
    {
        private List<SANPHAM> listSp;
        public QLSANPHAM()
        {
            listSp  =new List<SANPHAM>();
        }
        public void Taodulieu()
        {
            listSp.Add(new SANPHAM("111","A",2000,20));
            listSp.Add(new SANPHAM("222", "B", 3000, 30));
            listSp.Add(new SANPHAM("333", "C", 4000, 40));
        }
        private SANPHAM Timkiem(string masp)
        {
            SANPHAM kq = null;
            foreach (SANPHAM sp in listSp)
            {
                if (sp.Masp == masp)
                {
                    kq=sp;
                    break;
                }
            }
            return kq;
        }
        public void ThemSP(SANPHAM sp) 
        {
            if (Timkiem(sp.Masp) != null)
            {
                Console.WriteLine("San pham da ton tai");
            }
            else
            {
                listSp.Add(sp);
            }
        }
         
        public void XoaSP(string masp)
        {
            SANPHAM sp = Timkiem(masp);
            if (sp != null)
            {
                listSp.Remove(sp);
                Console.WriteLine("Xoa san pham thanh cong");
            }
            else
            {
                Console.WriteLine("San pham khong ton tai");
            }
        }
        private int TimSLtonthapnhat()
        {
            int min = listSp[0].Soluongton;
            for (int i = 1; i < listSp.Count; i++)
            {   
                if (listSp[i].Soluongton < min)
                {
                    min = listSp[i].Soluongton;
                }
            }
            return min;
        }

        public List<SANPHAM> SoluongTonThapNhat()
        { 
            List<SANPHAM>kq= new List<SANPHAM>();
            int min =TimSLtonthapnhat();
            foreach (SANPHAM sp in listSp)
            {
                if (sp.Soluongton == min) 
                {
                    kq.Add(sp);
                }
            }
            return kq;
        }
        
        public double TinhTrungBinh( )
        {
            double sum=0;
            foreach (SANPHAM sp in listSp)
            {
                sum += sp.Giaban;
            }
            double avg=sum/listSp.Count;
            return avg;

        }
        public void HienThi()
        {
            
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}",
                "Ma san pham", "Ten san pham", "Gia ban", "So luong ton","GiabanTb");
            foreach (SANPHAM sp in listSp)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}",
                    sp.Masp, sp.Tensp, sp.Giaban, sp.Soluongton,TinhTrungBinh());
            }
        }



    }
}
