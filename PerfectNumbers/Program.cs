using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 100000000; i++)
        {
            BigInteger num = new BigInteger(Math.Pow(2, i));
            bool gotOne = false;
            if (i >= 5)
            {
                for (double j = 0; j < i; j++)
                {
                    BigInteger sumnumbers = SumNumbers(Math.Pow(2, j));
                    if (sumnumbers > num)
                    {
                        BigInteger gotted = SumNumbers(Math.Pow(2, j) - 1);
                        if (gotted < num)
                        {
                            Console.WriteLine(num);
                            Console.WriteLine(gotted);
                            gotOne = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (gotOne) { break; }
                }
            }
        }
    }

    static BigInteger SumNumbers(double n)
    {
        BigInteger sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}

