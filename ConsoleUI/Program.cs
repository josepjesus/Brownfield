using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string w, cont;
            int i, t, ttl;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            do
            {
                Console.Write("Enter what you did: ");
                w = Console.ReadLine();
                //t = int.Parse(Console.ReadLine());
                while (true)
                {
                    Console.Write("How long did you do it for: ");
                    if (int.TryParse(Console.ReadLine(), out t))
                    {
                        break;
                    }
                    Console.WriteLine("\nInvalid umber given");
                }
                TimeSheetEntry ent = new TimeSheetEntry();
                ent.HoursWorked = t;
                ent.WorkDone = w;
                ents.Add(ent);
                Console.Write("Do you want to enter more time:");
                //cont = bool.Parse(Console.ReadLine());
                cont = Console.ReadLine();
            } 
            while (cont == "yes"); ttl = 0;

            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("Acme"))
                {
                    //ttl += i;
                    // We need to count hours that we have done for Acme, no works thet we have done
                    ttl = ttl + ents[i].HoursWorked;
                }
            }

            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + ttl * 150 + " for the hours worked.");

            //Here we need to restart our ttl variable, because it counts the hours that we done for "Acme"
           
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("ABC"))
                {
                    //ttl += i;
                    // We need to count hours that we have done for ABC, no works thet we have done
                    ttl = ttl + ents[i].HoursWorked;
                }
            }


            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + ttl * 125 + " for the hours worked.");

            //Here we need to restart our ttl variable, because it counts the hours that we done for "ABC"

            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                ttl += ents[i].HoursWorked;
            }
            if (ttl >= 40)
            {
                Console.WriteLine("You will get paid $" + ttl * 150 + " for your work.");
                //In the Correct form, it's multiplicated by 150, not by 15
            }
            else
            {
                Console.WriteLine("You will get paid $" + ttl * 100 + " for your time.");
                //In the Correct form, it's multiplicated by 100, not by 10
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public int HoursWorked;
    }
}
