using System;

namespace Less4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Порог расчета: ");
            int isStop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число Фибоначи: " + gotoFibon(0, isStop, 0, 1));
            Console.ReadKey();
        }

        static double gotoFibon(int isBegin, int isStop, Double numFirst, Double numSecond) 
        {

            if (isBegin < isStop)
            {
                isBegin++;
                return gotoFibon(isBegin, isStop, numSecond, numFirst + numSecond);
            }
            else
            {
                return numSecond;
            }
          
        }
         
    }
}
