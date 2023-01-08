using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_10
{
    class Giao_vien : Cong_nhan_vien
    {
        int so_tiet_giang;
        double thu_lao_1_tiet;
        public Giao_vien(string ms, string ht, string gt, int stg, double tl1t) : base(ms,ht,gt)
        {
            so_tiet_giang = stg;
            thu_lao_1_tiet = tl1t;
        }
        public new double Tien_luong()
        {
            return so_tiet_giang * thu_lao_1_tiet;
        }

    }
}
