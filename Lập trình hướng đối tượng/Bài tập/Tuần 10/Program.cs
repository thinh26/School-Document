using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string ms, ht, gt; //ma so, ho ten, gioi tinh
            int snc, stg; double lt, tl1t; // so ngay cong, so tiet giang, luong thang, thu lao 1 tiet
            int chuc_vu = 0;
            Cong_nhan_vien[] ds;
            //tao mang
            int i = 0;
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            ds = new Cong_nhan_vien[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Nhap chuc vu (1 neu Nhan vien hanh chinh; 2 neu Giao vien): ");
                chuc_vu = int.Parse(Console.ReadLine());
                if (chuc_vu == 1)
                {
                    Console.Write("Nhap ma so: ");
                    ms = Console.ReadLine();
                    Console.Write("Nhap ho ten: ");
                    ht = Console.ReadLine();
                    Console.Write("Nhap gioi tinh: ");
                    gt = Console.ReadLine();
                    Console.Write("Nhap so ngay cong: ");
                    snc = int.Parse(Console.ReadLine());
                    Console.Write("Nhap luong thang: ");
                    lt = double.Parse(Console.ReadLine());
                    ds[i] = new Nhan_vien_hanh_chinh(ms, ht, gt, snc, lt);
                }
                if (chuc_vu == 2)
                {
                    Console.Write("Nhap ma so: ");
                    ms = Console.ReadLine();
                    Console.Write("Nhap ho ten: ");
                    ht = Console.ReadLine();
                    Console.Write("Nhap gioi tinh: ");
                    gt = Console.ReadLine();
                    Console.Write("Nhap so tiet giang: ");
                    stg = int.Parse(Console.ReadLine());
                    Console.Write("Nhap thu lao 1 tiet: ");
                    tl1t = double.Parse(Console.ReadLine());
                    ds[i] = new Giao_vien(ms, ht, gt, stg, tl1t);
                }
            }
            Nhan_vien_hanh_chinh[] NVHC = new Nhan_vien_hanh_chinh(ms, ht, gt, snc, lt) : base(ms, ht, gt);
            Giao_vien[] GV;
                for (i = 0; i < n; i++)
                {
                    if (chuc_vu == 1)
                        NVHC[i].Tien_luong();
                    if (chuc_vu == 2)
                        GV[i].Tien_luong();
                }
        }
    }
}