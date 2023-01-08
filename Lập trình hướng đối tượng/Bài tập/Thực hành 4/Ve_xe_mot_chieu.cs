using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_11
{
    class Ve_xe_mot_chieu
    {
        /*protected int so_xe, gio_di, ngay_di;
        protected double chieu_dai_tuyen, gia_san;
        protected string tuyen_di;*/
        public int so_xe { get; set; }
        public int gio_di { get; set; }
        public int ngay_di { get; set; }
        public double chieu_dai_tuyen { get; set; }
        public double gia_san { get; set; }
        public string tuyen_di { get; set; }
        //Phuơng thức khởi tạo
        public Ve_xe_mot_chieu() //Không tham số
        {
            so_xe = 1;
            gio_di = 7;
            ngay_di = 8;
            chieu_dai_tuyen = 145;
            gia_san = 100;
            tuyen_di = "Nha Trang - Phu Yen";
        }
        public Ve_xe_mot_chieu(int so_xe, int gio_di, int ngay_di, double chieu_dai_tuyen, double gia_san = 100, string tuyen_di = "Nha Trang - Phu Yen") //Có tham số
        {
            this.so_xe = so_xe;
            this.ngay_di = ngay_di;
            this.gio_di = gio_di;
            this.chieu_dai_tuyen = chieu_dai_tuyen;
        }
        public double Gia_ve_mot_chieu()
        {

            if (chieu_dai_tuyen < 100)
                return gia_san;
            else if (chieu_dai_tuyen >= 100 || chieu_dai_tuyen <= 150)
                return gia_san * 1.3;
            else if (chieu_dai_tuyen > 150)
                return gia_san * 1.5;
        }
        public void Xuat()
        {
            Console.Write("So xe: {0}\tNgay di: {1}\tTuyen di: {2}\tGia ve: {3}",so_xe,ngay_di,tuyen_di,Gia_ve_mot_chieu());
        }

    }
}
