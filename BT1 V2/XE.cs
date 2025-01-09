using static System.Net.Mime.MediaTypeNames;

namespace OOP_3
{
    public class XE
    {
        private string tenchuxe;
        private string tenxe;
        private string loaixe;
        private int dungtich;
        private double giatri;

        public XE(string tenChuXe, string tenXe, string loaiXe, int dungTich, double giaTri)
        {
            tenchuxe = tenChuXe;
            tenxe = tenXe;
            loaixe = loaiXe;
            dungtich = dungTich;
           giatri = giaTri;
        }
        public XE(string tenchuxe, string tenXE, string loaixe, int dungtich)
        {
            this.tenchuxe = " ";
            this.tenxe = " ";
            this.loaixe = " ";
            this.dungtich = 0;
            this.giatri = 0; //Phuong thuc khoi tao khong co tham so
        }
     public void settenchuxe(string tenchuxe)
        {
            this.tenchuxe = tenchuxe;
        }
        public void settenXE(string tenxe)
        {
            this.tenxe = tenxe;
        }
        public void setloaixe(string loaixe)
        {
            this.loaixe = loaixe;
        }
        public void setdungtich(int dungtich)
        {
            this.dungtich = dungtich;
        }
        public void setgiatri(double giatri)
        {
            this.giatri = giatri;
        }
        // Phuong thuc khoi tao co tham so set gia tri cho cac thuoc tinh
        public string gettenchuxe()
        {
            return tenchuxe;
        }
        public string gettenxe()
        {
            return tenxe;
        }
        public string getloaixe()
        {
            return loaixe;
        }
        public int getdungtich()
        {
            return dungtich;
        }
        public double getgiatri()
        {
            return giatri;
        }
        // Phuong thuc get lay gia tri cua cac thuoc tinh
        public double thue()
        {
            double thue = 0;
            
            if (dungtich < 100)
            {
               thue = giatri * 0.01;
                

            }
            else if (dungtich >= 100 && dungtich <= 200)
            {
                thue= giatri * 0.03;
              
            }
           else if (dungtich > 200)
            {
                thue= giatri * 0.05;                   
            }
            return thue;
            // Phuong thuc tinh thue
        }

    }
}
