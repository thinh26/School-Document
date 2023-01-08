using System;

namespace Bai_tap_tuan_11
{
    class Program
    {
        static void BT4_1()
        {
            /*ban dau 1,2
            Pixel p = new Pixel(9,11);
            p.Print();
            Colored_Pixel cp = new Colored_Pixel();
            cp.Print_Color();
            */
            Pixel p;
            Console.Write("1:Pixel, 2:Colored Pixel: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                p = new Pixel();
                p.Print();
            }
            if(choice == 2)
            {
                p = new Colored_Pixel();
                p.Print();
            }
        }
        static void BT4_2()
        {
            Ve_xe_mot_chieu vx1c = new Ve_xe_mot_chieu();
            vx1c.Gia_ve_mot_chieu();
            vx1c.Xuat();
            Console.WriteLine("");
            Ve_xe_khu_hoi vxkh = new Ve_xe_khu_hoi();
            vxkh.Gia_ve_chieu_di();
            vxkh.Gia_ve_chieu_ve();
            vxkh.Xuat();

            /*Ve_xe_mot_chieu vx1c = new Ve_xe_mot_chieu();
            Ve_xe_khu_hoi vxkh = new Ve_xe_khu_hoi();
            Console.Write("Nhap thong tin ve tau: 1 - Ve xe mot chieu , 2 - Ve xe khu hoi: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Ban da chon: Ve xe mot chieu\n");
                Console.Write("Nhap so xe: ");
                vx1c.so_xe = int.Parse(Console.ReadLine());
                Console.Write("Nhap gio di: ");
                vx1c.gio_di = int.Parse(Console.ReadLine());
                Console.Write("Nhap ngay di: ");
                vx1c.ngay_di = int.Parse(Console.ReadLine());
                Console.Write("Nhap tuyen di: ");
                vx1c.tuyen_di = Console.ReadLine();
                Console.Write("Nhap chieu dai tuyen (km): ");
                vx1c.chieu_dai_tuyen = double.Parse(Console.ReadLine());
                vx1c.Gia_ve_mot_chieu();
                vx1c.Xuat();
            }
            if (choice == 2)
            {

            }*/
        }
        static void BT4_3()
        {
            string ten_hinh = "Tam giac";
            double canh1 = 3, canh2 = 4, canh3 = 5;
            Triangle t = new Triangle(ten_hinh, canh1, canh2, canh3);
            t.chu_vi();
            t.dien_tich();
        }
        static void Main(string[] args)
        {
            //BT4_1();
            BT4_2();
            //BT4_3();
        }
    }
}
