// Thomas Lauer
// CIS 122 MavPASS
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_20210909
{
    public class Solver
    {
        //variables
        private int[] array1 = {};

        //properties
        public int[] Array1 { get { return this.array1; } set { this.array1 = value; } }
        public int[] Array2 { get; set; }
        public int[] Array3 { get; set; }
        public int[] Array4 { get; set; }
        public int[] Array5 { get; set; }

        //constructors
        public Solver() { }
        public Solver(int[] anArray1, int[] anArray2, int[] anArray3, int[] anArray4, int[] anArray5)
        {
            this.Array1 = anArray1;
            this.Array2 = anArray2;
            this.Array3 = anArray3;
            this.Array4 = anArray4;
            this.Array5 = anArray5;
        }

        public int[] CombineArrays()
        {
            int[] answer = new int[Array1.Length + Array2.Length + Array3.Length + Array4.Length + Array5.Length];
            int indx1 = 0;
            int indx2 = 0;
            int indx3 = 0;
            int indx4 = 0;
            int indx5 = 0;

            int valMax = Array1[0];
            foreach (int j in Array1) { if (valMax < j) { valMax = j; } }
            foreach (int j in Array2) { if (valMax < j) { valMax = j; } }
            foreach (int j in Array3) { if (valMax < j) { valMax = j; } }
            foreach (int j in Array4) { if (valMax < j) { valMax = j; } }
            foreach (int j in Array5) { if (valMax < j) { valMax = j; } }
            //valMax++;
            //Console.WriteLine("valMax = " + valMax);

            for (int i = 0; i < (Array1.Length + Array2.Length + Array3.Length + Array4.Length + Array5.Length); i++)
            {
                //Console.WriteLine("i = " + i);
                int val1 = valMax;
                int val2 = valMax;
                int val3 = valMax;
                int val4 = valMax;
                int val5 = valMax;

                if (indx1 < Array1.Length) { val1 = Array1[indx1]; }
                if (indx2 < Array2.Length) { val2 = Array2[indx2]; }
                if (indx3 < Array3.Length) { val3 = Array3[indx3]; }
                if (indx4 < Array4.Length) { val4 = Array4[indx4]; }
                if (indx5 < Array5.Length) { val5 = Array5[indx5]; }

                if (val1 <= val2 && val1 <= val3 && val1 <= val4 && val1 <= val5)
                {
                    answer[i] = val1;
                    indx1++;
                }
                else if (val2 <= val1 && val2 <= val3 && val2 <= val4 && val2 <= val5)
                {
                    answer[i] = val2;
                    indx2++;
                }
                else if (val3 <= val1 && val3 <= val2 && val3 <= val4 && val3 <= val5)
                {
                    answer[i] = val3;
                    indx3++;
                }
                else if (val4 <= val1 && val4 <= val2 && val4 <= val3 && val4 <= val5)
                {
                    answer[i] = val4;
                    indx4++;
                }
                else if (val5 <= val1 && val5 <= val2 && val5 <= val3 && val5 <= val4)
                {
                    answer[i] = val5;
                    indx5++;
                }
            }

            return answer;
        }
    }
}
