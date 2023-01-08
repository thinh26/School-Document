using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_11
{
    class Shape
    {
        public string ten_hinh { get; set; }
        public Shape(string ten_hinh)
        {
            this.ten_hinh = ten_hinh;
        }
        public double chu_vi()
        {
            return 0;
        }
        public double dien_tich()
        {
            return 0;
        }
        public void Xuat()
        {
            Console.Write("Ten hinh: {0}\tChu vi: {1}\tDien tich: {2}", ten_hinh, chu_vi(), dien_tich());
        }
    }
}
