using System;
public class Mainclass
{
    public enum Months
    {
        JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
    }
    public static void Main()
    {
        Months нынешнийМесяц;
        Console.WriteLine("Введите номер месяца:");
        int mNum = int.Parse(Console.ReadLine());
        нынешнийМесяц = Months.JANUARY;
        if (mNum >= 1 && mNum <= 12)
        {
            if (mNum == 1)
            {
                нынешнийМесяц = Months.JANUARY;
            }
            else if (mNum == 2)
            {
                нынешнийМесяц = Months.FEBRUARY;
            }
            else if (mNum == 3)
            {
                нынешнийМесяц = Months.MARCH;
            }
            else if (mNum == 4)
            {
                нынешнийМесяц = Months.APRIL;
            }
            else if (mNum == 5)
            {
                нынешнийМесяц = Months.MAY;
            }
            else if (mNum == 6)
            {
                нынешнийМесяц = Months.JUNE;
            }
            else if (mNum == 7)
            {
                нынешнийМесяц = Months.JULY;
            }
            else if (mNum == 8)
            {
                нынешнийМесяц = Months.AUGUST;
            }
            else if (mNum == 9)
            {
                нынешнийМесяц = Months.SEPTEMBER;
            }
            else if (mNum == 10)
            {
                нынешнийМесяц = Months.OCTOBER;
            }
            else if (mNum == 11)
            {
                нынешнийМесяц = Months.NOVEMBER;
            }
            else if (mNum == 12)
            {
                нынешнийМесяц = Months.DECEMBER;
            }
        }
        switch (нынешнийМесяц)
        {
            case Months.JANUARY:
                Console.WriteLine("Зима");
                break;
            case Months.FEBRUARY:
                Console.WriteLine("Зима");
                break;
            case Months.MARCH:
                Console.WriteLine("Весна");
                break;
            case Months.APRIL:
                Console.WriteLine("Весна");
                break;
            case Months.MAY:
                Console.WriteLine("Весна");
                break;
            case Months.JUNE:
                Console.WriteLine("Лето");
                break;
            case Months.JULY:
                Console.WriteLine("Лето");
                break;
            case Months.AUGUST:
                Console.WriteLine("Лето");
                break;
            case Months.SEPTEMBER:
                Console.WriteLine("Осень");
                break;
            case Months.OCTOBER:
                Console.WriteLine("Осень");
                break;
            case Months.NOVEMBER:
                Console.WriteLine("Осень");
                break;
            case Months.DECEMBER:
                Console.WriteLine("Зима");
                break;
        }
    }
}



