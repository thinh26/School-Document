using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_11
{
    //Lớp dẫn xuất
    class Colored_Pixel : Pixel
    {
        int c;
        //Phương thức khởi tạo
        public Colored_Pixel(int x, int y, int c) : base(x, y) //Có tham số
        {
            this.c = c;
        }
        public Colored_Pixel() : base() //Không tham số
        {
            c = 1;
        }
        /*Ban dau 1,2
        public void Print_Color()
        {
            Console.ForegroundColor = (ConsoleColor) c;
            Console.CursorLeft = x;
            Console.CursorTop = y;
            base.Print();
        }*/
        public override void Print()
        {
            Console.ForegroundColor = (ConsoleColor)c;
            Console.CursorLeft = x;
            Console.CursorTop = y;
            base.Print();
        }
    }
}
