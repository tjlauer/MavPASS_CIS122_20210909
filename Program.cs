using System;

namespace MavPASS_20210909
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array1 = { 5, 10, 15, 20, 25 };
            int[] array2 = { 1,  6, 11, 16, 21 };
            int[] array3 = { 4,  6, 14, 19, 24 };
            int[] array4 = { 3,  8, 13, 18, 23 };
            int[] array5 = { 2,  7, 12, 17, 22 };

            Solver aSolver = new Solver(array1, array2, array3, array4, array5);


            int[] answer = aSolver.CombineArrays();

            string msg = "";
            foreach(int i in answer)
            {
                msg = msg + i + ",";
            }
            Console.WriteLine(msg);

            Console.ReadLine();
            
        }
    }
}
