using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTT8
{
    class mon_hoc
    {
        //Các thành phần dữ liệu: mã môn học, tên môn học, số đơn vị học trình, tỷ lệ kiểm tra, điểm kiểm tra, điểm thi.
        string mmh, tmh; int dvht; double tlkt, dkt, dt;

        //Thiết lập không tham số
        public mon_hoc()
        {
            mmh = "ABC123"; tmh = "ABCXYZ"; dvht = 1; tlkt = 100; dt = 10; 
        }
        //Thiết lập có tham số
        public mon_hoc(string a, string b, int c, double d, double e, double f)
        {
            mmh = a; tmh = b; dvht = c; tlkt = d; dkt = e; dt = f;
        }
        //Tính điểm trung bình
        double dtb()
        {
            return tlkt * dkt + (1 - tlkt) * dt;
        }
        //Xuất thông tin môn học
        public void ttmh()
        {
            Console.Write("Ten mon: {0}, Điem kiem tra: {1}, diem thi: {2}, diem trung binh: {3}", tmh, dkt, dt, dtb());
        }
    }
}
