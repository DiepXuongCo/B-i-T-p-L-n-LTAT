using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerConn
{
    class Class1
    {
        public int p, q, n, e, d, phi_n,nk ;

        public int soNgauNhien()
        {
            Random rd = new Random();
            return rd.Next(11, 101);
        }

        public bool kiemTraNguyenTo(int i)
        {
            bool kiemtra = true;
            for (int j = 2; j < i; j++)
                if (i % j == 0)
                    kiemtra = false;
            return kiemtra;
        }

        public bool nguyenToCungNhau(int a, int b)
        {
            bool kiemtra = true;
            for (int i = 2; i < a; i++)
                if (a % i == 0 && b % i == 0)
                    kiemtra = false;
            return kiemtra;
        }

        public void taoKhoa()
        {
            //Tạo hai số nguyên tố ngẫu nhine6 khác nhau
            do
            {
                p = soNgauNhien();
                q = soNgauNhien();
            }
            while (p == q || !kiemTraNguyenTo(p) || !kiemTraNguyenTo(q));



            //Tinh n=p*q
            n = p * q;


            //Tính Phi(n)=(p-1)*(q-1)
            phi_n = (p - 1) * (q - 1);


            //Tính e là một số ngẫu nhiên có giá trị 0< e <phi(n) và là số nguyên tố cùng nhau với Phi(n)
            do
            {
                Random rd = new Random();
                e = rd.Next(2, phi_n);
            }
            while (!nguyenToCungNhau(e, phi_n));


            //Tính d
            d = 0;
            int i = 2;
            while (((1 + i * phi_n) % e) != 0 || d <= 0)
            {
                i++;
                d = (1 + i * phi_n) / e;
            }

        }

        public int tinhMod(int m, int e, int n)
        {
            int kq;
            kq = m % n;
            for (int i = 1; i < e; i++)
            {
                kq = (kq * m) % n;
            }
            return kq;
        }

        public string maHoa(string s)
        {
            char[] str = s.ToArray();
            string s2 = null;
            for (int i = 0; i < s.Length; i++)
            {
                int a = (int)str[i];
                int b = tinhMod(a, e, n);
                //long b = tinhMod(35, 7, 943);
                s2 = s2 + " " + b;
            }
            return s2;
        }

        public string giaima(string s)
        {
            string s3 = null;

            char[] str = s.ToArray();
            int dem = 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (str[i] == ' ')
                {
                    dem++;
                }
            }
            int a = 0;
            string[] s2 = s.Split(' ');
            // a = long.Parse(s2[0]);
            int b = 0;
            b = tinhMod(a, d, nk);
            // b = tinhMod(545,503,943);
            for (int j = 0; j < dem; j++)
            {
                a = tinhMod(int.Parse(s2[j]), d, nk);
                s3 = s3 + " " + a;
            }
            return s3;
        }
    }
}
