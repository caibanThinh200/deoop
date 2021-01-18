using System;
using System.Collections.Generic;
using System.Text;

namespace buoi6OOP
{
    class thiSinh
    {
        private string maTS;
        private string tenTS;
        private int diemB1;
        private int diemB2;
        private int diemB3;
        private int TongDiem;

        public string MaTS { get => maTS; set => maTS = value; }
        public string TenTS { get => tenTS; set => tenTS = value; }
        public int DiemB1 { get => diemB1; set => diemB1 = value; }
        public int DiemB2 { get => diemB2; set => diemB2 = value; }
        public int DiemB3 { get => diemB3; set => diemB3 = value; }
        public int TongDiem1 { get => TongDiem; set => TongDiem = value; }

        public thiSinh()
        {
            this.maTS = "";
            this.tenTS = "";
            this.diemB1 = 0;
            this.diemB2 = 0;
            this.diemB3 = 0;
            this.TongDiem = 0;
        }
        public virtual void OOPExcersice()
        {
            Console.WriteLine("thi sinh lam bai thi");
        }
        public virtual void Input()
        {

        }
        public virtual void Output()
        {

        }
    }
}
