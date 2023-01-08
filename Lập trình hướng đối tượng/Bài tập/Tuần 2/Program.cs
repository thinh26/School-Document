using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("1. Bai tap 1 (nhap/xuat thong tin SV)");
            Console.WriteLine("2. Bai tap 2 (giai va bien luan ptb2)");
            Console.WriteLine("3. Bai tap 3 (kiem tra ky tu nguyen am?)");
            Console.WriteLine("4. Bai tap 4 (thao tac tren mang 1 chieu)");
            do
            {
                Console.Write("Nhap vao bai tap can chay: ");
                num = Int32.Parse(Console.ReadLine());
            } while (num < 1 || num > 4);
            
            switch (num)
            {
                case 1: BaiTap_1(); break;
                case 2: BaiTap_2(); break;
                case 3: BaiTap_3(); break;
                case 4: BaiTap_4(); break;
                default: BaiTap_1(); break;
            }
            Console.ReadKey();
        }
        #region BaiTap_1
        static void BaiTap_1()
        {
            Console.WriteLine();
            Console.Write("Nhap ho ten: ");
            string name = Console.ReadLine();
            Console.Write("Nhap ngay/thang/nam sinh: ");
            DateTime birthday = DateTime.Parse (Console.ReadLine());
            int age = DateTime.Now.Year - birthday.Year;
            Console.WriteLine(name + " - " + age + " tuoi");   
        }
        #endregion
        #region BaiTap_2
        //giai va bien phuong trinh bac 2
        static void BaiTap_2()
        {
            Console.WriteLine();
            Console.Write("Nhap 3 he so a, b, c: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Giai ptb2: {0}x^2 + {1}x + {2} = 0", a, b, c);
            if (a == 0) // pt bac 1
            {
                if (b == 0)
                    if(c==0)                
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                     else                
                        Console.WriteLine("Phuong trinh vo nghiem");                
                else
                {
                    float x = (float)-c / b;
                    Console.WriteLine("Phuong trinh co 1 nghiem duy nhat x = " + x);
                }
            }
            else // pt bac 2
            {
                int delta = b * b - 4 * a * c;
                if (delta < 0)                
                    Console.WriteLine("Phuong trinh vo nghiem");                
                else if (delta == 0)
                {
                    double x = (double)-b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
                }
                else
                {
                    double x1 = (((double)-b + Math.Sqrt(delta)) / (2 * a));
                    double x2 = (((double)-b - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: ");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
        }
        #endregion
        #region BaiTap_3
        static void BaiTap_3()
        {
            Console.WriteLine();
            Console.Write("Nhap vao ky tu: ");
            char c = char.Parse(Console.ReadLine());
            if (!(c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                Console.WriteLine("{0} khong phai la ky tu chu cai!", c);
            else 
            switch (c)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("{0} la ky tu nguyen am!",c);
                    break;
                default:
                    Console.WriteLine("{0} la ky tu phu am!", c);
                    break;
            }
        }
        #endregion
        #region BaiTap_4
        static void BaiTap_4()
        {
            Console.WriteLine();
            int n;
            do
            {
                Console.Write("Nhap so phan tu cua mang: ");
                n = Int32.Parse(Console.ReadLine());
            } while (n < 3 || n > 20);

            float[] arr = new float[n];//cap phat mang

            //Nhap mang so thuc gom n phan tu 
            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]: ",i);
                arr[i] = float.Parse(Console.ReadLine());
            }

            //In ra man hinh cac so trong mang            
            Console.WriteLine("----------------");
            Console.WriteLine("Cac phan tu trong mang");
            //for (int i = 0; i < arr.Length; i++)
            //Console.Write(arr[i] + "\t");
            foreach (float x in arr)
            {
                Console.Write(x + "\t");
            }

            //Dem va in ra so phan tu am trong mang 
            Console.WriteLine();
            Console.WriteLine("----------------");
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("So phan tu am trong mang:  " + count);

        }
        #endregion
    }
}
