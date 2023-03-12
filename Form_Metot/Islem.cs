using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Form_Metot
{
    internal class Islem
    {
        public int Topla(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        public int Cikar(int s1, int s2)
        {
            int s3 = s1 - s2;
            return s3;
        }
        public double Bol(double s1, double s2)
        {
            double s3 = s1 / s2;
            return s3;
        }
        public int Carp(int s1, int s2)
        {
            int s3 = s1 * s2;
            return s3;

        }
    }
}
