using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH5
{
    interface IShape
    {
        string Name { get; set; }
        float Chuvi();
        float Dientich();
    }
    class Circle : IShape  ,IComparable<Circle>
    {
        string name;
        float r;
        public string Name { get => name; set => name = value; }
        public Circle(float r=1,string name = "Circle")
        {
            this.name = name;
            this.r = r;     
        }
        public float Chuvi()
        {
            return r * 3.14f * 2;
        }
        public float Dientich()
        {
            return r * r * 3.14f;
        }
        public void Display()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", name, r, Chuvi(), Dientich());
        }
        public static bool operator > (Circle c1,Circle c2)
        {
            return c1.Chuvi() > c2.Chuvi();
        }
        public static bool operator <(Circle c1, Circle c2)
        {
            return c1.Chuvi() < c2.Chuvi();
        }
        public int CompareTo(Circle c)
        {
            if (Chuvi() > c.Chuvi()) return 1;
            if (Chuvi() == c.Chuvi()) return 0;
            return -1;
        }

    }
}
