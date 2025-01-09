using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XE xe1 = new XE();
            Console.WriteLine("Nhap ten chu xe: ");
            xe1.settenchuxe(Console.ReadLine());
            Console.WriteLine("Nhap ten xe: ");
            xe1.settenXE(Console.ReadLine());
           Console.WriteLine("Nhap loai xe: ");
            xe1.setloaixe(Console.ReadLine());
            Console.WriteLine("Nhap dung tich: ");
            xe1.setdungtich(int.Parse(Console.ReadLine()));
            Console.WriteLine("Nhap gia tri: ");
            xe1.setgiatri(double.Parse(Console.ReadLine()));
            Console.WriteLine("Thue: " + xe1.thue());
            Console.WriteLine("Ten chu xe: {0} \n Ten xe: {1} \n Loai xe: {2} \n Dung tich: {3} \n Gia tri: {4} \n Thue cua xe: {5}"
                ,xe1.gettenchuxe(),xe1.gettenxe(),xe1.getloaixe(),xe1.getdungtich(),xe1.getgiatri(),xe1.thue() );
            // Thong Tin xe thu nhat
            Console.WriteLine("----------------------------------------");
            XE xe2 = new XE();
            xe2.settenchuxe("Le Minh Tin");
            xe2.settenXE("Ford Ranger");
            xe2.setloaixe("Ban Tai");
            xe2.setdungtich(3000);
            xe2.setgiatri(1000000000);
            xe2.thue();
            Console.WriteLine("Ten chu xe: {0} \n Ten xe: {1} \n Loai xe: {2} \n Dung tich: {3} \n Gia tri: {4} \n Thue cua xe: {5}"
               , xe2.gettenchuxe(), xe2.gettenxe(), xe2.getloaixe(), xe2.getdungtich(), xe2.getgiatri(), xe2.thue());
            // Thong Tin xe thu hai
            Console.WriteLine("----------------------------------------");
            XE xe3 = new XE();
            xe3.settenchuxe("Nguyen Minh Triet");
            xe3.settenXE("Landscape");
            xe3.setloaixe("O to");
            xe3.setdungtich(150);
            xe3.setgiatri(200000000);
            xe3.thue();
            Console.WriteLine("Ten chu xe: {0} \n Ten xe: {1} \n Loai xe: {2} \n Dung tich: {3} \n Gia tri: {4} \n Thue cua xe: {5}"
               , xe3.gettenchuxe(), xe3.gettenxe(), xe3.getloaixe(), xe3.getdungtich(), xe3.getgiatri(), xe3.thue());
            // Thong Tin xe thu ba
            Console.ReadKey();
        }
    }
}
