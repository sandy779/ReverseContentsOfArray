using System;

namespace ReverseContentsOfArray
{
    class Reverse
    {
        public void reverse()
        {
            int n;
            int[] x = new int[20];
            int[] y = new int[20];
            Console.WriteLine("Enter array length:");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter array elemetns:");
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = n;
            for (int i = 0; i < n; i++)
            {

                y[j - 1] = x[i];
                j = j - 1;
               

            }    

                Console.WriteLine("Reversed array is:");
                for (int k = 0; k < n; k++)
                {
                    Console.WriteLine(y[k]);

                }
            
        }
        class Program
        {

            static void Main(string[] args)
            {
                Reverse rr = new Reverse();
                rr.reverse();
            }
        }
    }
}
