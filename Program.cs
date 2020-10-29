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

    }
}
