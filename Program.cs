using System;

namespace Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дан массив целых чисел. Выяснить:
           а) является ли р-й элемент массива положительным числом;
           б) является ли k-й элемент массива четным числом;
           в) какой элемент массива больше, k-й или р-й.
           */

            Console.WriteLine(" size");
            int size = int.Parse(Console.ReadLine());
            
            if (size <= 0)
            {
                throw new Exception(" number must be positive");
            }
            

            int [] arr = new int [size];

            Console.WriteLine("p");
            int p =int.Parse(Console.ReadLine());

            Console.WriteLine("k");
            int k = int.Parse(Console.ReadLine());

            

                if (p > 0)
                {
                    Console.WriteLine("р положительное число");
                }

                else if (p<0)
                {
                    Console.WriteLine("p отрицательное число");
                }

                else
                {
                    Console.WriteLine(" р равняется нулю");
                }

                if (k % 2 == 0)
                {
                    Console.WriteLine(" k четное число");
                }

                else
                {
                    Console.WriteLine("k нечетное число");
                }

                if ( p > k)
                {
                    Console.WriteLine(" р больше ");

                }

                else if ( p < k)
                {
                    Console.WriteLine(" K больше");
                }

                else
                {
                    Console.WriteLine(" p = k ");
                }

            }

        
    }
}
