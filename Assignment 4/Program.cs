using Assignment_4.interface_Ex2;
using Assignment_4.Interface_Ex3;

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
        }
    }
}
