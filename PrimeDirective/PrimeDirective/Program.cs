using System;

namespace PrimeDirective
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            int c = 0xd0;  //Cipher
            int e = 0x3; // encryption
            int N = 0x457; //modulus 
            double p;
            double q;
            bool isInt = false;
            //Get p and q from N 
            //Get phi(N) = (p-1)(q-1)
            //1<e<phi(n)
            //d = d*e(mod phi(N)) = 1
            //sqrt(0x457) then factor value 
            //sqrt(N) = 21.377
            // N mod sqrt(N) -n (go through all odd numbers) = x
            // if x = 0 then p = 21.337-n
            // primes 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97
            double n, i, m, flag = 0;

            // Credit for prime calculation: https://www.javatpoint.com/prime-number-program-in-csharp
            for (int j = 3; j < N; j++)
            {
                flag = 0;
                //Console.WriteLine(j + "\n");
                // check if number is prime
                n = j;
                m = n / 2;
                for (i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        //Console.Write("Number is not Prime. " + n + "\n");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.Write("Number is Prime. " + n + "\n");
                    q = n;
                    double checkDec = (N / q);
                    isInt = checkDec % 1 == 0;
                    Console.WriteLine(isInt);
                    if(isInt = checkDec % 1 == 0)
                    {
                        p = N/q;

                        Console.WriteLine(p + " " + q);
                        break;
                    }
                }
                    
            }
            //Console.WriteLine(FindFactor(N));


            // FIND P and Q 


            // FIND Phi(N)


            // FIND d


            // Decrypt
            /*

            Console.WriteLine(e.ModInverse(N));
            Console.WriteLine(Math.Sqrt(N));

            //p = 101, q=11


            //double sqrtN = Math.Round(Math.Sqrt(N));
            long srtN = (long) Math.Sqrt(N);
                                   
            int q = e.ModInverse(N);
            int p = N / q;
            Console.WriteLine(p);
            Console.WriteLine(p * q);

          /*  double sqrtN = Math.Sqrt(N);

            for (int i = 0; i < sqrtN; i++)
            {
                int 
            }
            */
        }


    }
   
    public static class IntExtensions
    {
        public static int ModInverse(this int a, int m)
        {
            if (m == 1) return 0;
            int m0 = m;
            (int x, int y) = (1, 0);

            while (a > 1)
            {
                int q = a / m;
                (a, m) = (m, a % m);
                (x, y) = (y, x - q * y);
            }
            return x < 0 ? x + m0 : x;
        }
    }
}
