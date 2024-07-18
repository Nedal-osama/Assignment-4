
using Assignment_4.interface_Ex2;
using Assignment_4.Interface_Ex3;
using System;

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
            Airplane airplane = new Airplane();
            //   airplane.forword();
            IMovable movable = new Airplane();
            movable.forword();
            #endregion
            #region deep copy Vs Shallo copy 
            int[] arr1 = [1, 3, 5];
            int[] arr2 = { 4, 6, 7 };
            //Shallo copy 
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //arr1 = arr2;

            // deep copy
            arr2 = (int[])arr1.Clone();

            #endregion
        }
    }
}