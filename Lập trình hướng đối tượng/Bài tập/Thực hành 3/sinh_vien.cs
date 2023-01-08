using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTT8
{
    class sinh_vien
    {
        mon_hoc[] mh;
        //Các thuộc tính: mã số sinh viên, họ tên, danh sách các môn học trong một học kỳ của sinh viên
        int mssv; string ho_ten;
        //Khởi tạo không tham số
        public sinh_vien()
        {
            mssv = 62131111; ho_ten = "Nguyen Van A";
        }
        //Khởi tạo có tham số
        public sinh_vien(int a, string b)
        {
            mssv = a;
            ho_ten = b;
        }
        //Nhập số lượng môn học và các môn học
        int amount;
        public int so_luong(int a) { amount = a; return amount; }
        public void nhap_mon_hoc()
        {
            mh = new mon_hoc[so_luong(amount)];
            for(int i=0;i<so_luong(amount); i++)
            {
                Console.Write("\nNhap ma mon hoc thu {0}: ", i + 1);
                string mmh = Console.ReadLine();
                Console.Write("Nhap ten mon hoc thu {0}: ", i + 1);
                string tmh = Console.ReadLine();
                Console.Write("Nhap so don vi hoc trinh (so tin chi) cua mon hoc thu {0}: ", i + 1);
                int dvht = int.Parse(Console.ReadLine());
                Console.Write("Nhap ty le kiem tra cua mon hoc thu {0}: ",i+ 1);
                double tlkt = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem kiem tra cua mon hoc thu {0}: ", i + 1);
                double dkt =double.Parse(Console.ReadLine());
                Console.Write("Nhap diem thi cua mon hoc thu {0}: ",i+1);
                double dt = double.Parse(Console.ReadLine());
                mh[i] = new mon_hoc(mmh, tmh, dvht, tlkt, dkt, dt);
            }
        }
        public void in_mon_hoc()
        {
            mon_hoc mh = new mon_hoc[so_luong(amount)];
            for (int i = 0; i < so_luong(amount) ; i++)
            {
                mh[i].ttmh();
            }
        }
    }
}