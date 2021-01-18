using System;
using System.Collections.Generic;
using System.Text;

namespace buoi6OOP
{
    class thisinhChuyenCup:thiSinh
    {
        private int csdl;
        public thisinhChuyenCup() 
        {
            this.csdl = 0;
        }

        public int Csdl { get => csdl; set => csdl = value; }

        public override void OOPExcersice()
        {
            base.OOPExcersice();
            Console.WriteLine("Thi sinh lam bai thi voi bai thi Tieng anh them");
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
            Console.WriteLine("Moi nhap diem thi CSDL: ");
            csdl = int.Parse(Console.ReadLine());

        }
       public override void Output()
        {
            TongDiem1 = DiemB1 + DiemB2 + DiemB3 + csdl;
            Console.WriteLine("------------------------- Ket qua cua thi sinh {0} ----------------------------",TenTS);
            Console.WriteLine("Diem bai 1:{0} , diem bai 2:{1} , diem bai 3:{2} , diem CSDL:{3} , Tong diem:{4}",DiemB1,DiemB2,DiemB3,csdl,TongDiem1 );
        }
        

    }
}
