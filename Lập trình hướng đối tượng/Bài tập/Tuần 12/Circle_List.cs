using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BTTH5
{
    class Circle_List
    {
        List<Circle> ls = new List<Circle>();
        FileStream f = new FileStream("C:\\Study\\Lập Trình Hướng Đối Tượng\\BTTH5\\test.txt", FileMode.Open);
        int n;
        StreamReader sr;
        public Circle_List()
        {
            sr = new StreamReader(f);
            Console.WriteLine("Mời bạn nhập vào số hình tròn");
            n = int.Parse(sr.ReadLine()); 
            // Nhập thông tin cho các hình tròn
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Mời bạn nhập bán kính hình tròn thứ {0}", i + 1);
                float r = float.Parse(sr.ReadLine());
                ls.Add(new Circle(r));
            }
        }
        public void Display()
        {
            //Hiển thị
            foreach (Circle s in ls)
            {
                s.Display();
            }
        }
         public void Add()
        {
            //Thêm hình tròn
            Console.WriteLine("Mời bạn nhập thêm vị trí cần thêm hình tròn");
            int pos = int.Parse(sr.ReadLine());
            if (pos < 0) pos = 0;
            if (pos > n) pos = n;
            Console.WriteLine("Mời bạn nhập vào bán kính của hình muốn chèn");
            float r1 = float.Parse(sr.ReadLine());
            ls.Insert(pos, new Circle(r1));
        }
        public void Sort()
        {
            //Sắp xếp tăng dần,cách 1 sử dụng toán tử
            for (int i = 0; i < ls.Count; i++)
            {
                for (int j = i + 1; j < ls.Count; j++)
                    if (ls[i] > ls[j])
                    {
                        Circle c = new Circle();
                        c = ls[i];
                        ls[i] = ls[j];
                        ls[j] = c;
                    }
            }
            //Sắp xếp cách 2, sử dung Interface so sánh
            ls.Sort();
        }
        public void Delete()
        {
            Console.WriteLine("Nhập diện tích cần xóa");
            float dt = float.Parse(sr.ReadLine());
            //xóa, cách 1
            //foreach (Circle s in ls)
            //{
            //    if(s.Dientich()==dt)
            //    ls.Remove(s);
            //}
            // Xóa, cách 2
            for (int i = 0; i < ls.Count; ++i)
            {
                if (ls[i].Dientich() == dt)
                {
                    ls.RemoveAt(i);
                }
            }

        }
    }
}
