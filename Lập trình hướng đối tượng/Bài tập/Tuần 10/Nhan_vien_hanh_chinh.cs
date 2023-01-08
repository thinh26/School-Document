using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_10
{
    class Nhan_vien_hanh_chinh : Cong_nhan_vien
    {
        int so_ngay_cong;
        double luong_thang;
        public Nhan_vien_hanh_chinh(string ms, string ht, string gt, int snc, double lt) : base(ms, ht, gt)
        {
            so_ngay_cong = snc;
            luong_thang = lt;
        }
        public new double Tien_luong()
        {
            return (so_ngay_cong * luong_thang) / 26;
        }
    }
}
