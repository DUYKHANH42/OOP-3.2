using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class Bank
    {
        
       
            private List<Account> accounts; //Danh sach cac tai khoan
            public Bank()
            {
                accounts = new List<Account>();
            }
            public  void ThemAccount(Account account)
            {
                // Kiểm tra xem tài khoản đã tồn tại trong danh sách chưa

                if (accounts.Contains(account))
                {
                    Console.WriteLine("Tai khoan da ton tai");
                }
                else
                {
                    accounts.Add(account);
                    Console.WriteLine("Them tai khoan thanh cong");
                }
            }
            public void XoaAccount(Account account)
            {
                // Kiểm tra xem tài khoản đã tồn tại trong danh sách chưa
                if (accounts.Contains(account))
                {
                    accounts.Remove(account);
                    Console.WriteLine("Xoa tai khoan thanh cong");
                }
                else
                {
                    Console.WriteLine("Tai khoan khong ton tai");
                }
            }
            public void NapTien(Account account, double tien)
            {
                account.napTien(tien);
                Console.WriteLine("Nap tien thanh cong");
            }
            public void RutTien(Account account, double tien)
            {
                if (account.getsodutk() >= tien)
                {
                    account.rutTien(tien);
                    Console.WriteLine("Rut tien thanh cong");
                }
                else
                {
                    Console.WriteLine("So du khong du");
                }
            }
            public void ChuyenTien(Account tk1, Account tk2, double tien)
            {
                if (tk1.getsodutk() >= tien)
                {
                    tk1.rutTien(tien);
                    tk2.napTien(tien);
                    Console.WriteLine("Chuyen tien thanh cong");
                }
                else
                {
                    Console.WriteLine("So du khong du");
                }
            }
            public void XemDanhSach()
            {
                Console.WriteLine("Danh sach tai khoan:");
                Console.WriteLine("{0,-15} {1,-15} {2,-15}",
                    "So tai khoan", "Ten tai khoan", "So du");
                foreach (Account account in accounts)
                {
                    Console.WriteLine("{0,-15} {1,-15} {2,-15}",
                    account.getstk(), account.gettentk(), account.getsodutk());
                }

            }
        }

    
    }
   
