using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handlingdates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {




            // Demonstrating date handling

            // Get the current date
            DateTime currentDate = DateTime.Today;
                Console.WriteLine("Current Date: " + currentDate);

                // Add days to the current date
                DateTime futureDate = currentDate.AddDays(30);
                Console.WriteLine("Date 30 days from now: " + futureDate);

                // Subtract days from the current date
                DateTime pastDate = currentDate.AddDays(-15);
                Console.WriteLine("Date 15 days ago: " + pastDate);

                // Get the day of the week
                DayOfWeek dayOfWeek = currentDate.DayOfWeek;
                Console.WriteLine("Day of the Week: " + dayOfWeek);

                // Format a date as a string
                string formattedDate = currentDate.ToString("yyyy-MM-dd");
                Console.WriteLine("Formatted Date: " + formattedDate);

                // Parse a date from a string
                string dateStr = "2023-12-31";
                DateTime parsedDate = DateTime.ParseExact(dateStr, "yyyy-MM-dd", null);
                Console.WriteLine("Parsed Date: " + parsedDate);
            Console.ReadLine();
            }
        }
    }


