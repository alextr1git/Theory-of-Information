using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LabWork4
{
    internal class DigitalSignature
    {
        public static BigInteger createDS(BigInteger p, BigInteger q, BigInteger H0, BigInteger d, string src, out BigInteger m)
        {
            BigInteger r = BigInteger.Multiply(p, q);

            m = Algorithms.HashImage(src, H0, p, q);

            BigInteger S = Algorithms.OptimalMod(m, d, r);

            return S;
        }

        public static bool checkDS(BigInteger p, BigInteger q, BigInteger H0, BigInteger e, BigInteger S, string msg, out BigInteger m, out BigInteger m1)
        {
            BigInteger r = BigInteger.Multiply(p, q);

            m = Algorithms.HashImage(msg, H0, p, q);

            m1 = Algorithms.OptimalMod(S, e, r);

            return BigInteger.Equals(m1, m);
        }
    }
}
