using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Datorteknik_Programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.Write("Ange ditt 12-siffriga personnummer: ");
            userInput = Console.ReadLine();
            
            // control length

            if (userInput.Length !=12)
            {
                Console.WriteLine("Ogiltigt personnummer! ");
            }
            else
            {
                // control year
                int year;
                year = int.Parse(userInput.Substring(0, 4));

                if (1752 < year && year < 2021)
                {
                    // control month
                    int month;
                    month = int.Parse(userInput.Substring(4, 2));

                    if (month == 01 || month == 02 || month == 03 || month == 04 || month == 05 || month == 06 || month == 07 || month == 08 || month == 09 || month == 10 || month == 11 || month == 12)
                    {
                        // control day
                        int day;
                        day = int.Parse(userInput.Substring(6, 2));
                        // seperate method for checking number of days i a month
                        CheckDaysInMonth(LeapYear(year), month, day);

                        int birthnumber;
                        birthnumber = int.Parse(userInput.Substring(8, 3));

                        if (birthnumber % 2 != 0)
                        {
                            Console.WriteLine("Personnummret är korrekt! Personen är juridiskt sett en man");
                        }
                        else
                        {
                            Console.WriteLine("Personnummret är korrekt! Personen är juridiskt sett en kvinna");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt personnummer! ");
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltigt personnummer! ");
                }
            }
            Console.ReadKey();
        }
        // Check if a year is a leap year
        static bool LeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }
        // Checks LongMonth and ShortMonth
        static bool LongMonthShortMonth(int[] array, int month, int day, int daysInMonth)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == month)
                {
                    if (day > daysInMonth || day < 1)
                    {
                        Console.WriteLine("Ogiltigt personnummer! ");
                        return false;
                    }
                }
            }
            return true;
        }
        
        // Checks days in months
        static bool CheckDaysInMonth(bool LeapYear, int month, int day)
        {
            int[] longMonth = new int[] { 01, 03, 05, 07, 08, 10, 12 };
            int[] shortMonth = new int[] { 04, 06, 09, 11 };

            bool correctLongMonth = LongMonthShortMonth(longMonth, month, day, 31);
            bool correctShortMonth = LongMonthShortMonth(shortMonth, month, day, 30);

            //Checks if one of the two variables is false
            if(correctLongMonth == false || correctShortMonth == false)
            {
                return false;
            }
            //Checks month if year is not a leap year
            if (LeapYear == false)
            {
                //Check month 02(February)
                if (month == 02)
                {
                    if (day > 28 || day < 1)
                    {
                        Console.WriteLine("Ogiltigt personnummer! ");
                        return false;
                    }
                }
            }
            //Check month 02 if it is not a leap year
            else
            {
                if (month == 02)
                {
                    if (day > 29 || day < 1)
                    {
                        Console.WriteLine("Ogiltigt personnummer! ");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
