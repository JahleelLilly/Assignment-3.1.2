using System;

class Program
{
    static void Main()
    {
        int year1 = 2016;
        int year2 = 2018;

        Console.WriteLine("Is " + year1 + " a leap year? " + IsLeapYear(year1));
        Console.WriteLine("Is " + year2 + " a leap year? " + IsLeapYear(year2));
    }

    static bool IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        return false;
    }
}

