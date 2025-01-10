using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public class SANPHAM
    {
        private string masp;
        private string tensp;
        private double giaban;
        private int soluongton;

        public SANPHAM()
        {
            masp = "";
            tensp = "";
            giaban = 0;
            soluongton = 0;
        }
        public SANPHAM(string masp, string tensp, double giaban, int soluongton)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.giaban = giaban;
            this.soluongton = soluongton;
        }
        public string getmasp()
        {
            return masp;
        }
        public string gettensp()
        {
            return tensp;
        }
        public double getgiaban()
        {
            return giaban;
        }
        public int getsoluongton()
        {
            return soluongton;
        }
        public void setmasp(string masp)
        {
            this.masp = masp;
        }
        public void settensp(string tensp)
        {
            this.tensp = tensp;
        }
        public void setgiaban(double giaban)
        {
            this.giaban = giaban;
        }
        public void setsoluongton(int soluongton)
        {
            this.soluongton = soluongton;
        }

    }
}
