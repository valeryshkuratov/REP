using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int NOD(int m, int n)
        {
            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }
            return m;

        }

        //какие-то изменения
        /*public static int NOK(int m, int n)
        {
            int i;
            i = (m * n) / NOD(m, n);
            return i;
        }*/

        public static string simpleNum(int m)
        {
            int k = 0;
            for (int i=1; i<m; i++)
            {
                if (m % i == 0)
                    k++;
            }
            if (k > 1 || m==1)
                return "Число составное";
            else
                return "Число простое (изм1)";
        }
    }
}
