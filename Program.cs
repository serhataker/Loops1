using System;
using System.Threading.Channels;
namespace loops1
{
    class loopstudy1
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I trust the myself i success the this software business");//question 1

            }

            for (int i = 1; i < 21; i++) //question 2
            {

                Console.WriteLine($" {i}");
            }

            for (int a = 2; a < 21; a += 2) //question 3
            {

                Console.WriteLine($" {a} ");
            }
            int sum = 50;//question 4

            for (int b = 51; b < 151; b++)
            {

                sum = sum + b;
            }
            Console.WriteLine($"number 50 to 150 sum:{sum}");

            int sum_single = 0;//question 5
            int sum_double = 0;
            for (int c = 1; c < 121;c++)
            {
                if (c % 2 == 0)
                {
                    sum_double=sum_double+c;
                }
                else { 
                sum_single=sum_single+c;
                }

            }
            Console.WriteLine($"number 1 to 120 numbers double sum:{sum_double}");
            Console.WriteLine($"number 1 to 120 numbers single sum:{sum_single}");
        }
    }
}