using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace daQuang
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> listAccount = new List<BankAccount>();
            int i = 0;
            do
            {
                bool checkDN = true;
                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("-- 1. admin                         --");
                Console.WriteLine("-- 2. nguoi dung                    --");
                Console.WriteLine("--------------------------------------\n");
                Thread.Sleep(1000);
                Console.Write("chon chuc nang :");
                i = int.Parse(Console.ReadLine().ToString());
                Console.WriteLine("dang xu ly !!!!");
                Thread.Sleep(3000);
                switch (i)
                {
                    case 1:
                        if (DangNhapAdmin())
                        {
                            Console.WriteLine("dang xu ly !!!!");
                            int checkCNadmin;
                            Thread.Sleep(3000);
                            Console.WriteLine("dang nhap thanh cong !!!!");
                            Thread.Sleep(3000);
                            do
                            {
                                Console.WriteLine("-----------------Menu-----------------");
                                Console.WriteLine("-- 1. Them                          --");
                                Console.WriteLine("-- 2. Xoa                           --");
                                Console.WriteLine("-- 3. Sua                           --");
                                Console.WriteLine("-- 4. Tiem kiem                     --");
                                Console.WriteLine("--------------------------------------\n");
                                Thread.Sleep(3000);
                                Console.Write("chon chuc nang :");
                                checkCNadmin = int.Parse(Console.ReadLine());
                                switch (checkCNadmin)
                                {
                                    case 1:
                                        Them(listAccount);
                                        break;
                                    case 2:
                                        Console.Write("Nhap id can xoa: ");
                                        string idXoa = Console.ReadLine();
                                        Console.WriteLine("dang xu ly !!!!");
                                        Thread.Sleep(3000);
                                        Xoa(listAccount,idXoa);
                                        Thread.Sleep(3000);
                                        break;
                                    case 3:
                                        Console.Write("Nhap id can sua: ");
                                        string idSua = Console.ReadLine();
                                        Console.WriteLine("dang xu ly !!!!");
                                        Thread.Sleep(3000);
                                        Sua(listAccount, idSua);
                                        Thread.Sleep(3000);
                                        break;
                                    case 4:
                                        Console.Write("Nhap id can tim kiem: ");
                                        string idTK = Console.ReadLine();
                                        Console.WriteLine("dang xu ly !!!!");
                                        Thread.Sleep(3000);
                                        TimKiem(listAccount, idTK);
                                        Thread.Sleep(3000);
                                        break;
                                    default:
                                        Console.WriteLine("dang xu ly !!!!");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("Tam biet Admin !!!!");
                                        Thread.Sleep(3000);
                                        break;
                                }

                            } while (checkCNadmin > 0 && checkCNadmin < 5);
                        }
                        else
                        {
                            Console.WriteLine("dang xu ly !!!!");
                            Thread.Sleep(3000);
                            Console.WriteLine("dang nhap khong thanh cong !!!!\n");
                            Thread.Sleep(3000);
                        }
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Tam biet !!!!");
                        Thread.Sleep(2000);
                        break;
                }
            } while (i > 0 && i < 3);
           
            
        }

        static bool DangNhapAdmin()
        {
            string id, pass;
            string checkid = "admin";
            string checkpass = "123";

            Console.WriteLine("=====================================");
            Console.WriteLine("==============Login-Admin============");
            Console.WriteLine("=====================================\n\n");
            Console.WriteLine("Nhap id: ");
            id = Console.ReadLine().ToString();
            Console.WriteLine("Nhap password: ");
            pass = Console.ReadLine().ToString();

            if (id.Equals(checkid) && pass.Equals(checkpass))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        static bool DangNhap(List<BankAccount> list)
        {
            int check = 0;
            string id, pass;
            do
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("===============L-O-G-I-N=============");
                Console.WriteLine("=====================================\n\n");
                Console.WriteLine("Nhap id: ");
                id = Console.ReadLine().ToString();
                Console.WriteLine("Nhap password: ");
                pass = Console.ReadLine().ToString();

                foreach(BankAccount AC in list)
                {
                    if (id.Equals(AC.ID) && pass.Equals(AC.Password))
                    {
                        return true;
                    }
                }
                Console.WriteLine("ID hoac password sai vui long nhap lai!!!");
                check++;
            } while (check > 0 && check < 4);

            return false;

        }

        static void Them(List<BankAccount> list)
        {
            BankAccount AC = new BankAccount();
            int y = 0;

            Console.Write("Nhap id :");
            string checkID = Console.ReadLine().ToString();
            foreach (BankAccount check in list)
            {
                if (check.ID.Equals(checkID))
                {
                    Console.WriteLine("ID {0} da ton tai!!!", check.ID);
                    y = 1;
                    break;
                }
            }
            if (y == 0)
            {
                AC.ID = checkID;
                Console.Write("\nNhap password :");
                AC.Password = Console.ReadLine().ToString();
                Console.Write("\nNhap Ten chu the :");
                AC.TenTK = Console.ReadLine().ToString();
                Console.Write("\nNhap loai tien :");
                AC.LoaiTien = Console.ReadLine().ToString();
                Console.Write("\nNhap so du :");
                AC.SoDu = double.Parse(Console.ReadLine().ToString());

                list.Add(AC);
                Console.WriteLine("ID {0} da duoc them thanh cong!!!", checkID);
            }
        }

        static void Xoa(List<BankAccount> list,string id)
        {
            foreach(BankAccount check in list)
            {
                if (check.ID.Equals(id))
                {
                    list.Remove(check);
                    Console.WriteLine("ID {0} da duoc xoa thanh cong!!!", id);

                    return;
                }
            }
            Console.WriteLine("ID {0} Khong ton tai!!!", id);
        }

        static void Sua(List<BankAccount> list, string id)
        {
            int i = 0 ;
            foreach (BankAccount check in list)
            {
                if (check.ID.Equals(id))
                {
                    list.Remove(check);
                    BankAccount AC = new BankAccount();

                    AC.ID = id;
                    Console.Write("\nNhap password :");
                    AC.Password = Console.ReadLine().ToString();
                    Console.Write("\nNhap Ten chu the :");
                    AC.TenTK = Console.ReadLine().ToString();
                    Console.Write("\nNhap loai tien :");
                    AC.LoaiTien = Console.ReadLine().ToString();
                    Console.Write("\nNhap so du :");
                    AC.SoDu = double.Parse(Console.ReadLine().ToString());

                    list.Insert(i,AC);
                    Console.WriteLine("ID {0} da duoc sua thanh cong!!!", id);

                    return;
                }
                i++;
            }
            Console.WriteLine("ID {0} Khong ton tai!!!", id);
            
        }

        static void TimKiem(List<BankAccount> list, string id)
        {
            foreach (BankAccount check in list)
            {
                if (check.ID.Equals(id))
                {
                    Console.WriteLine("ID {0} da duoc tim thay!!!", id);
                    Thread.Sleep(3000);
                    check.toString();
                    return;
                }
            }
            Console.WriteLine("ID {0} Khong ton tai!!!", id);

        }
    }
}
