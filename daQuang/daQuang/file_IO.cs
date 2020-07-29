using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daQuang
{
    class file_IO
    {
        public void DocFile(List<BankAccount> list)
        {
            if (File.Exists(@"D:\\BankAccount.txt"))
            {
                string[] lines = File.ReadAllLines(@"D:\\BankAccount.txt");
                for (int i = 0; i < lines.Length; i += 5)
                {
                    BankAccount AC = new BankAccount();

                    AC.ID = lines[i];
                    AC.Password = lines[i + 1];
                    AC.TenTK = lines[i + 2];
                    AC.LoaiTien = lines[i + 3];
                    AC.SoDu = int.Parse(lines[i + 4]);

                    list.Add(AC);
                }
            }
        }
        public void GhiFile(List<BankAccount> list)
        {
            if (File.Exists("D:\\BankAccount.txt"))
            {
                FileStream fs = new FileStream("D:\\BankAccount.txt", FileMode.Truncate, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (BankAccount AC in list)
                {
                    sWriter.WriteLine(AC.ID);
                    sWriter.WriteLine(AC.Password);
                    sWriter.WriteLine(AC.TenTK);
                    sWriter.WriteLine(AC.LoaiTien);
                    sWriter.WriteLine(AC.SoDu);
                }
                sWriter.Flush();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("D:\\BankAccount.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                foreach (BankAccount AC in list)
                {
                    sWriter.WriteLine(AC.ID);
                    sWriter.WriteLine(AC.Password);
                    sWriter.WriteLine(AC.TenTK);
                    sWriter.WriteLine(AC.LoaiTien);
                    sWriter.WriteLine(AC.SoDu);
                }
                sWriter.Flush();
                fs.Close();
            }
        }
            
    }
}
