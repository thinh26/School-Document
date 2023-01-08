using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_10
{
    class Cong_nhan_vien
    {
        string ma_so, ho_ten, gioi_tinh;
        public Cong_nhan_vien(string ms,string ht,string gt)
        {
            ma_so = ms;
            ho_ten = ht;
            gioi_tinh = gt;
        }
        public double Tien_luong()
        {
            return 0; //Khi chưa có tính tiền lương của ai
        }
        public void Xuat()
        {
            Console.Write("{0}\t{1}\t{2}", ma_so, ho_ten, Tien_luong());
        }
        
    }
}
