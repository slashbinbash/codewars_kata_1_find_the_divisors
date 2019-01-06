using System;
using System.Collections.Generic;

namespace kata
{
    public class Kata
    {
        public static int[] Divisors(int n)
        {
            List<int> divisors = new List<int>();

            for (int i = 2; i <= System.Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);

                    if (n / i != i)
                        divisors.Add(n / i);
                }
            }

            divisors.Sort();

            if (divisors.Count == 0)
                return null;
            else
                return divisors.ToArray();
        }
    }
}
