using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [10];
            Random random = new Random();

            for (int i=0; i<10;i++)
            {
                array[i] = random.Next(-50,50);
                Console.Write("{0} ", array[i]);
            }
            for (int i=0;i<4;i++)
            {
                for (int j=i+1;j<5;j++)
                {
                    int t = array[i];
                    if (array[i]>array[j])
                    {
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (int i = 4; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    int t = array[i];
                    if (array[i] < array[j])
                    {
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0;i<5;i++)
            {
                Console.Write("{0} ", array[i]);
            }
            for (int i = 5; i <10; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
