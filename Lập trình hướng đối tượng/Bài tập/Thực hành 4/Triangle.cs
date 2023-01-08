using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_11
{
    class Triangle : Shape
    {
        public double canh1 { get; set; }
        public double canh2 { get; set; }
        public double canh3 { get; set; }
        public Triangle(string ten_hinh, double canh1, double canh2, double canh3) : base(ten_hinh)
        {
            this.canh1 = canh1;
            this.canh2 = canh2;
            this.canh3 = canh3;
        }
        public new double chu_vi()
        {
            return canh1 + canh2 + canh3;
        }
        public new double dien_tich()
        {
            double p = chu_vi();
            return Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
        }
        public new void Xuat()
        {
            base.Xuat();
        }
    }
}
