using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BTTH5
{
    class Program
    {
        static void CircleList()
        {
            Circle_List c = new Circle_List();
            c.Display();
            c.Add();
            c.Sort();
            c.Delete();
            c.Display();
            
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            CircleList();
            Console.ReadKey();
        }
        
}   
}
