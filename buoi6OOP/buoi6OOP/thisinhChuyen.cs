using System;
using System.Collections.Generic;
using System.Text;

namespace buoi6OOP
{
    class thisinhChuyen:thiSinh
    {
        private int diemTA;
        public thisinhChuyen()
        {
            this.diemTA = 0;
        }

        public int DiemTA { get => diemTA; set => diemTA = value; }

        public override void OOPExcersice()
        {
            base.OOPExcersice();
            Console.WriteLine("Thi sinh lam bi mon CSDL");
        }
        public override void Input()
        {
            Console.WriteLine("Moi nhap MSTS: ");
            MaTS = Console.ReadLine();
            Console.WriteLine("Moi nhap ten thi sinh: ");
            TenTS = Console.ReadLine();
            Console.WriteLine("Diem thi bai 1: ");
            DiemB1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem thi bai 2: ");
            DiemB2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem thi bai 3: ");
            DiemB3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap diem thi mon TA: ");
            diemTA = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            if(diemTA>= 7 || diemTA <= 8)
            {
                diemTA = 1;
            }
            if (diemTA >= 9 || diemTA <= 10)
            {
                diemTA = 2;
            }
            else diemTA = 0;
            TongDiem1 = DiemB1 + DiemB2 + DiemB3 + diemTA;
            Console.WriteLine("------------------------- Ket qua cua thi sinh {0} ----------------------------", TenTS);
            Console.WriteLine("Diem bai 1:{0} , diem bai 2:{1} , diem bai 3:{2} , diem CSDL:{3} , Tong diem:{4}", DiemB1, DiemB2, DiemB3, diemTA, TongDiem1);
        }
    }
}
