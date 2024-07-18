
using Assignment_4.interface_Ex2;
using Assignment_4.Interface_Ex3;
using System;
using System.Text;

namespace Assignment_4
{
    internal class Program
    {
        public static void print10NumberFromSeries(seriesByTwo series)
        {
            if(series == null)
                return;
            for(int i = 0;i<10;i++)
            {
                Console.WriteLine($" {series.current}");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Part1 interface
            //  seriesByTwo series = new seriesByTwo();
            // print10NumberFromSeries(series);
            #endregion

            #region Ex#_interface
            //Airplane airplane = new Airplane();
            //   airplane.forword();
            //IMovable movable = new Airplane();
            //movable.forword();
            #endregion


            #region deep copy Vs Shallo copy 
            // int[] arr1 = [1, 3, 5];
            //int[] arr2 = { 4, 6, 7 };
            //Shallo copy 
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //arr1 = arr2;
            // deep copy
            // arr2 = (int[])arr1.Clone();

            #endregion
            #region  StringBuilder
            // Shallow copy
            /*   StringBuilder[] array1 = new StringBuilder[]
           {
               new StringBuilder("Hello"),
               new StringBuilder("World")
           };


               StringBuilder[] array2 = (StringBuilder[])array1.Clone();

               array2[0].Append(" Everyone");

               Console.WriteLine("Array 1:");
               foreach (var sb in array1)
               {
                   Console.WriteLine(sb.ToString());
               }

               Console.WriteLine("Array 2:");
               foreach (var sb in array2)
               {
                   Console.WriteLine(sb.ToString());
               }*/
            /////////////////////////////////////////////////
            // Deep copy
         /*   StringBuilder[] array1 = new StringBuilder[]
            {
            new StringBuilder("Hello"),
            new StringBuilder("World")
            };

          
            StringBuilder[] array2 = new StringBuilder[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = new StringBuilder(array1[i].ToString());
            }

           
            array2[0].Append(" Everyone");

            Console.WriteLine("Array 1:");
            foreach (var sb in array1)
            {
                Console.WriteLine(sb.ToString());
            }

            Console.WriteLine("Array 2:");
            foreach (var sb in array2)
            {
                Console.WriteLine(sb.ToString());
            }*/
            //////////////////////////////
            #endregion

        }
    }
}