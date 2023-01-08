using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Student
    {
        string id, name;
        float avg;
        byte num;//số tín chỉ tích lũy
        static byte sum;//tổng số tín chỉ của khóa

      
        public byte Num { get => num; set => num = value; }
        public static byte Sum { get => sum; set => sum = value; }
        public float Avg { get => avg; set => avg = value; }


        //phương thức thiết lập
        public Student(string i="",string na="",float a=0,byte n=0)
        {
            id = i;name = na;avg = a;num = n;sum = 150;
        }
        //xuat thong tin sv
        public void Info()
        {
            Console.Write("{0}\t{1}\t{2}\t{3}", id, name, avg, num);
        }
    }
    //lớp học
    class Course
    {
        string name;
        byte number;
        Student[] ls;//danh sách sinh viên
        //phương thức khởi tạo
        public Course()
        {
            Console.Write("ten lop hoc:");
            name = Console.ReadLine();
            //c1
            do
            {
                Console.Write("si so sv:");
                number = byte.Parse(Console.ReadLine());
            } while (number < 2 || number > 80);
            /*c2
            while ( byte.TryParse (Console.ReadLine (),out number)==false ||number<2||number>80)
            {
                Console.Write("si so sv:");
            }*/
            ls = new Student[number];//khởi tạo mảng Student
            for (int i= 0;i< number; i++)
            {
                Console.Write("nhap ms:");
                string id = Console.ReadLine();
                Console.Write("nhap ho ten:");
                string name = Console.ReadLine();
                Console.Write("nhap diem tbtl:");
                float avg = float.Parse (Console.ReadLine());
                Console.Write("nhap so tctl:");
                byte sotc =byte.Parse ( Console.ReadLine());
                ls[i] = new Student(id,name,avg,sotc);
            }
        }
        //dem so sv
        public byte Count()
        {
            byte c = 0;
            /*c1
            for (int i = 0; i < number; i++)
                if (ls[i].Avg >= 5.5)
                    c++;*/
            //c2
            foreach (Student s in ls)
                if (s.Avg >= 5.5)
                    c++;
            return c;
        }
        //
        public void List_Gra()
        {
            Console.WriteLine("DS SV du dk tot nghiep:");
            for (int i = 0; i < number; i++)
                if (ls[i].Avg >= 5.5 && ls[i].Num >= Student.Sum)
                    ls[i].Info();
        }
        //sap xep
        public void Sort()
        {
            //Student s=new Student ()
        }
    }
}
