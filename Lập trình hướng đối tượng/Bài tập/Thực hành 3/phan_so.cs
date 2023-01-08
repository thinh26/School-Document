using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTT8
{
    class phan_so
    {
        int ts, ms;

        public phan_so(int t=0, int m =1)
        {
            ts = t; ms = m;
        }
        public phan_so(phan_so p)
        {
            ts = p.ts;
            ms = p.ms;
        }
        //public phan_so()
        public void xuat()
        {
            Console.Write("{0}/{1}", ts, ms);
        }
        //Cộng hai phân số dùng phương thức
        public phan_so Cong(phan_so p)
        {
            phan_so kq = new phan_so();
            kq.ts = this.ts * p.ms + p.ts * this.ms;
            kq.ms = this.ms * p.ms;
            return kq;
        }
        //Cộng hai phân số dùng toán tử
        public static phan_so operator +(phan_so p1, phan_so p2)
        {
            phan_so kq = new phan_so();
            kq.ts = p1.ts * p2.ms + p2.ts * p1.ms;
            kq.ms = p1.ms * p2.ms;
            return kq;
        }
        //Trừ hai phân số dùng toán tử
        public static phan_so operator -(phan_so p1, phan_so p2)
        {
            phan_so kq = new phan_so();
            kq.ts = p1.ts * p2.ms - p2.ts * p1.ms;
            kq.ms = p1.ms * p2.ms;
            return kq;
        }
        //Nhân hai phân số dùng toán tử
        public static phan_so operator *(phan_so p1,phan_so p2)
        {
            phan_so kq = new phan_so();
            kq.ts = p1.ts * p2.ts;
            kq.ms = p1.ms * p2.ms;
            return kq;
        }
        //Chia hai phân số dùng toán tử
        public static phan_so operator /(phan_so p1, phan_so p2)
        {
            phan_so kq = new phan_so();
            kq.ts = p1.ts * p2.ms;
            kq.ms = p1.ms * p2.ts;
            return kq;
        }
        //Ước chung lớn nhất
        int UCLN(int a, int b)
        {
           return (int)BigInteger.GreatestCommonDivisor(a, b);
        }
        //Rút gọn
        public phan_so rut_gon()
        {
            int t = UCLN(ts, ms);
            ts = ts / t;
            ms = ms / t;
            return this;
        }
        
    }
}