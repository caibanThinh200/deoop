using System;
using System.Collections.Generic;

namespace buoi6OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            thisinhChuyenCup tsChuyenCup = new thisinhChuyenCup();
            tsChuyenCup.Input();
            tsChuyenCup.Output();
            Console.WriteLine("---------------------------------------------");
            thisinhChuyen tsChuyen = new thisinhChuyen();
            tsChuyen.Input();
            tsChuyen.Output();
            */
            List<thiSinh> ts = new List<thiSinh>();
            thisinhChuyen tsChuyen;
            thisinhChuyenCup tsChuyenCup;
            string kytu = "";
            Console.WriteLine("Nhap so luong thi sinh n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < n)
            {
                Console.Write("Nhap thi sinh chuyen hay thi sinh sieu cup ? C/S");
                kytu = Convert.ToString(Console.ReadLine());
                kytu = kytu.ToUpper().Trim();
                if (kytu == "C")
                {
                    i++;
                    Console.WriteLine("Thi sinh {0}", i);
                    tsChuyen = new thisinhChuyen();
                    tsChuyen.Input();
                    ts.Add(tsChuyen);
                }
                if (kytu == "S")
                {
                    i++;
                    Console.WriteLine("Thi sinh {0}", i);
                    tsChuyenCup = new thisinhChuyenCup();
                    tsChuyenCup.Input();
                    ts.Add(tsChuyenCup);
                }
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ket qua so luong nhan vien la: {0}", i);
            foreach (thiSinh x in ts)
            {

                x.Output();



            }
            foreach (thiSinh x in ts)
            {

                Console.WriteLine("Ban muon xoa thi sinh nao khong ? hay nhap msts: ");
                string del = Convert.ToString(Console.ReadLine());
                if (del == x.MaTS)
                {
                    ts.Remove(x);
                    Console.WriteLine("Da xoa thi sinh {0} , con lai  {1} thi sinh", x.TenTS, i - 1);
                    break;
                }


            }
        }
    }
}
