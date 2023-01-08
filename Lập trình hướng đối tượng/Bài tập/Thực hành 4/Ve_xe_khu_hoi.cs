using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_11
{
    internal class Ve_xe_khu_hoi : Ve_xe_mot_chieu
    {
        public int gio_ve { get; set; }
        //Phương thức khởi tạo
        public Ve_xe_khu_hoi() : base() //Không tham số
        {
            gio_ve = 11;
        }
        public Ve_xe_khu_hoi(int so_xe, int gio_di, int gio_ve, int ngay_di, double chieu_dai_tuyen, double gia_san = 100, string tuyen_di = "Nha Trang - Phu Yen") : base(so_xe, gio_di, ngay_di, chieu_dai_tuyen, gia_san, tuyen_di)
        {
            this.gio_ve = gio_ve;
        }
        public double Gia_ve_chieu_di()
        {
            return Gia_ve_mot_chieu();
        }
        public double Gia_ve_chieu_ve()
        {
            return Gia_ve_chieu_di() * 75 / 100;
        }
        public new void Xuat()
        {
            Console.Write("So xe: {0}\tNgay di: {1}\tTuyen di: {2}\tGia ve chieu di: {3}\tGia ve chieu ve: {4}", so_xe, ngay_di, tuyen_di, Gia_ve_chieu_di(), Gia_ve_chieu_ve());
        }
    }
}
