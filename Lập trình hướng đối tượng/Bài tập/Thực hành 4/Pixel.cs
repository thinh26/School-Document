using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_11
{
    //Lớp cơ sở
    class Pixel
    {
        protected int x;
        protected int y;
        //Phương thức thiết lập
        public Pixel (int x, int y) //Có tham số
        {
            this.x = x; this.y = y;
        }
        public Pixel() //Không tham số
        {
            x = 1; y = 1;
        }
        /*Ban dau 1,2
        public void Print()
        {
            Console.Write("({0},{1})", x, y);
        }*/
        //Đa hình động
        public virtual void Print()
        {
            Console.Write("({0},{1})", x, y);
        }
    }
}
