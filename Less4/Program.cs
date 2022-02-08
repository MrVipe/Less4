using System;

namespace Less4
{
    internal class Program
    {
        enum typeOfSeason
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {

            bool isMistake = true;
            string numMonth;
            do
            {
                Console.WriteLine("Введите номер месяца:");
                numMonth = Console.ReadLine();

                if (int.TryParse(numMonth, out int numMonthInt))
                {
                    if (numMonthInt >= 1 && numMonthInt <= 12)
                    {
                        isMistake = false;
                        continue;
                    }
                }
                Console.WriteLine("Некорректный ввод. Введите число от 1 до 12");
            }
            while (isMistake == true);

            Console.WriteLine("Текущие время года: " +  getTimeOfYearRus(getTimeOfYearEng(Convert.ToInt32(numMonth))));
            Console.ReadKey();
        }

        static int getTimeOfYearEng(int numMonth)
        {
            switch (numMonth)
            {
                case 12: case 1: case 2: return (int)typeOfSeason.Winter;
                case 3: case 4: case 5: return (int)typeOfSeason.Spring;
                case 6: case 7: case 8: return (int)typeOfSeason.Summer;
                case 9: case 10: case 11: return (int)typeOfSeason.Autumn;
            }
            return 0;

        }
        static string getTimeOfYearRus(int numMonth)
        {
            switch (numMonth)
            {
                case 0: return "Зима";
                case 1: return "Весна";
                case 2: return "Лето";
                case 3: return "Осень";
            }
            return "";
            
        }

    }
}

