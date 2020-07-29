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
            file_IO file = new file_IO();
            file.DocFile(listAccount);
            int i = 0;
            do
            {
                Console.WriteLine("-----------------Menu-----------------");
                Console.WriteLine("-- 1. admin                         --");
                Console.WriteLine("-- 2. nguoi dung                    --");
                Console.WriteLine("-- 3. luu file                      --");
                Console.WriteLine("-- 4. Thoat                         --");
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
                                Console.WriteLine("-- 5. Thoat                         --");
                                Console.WriteLine("--------------------------------------\n");
                                Thread.Sleep(1000);
                                Console.Write("chon chuc nang :");
                                checkCNadmin = int.Parse(Console.ReadLine());
                                Console.WriteLine("dang xu ly !!!!");
                                Thread.Sleep(3000);
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
                                        Xoa(listAccount, idXoa);
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
                                    case 5:
                                        Console.WriteLine("Tam biet Admin !!!!");
                                        Thread.Sleep(2000);
                                        break;
                                    default:
                                        Console.WriteLine("Nhap sai chuc nang !!!!");
                                        Thread.Sleep(2000);
                                        break;
                                }
                            } while (checkCNadmin != 5);
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
                        string id = DangNhap(listAccount);
                        if (!id.Equals(""))
                        {
                            Console.WriteLine("dang xu ly !!!!");
                            int checkCN;
                            Thread.Sleep(3000);
                            Console.WriteLine("dang nhap thanh cong !!!!");
                            Thread.Sleep(3000);
                            do
                            {
                                Console.WriteLine("-----------------Menu-----------------");
                                Console.WriteLine("-- 1. Rut tien                      --");
                                Console.WriteLine("-- 2. Chuyen tien                   --");
                                Console.WriteLine("-- 3. Xem so du                     --");
                                Console.WriteLine("-- 4. Thoat                         --");
                                Console.WriteLine("--------------------------------------\n");
                                Thread.Sleep(1000);
                                Console.Write("chon chuc nang :");
                                checkCN = int.Parse(Console.ReadLine());
                                Console.WriteLine("dang xu ly !!!!");
                                Thread.Sleep(3000);
                                switch (checkCN)
                                {
                                    case 1:
                                        int check = 0;
                                        Console.Write("Nhap so tien can rut: ");
                                        double mnRut = double.Parse(Console.ReadLine());
                                        Console.WriteLine("dang xu ly !!!!");
                                        Thread.Sleep(3000);
                                        foreach (BankAccount AC in listAccount)
                                        {
                                            if (AC.ID.Equals(id))
                                            {
                                                if (AC.SoDu > mnRut)
                                                {
                                                    AC.SoDu -= mnRut;
                                                    check = 1;
                                                    Console.WriteLine("Rut tien thanh cong !!!");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("So du khong du de thuc hien !!!");
                                                    Thread.Sleep(3000);
                                                }
                                            }
                                        }
                                        if (check == 0) Console.WriteLine("Rut tien khong thanh cong !!!");
                                        Thread.Sleep(3000);
                                        break;
                                    case 2:
                                        int checkCh = 0;
                                        Console.Write("Nhap so tien can chuyen: ");
                                        double mnCh = double.Parse(Console.ReadLine());
                                        Console.WriteLine("dang xu ly !!!!");
                                        Thread.Sleep(3000);
                                        foreach (BankAccount AC in listAccount)
                                        {
                                            if (AC.ID.Equals(id))
                                            {
                                                if (AC.SoDu > mnCh)
                                                {
                                                    AC.SoDu -= mnCh;
                                                    checkCh = 1;
                                                    Console.WriteLine("Chuyen tien thanh cong !!!");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("So du khong du de thuc hien !!!");
                                                    Thread.Sleep(3000);
                                                }
                                            }
                                        }
                                        if (checkCh == 0) Console.WriteLine("Chuyen tien khong thanh cong !!!");
                                        Thread.Sleep(3000);
                                        break;
                                    case 3:
                                        Console.WriteLine("dang xu ly !!!!");
                                        Thread.Sleep(3000);
                                        foreach (BankAccount AC in listAccount)
                                        {
                                            if (AC.ID.Equals(id))
                                            {
                                                Console.WriteLine("So du cua ban la : {0}", AC.SoDu);
                                                break;
                                            }
                                        }
                                        Thread.Sleep(3000);
                                        break;
                                    case 4:
                                        Console.WriteLine("Tam biet !!!!");
                                        Thread.Sleep(2000);
                                        break;
                                    default:
                                        Console.WriteLine("Nhap sai chuc nang !!!!");
                                        Thread.Sleep(2000);
                                        break;
                                }
                            } while (checkCN != 4);
                        }
                        else
                        {
                            Console.WriteLine("dang xu ly !!!!");
                            Thread.Sleep(3000);
                            Console.WriteLine("dang nhap khong thanh cong !!!!\n");
                            Thread.Sleep(3000);
                        }
                        break;
                    case 3:
                        file.GhiFile(listAccount);
                        break;
                    case 4:
                        Console.WriteLine("Tam biet !!!!");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("Nhap sai chuc nang !!!!");
                        Thread.Sleep(2000);
                        break;
                }
            } while (i != 4);
           
            
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

        static string DangNhap(List<BankAccount> list)
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
                        return AC.ID;
                    }
                }
                Console.WriteLine("ID hoac password sai vui long nhap lai!!!");
                check++;
            } while (check > 0 && check < 4);

            return "";

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
                Console.Write("Nhap password :");
                AC.Password = Console.ReadLine().ToString();
                Console.Write("Nhap Ten chu the :");
                AC.TenTK = Console.ReadLine().ToString();
                Console.Write("Nhap loai tien :");
                AC.LoaiTien = Console.ReadLine().ToString();
                Console.Write("Nhap so du :");
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
            foreach (BankAccount AC in list)
            {
                if (AC.ID.Equals(id))
                {
                    AC.ID = id;
                    Console.Write("\nNhap password :");
                    AC.Password = Console.ReadLine().ToString();
                    Console.Write("\nNhap Ten chu the :");
                    AC.TenTK = Console.ReadLine().ToString();
                    Console.Write("\nNhap loai tien :");
                    AC.LoaiTien = Console.ReadLine().ToString();
                    Console.Write("\nNhap so du :");
                    AC.SoDu = double.Parse(Console.ReadLine().ToString());
                    
                    Console.WriteLine("ID {0} da duoc sua thanh cong!!!", id);

                    return;
                }
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
                    Console.WriteLine(check.toString());
                    return;
                }
            }
            Console.WriteLine("ID {0} Khong ton tai!!!", id);

        }
        
    }
}
