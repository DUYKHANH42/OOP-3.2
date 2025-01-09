using OOP_3;
using System;

namespace BT1_V2
{
    public class Program
    {
        private static XE[] dsxe;


        private static void Main(string[] args)
        {

            XE[] dsxe = new XE[3];

            {

                {
                    int chon = 0;
                    do
                    {
                        Console.WriteLine("CHUONG TRINH QUAN LY PHUONG TIEN GIAO THONG");
                        Console.WriteLine("1. Nhap thong tin xe");
                        Console.WriteLine("2. Xuat thong tin xe");
                        Console.WriteLine("3. Thoat");
                        Console.WriteLine("-------------------- ");
                        Console.WriteLine("Moi ban chon: ");
                        chon = int.Parse(Console.ReadLine());
                        switch (chon)
                        {
                            case 1:
                                nhapxe(dsxe);
                                break;
                            case 2:
                                xuatxe(dsxe);
                                break;
                            case 3:
                                Console.WriteLine("Hen gap lai!");
                                break;
                            default:
                                Console.WriteLine("Nhap sai, moi nhap lai: ");
                                break;
                        }

                    } while (chon != 3);

                }
                Console.ReadLine();
            }
        }

        private static void nhapxe(XE[] dsxe)
        {
            for (int i = 0; i < dsxe.Length; i++)
            {
                Console.WriteLine("Nhap thong tin xe thu {0}", i + 1);
                Console.WriteLine("Nhap ten chu xe: ");
                string tenchuxe = (Console.ReadLine());
                Console.WriteLine("Nhap ten xe: ");
                string tenXE = (Console.ReadLine());
                Console.WriteLine("Nhap loai xe: ");
                string loaixe = (Console.ReadLine());
                Console.WriteLine("Nhap dung tich: ");
                int dungtich = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Nhap gia tri: ");
                double giatri = (double.Parse(Console.ReadLine()));
                dsxe[i] = new XE(tenchuxe, tenXE, loaixe, dungtich, giatri);
                
            }

        }
        private static void xuatxe(XE[] dsxe)
        {
            Console.WriteLine("{0,-20}{1,-15}{2,15}{3,15}{4,15} {5,15}"
          , "Ten chu xe", "Ten xe", "Loai xe", "Dung tich", "Gia tri", "Thue ");
            foreach (XE xe in dsxe)
            {
                Console.WriteLine("{0,-20}{1,-15}{2,15}{3,15}{4,15} {5,15}",
                    xe.gettenchuxe(), xe.gettenxe(), xe.getloaixe(), xe.getdungtich(), xe.getgiatri(), xe.thue());
                

            }

        }
    }

}



