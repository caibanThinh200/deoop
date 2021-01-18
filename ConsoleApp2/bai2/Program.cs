using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            phanso ps1 = new phanso();
            phanso ps2 = new phanso();
            ps1.input();
            ps2.input();
            ps1.output();
            ps2.output();
            phanso ps3 = new phanso();
            ps3.cong(ps1, ps2);
           
            ps3.tru(ps1, ps2);
           
            ps3.nhan(ps1, ps2);
            ps3.chia(ps1, ps2);

        }
    }
}
