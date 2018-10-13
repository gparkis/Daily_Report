using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("");
            Console.WriteLine("         The Tech Academy");
            Console.WriteLine("        Student Daily Report");
            Console.WriteLine("");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Which course are you currently on: ");
            string currentCourse = (Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Which page number are you currently on: ");
            int currentPageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Do you need help with anything? answer \"true\" or \"false\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Were there any positive or negative experiences you'd like to share?  Please give specifics.");
            string positiveNegativeExperiences = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Is there any other feedback you'd like to provide?  Please give specifics.");
            string feedback = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("How many hours did you study today?");
            double hoursStudiedToday = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("");
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.  Have a great day!");
            Console.WriteLine("");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("");
            Console.Read();

        }
    }
}
