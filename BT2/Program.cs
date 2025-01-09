using System;
using System.Collections.Generic;

namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts =new Account[2];
            Account tk1 = new Account(121323, "Nguyen Van A", 1000);
            Account tk2 = new Account(121324, "Nguyen Van B", 2000);
            int chon = 0;
            Bank bank = new Bank();
            do
                
            {
                Console.WriteLine("{0,15}","VCB digibank");
                Console.WriteLine("Kinh chao {0}", tk1.gettentk());
                Console.WriteLine("------Menu------");
                Console.WriteLine("1. Them tai khoan");
                Console.WriteLine("2. Xoa tai khoan");
                Console.WriteLine("3. Nap tien");
                Console.WriteLine("4. Rut tien");
                Console.WriteLine("5. Chuyen tien");
                Console.WriteLine("6. Hien Thi Tai Khoan");
                Console.WriteLine("7. Thoat");
                Console.Write("Chon: ");

                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        bank.ThemAccount(new Account);
                        break;

                    case 8:
                       
                        break;


                }



            } while (chon != 7);
            Console.ReadLine();

        }
       
    }
}

