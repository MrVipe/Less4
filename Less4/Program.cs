using System;

namespace Less4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ConvertStrToSummInt("5 10 55 43 1 3 10"));
            Console.WriteLine(ConvertStrToSummInt("7 8 1 77 16 4 3"));
            Console.WriteLine(ConvertStrToSummInt("1 2 3 4 5 6 7"));
            Console.ReadKey();
        }

        static double ConvertStrToSummInt(string strNumber) 
        {
            double summNumber = 0;
            string numPlus = "";

            for (int i = 0; i < strNumber.Length; i++)
            {
                
                if (Char.IsNumber(strNumber[i]))
                {
                    numPlus += strNumber[i];
                    if (i == strNumber.Length - 1) summNumber += Convert.ToDouble(numPlus);
                }
                else
                {
                    summNumber += Convert.ToDouble(numPlus);
                    numPlus = "";
                }    

            }
            return summNumber;
        }
         
    }
}
