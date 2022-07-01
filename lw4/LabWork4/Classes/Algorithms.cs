using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows;

namespace LabWork4
{
    internal class Algorithms
    {
        public static BigInteger HashImage(string sourceline, BigInteger H0, BigInteger p, BigInteger q) // Hi = (Hi−1 + Mi)^2 mod n,
        {
            BigInteger
                n = BigInteger.Multiply(p, q),
                res = H0;

            for (int i = 0; i < sourceline.Length; i++)
            {
                res = BigInteger.Remainder(BigInteger.Pow(BigInteger.Add(H0, sourceline[i]), 2), n);
                H0 = res;
            }

            return res;
        }

        public static BigInteger OptimalMod(BigInteger a, BigInteger b, BigInteger c) // x = a^b mod c
        {
            BigInteger x = 1;
            while (b != 0)
            {
                while (b % 2 == 0)
                {
                    b = BigInteger.Divide(b, 2);
                    a = BigInteger.Multiply(a, a);
                    a = BigInteger.Remainder(a, c);
                }
                b = BigInteger.Subtract(b, 1);
                x = BigInteger.Multiply(x, a); 
                x = BigInteger.Remainder(x, c);
            }
            return x;
        }

        public static BigInteger RashEucExp(BigInteger EulerFunction, BigInteger e)
        {
            BigInteger
                d0 = EulerFunction,
                x0 = 1,
                y0 = 0,
                d1 = e,
                x1 = 0,
                y1 = 1;

            while (d1 > 1)
            {
                BigInteger 
                    q = d0 / d1,
                    d2 = d0 % d1,
                    x2 = x0 - q * x1,
                    y2 = y0 - q * y1;

                d0 = d1;
                d1 = d2;
                x0 = x1;
                x1 = x2;
                y0 = y1;
                y1 = y2;
            }
            return (y1 < 0) ? BigInteger.Add(y1, EulerFunction) : y1;
        }

        public static bool PrimeCheck(BigInteger number)
        {
            int A = 100;

            if (number <= 100)
                A = (int)number - 1;

            for (int i = 2; i < A; i++)
            {
                BigInteger B = OptimalMod(i, number - 1, number);

                if (B != 1)
                    return false;
            }
            return true;
        }

        public static BigInteger NOD(BigInteger A, BigInteger B) //Greates Common Divisor
        {
            while ((A != 0) && (B != 0))
            {
                if (A > B)
                    A %= B;
                else
                    B %= A;
            }
            return BigInteger.Max(A, B);
        }

        public static bool InputValidation(BigInteger p, BigInteger q, BigInteger Kc, BigInteger eulerFunc)
        {
            if (Kc >= eulerFunc || Kc <= 1)
            {
                MessageBox.Show("Ошибка: Неверный закрытый ключ");
                return false;
            }
            if (Algorithms.NOD(eulerFunc, Kc) != 1)
            {
                MessageBox.Show("Ошибка:Закрытый ключ и функция Эйлера не взаимно простые");
                return false;
            }
            if (!Algorithms.PrimeCheck(p))
            {
                MessageBox.Show("Ошибка: p не простое число");
                return false;
            }
           
            if (!Algorithms.PrimeCheck(q))
            {
                MessageBox.Show("Ошибка: q не простое число");
                return false;
            }                
            return true;
        }
    }
}
