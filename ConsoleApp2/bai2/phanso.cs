using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class phanso
    {
        private int tuso;
        private int mauso;

        public int Tuso { get => tuso; set => tuso = value; }
        public int Mauso { get => mauso; set => mauso = value; }

        public phanso()
        {
           
        }
        public void input()
        {
            Console.WriteLine("Moi nhap tu so: ");
            Tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap mau so: ");
            Mauso = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("Phan so:{0}/{1}",Tuso,Mauso);
            
        }
        public double UCLN(double a, double b) // tìm uoc chung của tử số và mẫu số
        {
            a = Math.Abs(tuso);
            b = Math.Abs(mauso);
            while (a != b && b != 0 && a != 0)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        public phanso RutGonPhanSo() // rút gọn tử và mẫu
        {
            phanso rutgon = new phanso();
            double uoc = UCLN(tuso, mauso);
            if (uoc != 0)
            {
                rutgon.tuso = (int)(tuso / uoc);
                rutgon.mauso = (int)(mauso / uoc);
            }
            else
            {
                rutgon.tuso = tuso;
                rutgon.mauso = mauso;
            }
            return rutgon;
        }
        public void cong(phanso a,phanso b)
        {
            phanso c = new phanso();
            c.Tuso = a.Tuso * b.mauso + b.tuso * a.mauso;
            c.Mauso = a.Mauso * b.Mauso;
            Console.WriteLine("Phan so:{0}/{1}", c.Tuso, c.Mauso);
        }
        public void tru(phanso a, phanso b)
        {
            phanso c = new phanso();
            c.Tuso = a.Tuso * b.mauso - b.tuso * a.mauso;
            c.Mauso = a.Mauso * b.Mauso;
            Console.WriteLine("Phan so:{0}/{1}", c.Tuso, c.Mauso);
        }
        public void nhan(phanso a, phanso b)
        {
            phanso c = new phanso();
            c.Tuso = a.Tuso * b.Tuso;
            c.Mauso = a.Mauso * b.Mauso;
            Console.WriteLine("Phan so:{0}/{1}", c.Tuso, c.Mauso);
        }
        public void chia(phanso a, phanso b)
        {
            phanso c = new phanso();
            c.Tuso = a.Tuso * b.Mauso;
            c.Mauso = a.Mauso * b.Tuso;
            Console.WriteLine("Phan so:{0}/{1}", c.Tuso, c.Mauso);
        }
    }
}
