using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimentionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2}, { 4, 5} };
            Console.WriteLine("Multi to single");
            TwotoOne(a);
            Console.WriteLine();

            int[] ar = new int[] { 1, 2, 3, 4};
            Console.WriteLine("Single to multi");
            OnetoTwo(ar, 2, 2);

            Console.WriteLine();
            FindAngle(9, 30);
        }

        public static void TwotoOne(int[,] a)
        {
            int index = 0;
            int width = a.GetLength(0);
            int heigth = a.GetLength(1);

            int[] single = new int[width * heigth];

            for(int i=0; i<heigth; i++)
            {
                for(int j=0; j<width; j++)
                {
                    single[index] = a[i, j];
                    Console.Write(single[index] + " ");
                    index++;
                }
            }
        }


        public static void OnetoTwo(int[] a, int row, int column)
        {
            int index = 0;
            int[,] multi = new int[row, column];

            for(int i=0; i<row; i++)
            {
                for(int j=0; j<column; j++)
                {
                    multi[i, j] = a[index];
                    index++;
                    Console.Write(multi[i, j] + " ");

                }
                Console.WriteLine();
            }

        }


        public static void FindAngle(int hour, int min)
        {
            double hourdegree = (hour * 30) + (min * 30.0 / 60);
            double mindegree = min * 6;

            double diff = Math.Abs(hourdegree - mindegree);

            if(diff > 180)
            {
                diff = 360 - diff;
            }

            Console.WriteLine("Angle between hour and min hands is {0} degree ", diff);
        }
    }
}
