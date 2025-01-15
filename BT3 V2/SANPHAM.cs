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
        public string Masp
        {
            set { masp = value; }
            get { return masp; }
        }
        public string Tensp
        {
            set { tensp = value; }
            get { return tensp; }
        }
        public double Giaban
        {
            set { giaban = value; }
            get { return giaban; }
        }
        public int Soluongton
        {
            set { soluongton = value; }
            get { return soluongton; }
        }
       
    }
}
