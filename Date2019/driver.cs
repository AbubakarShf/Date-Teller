using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date2019
{
    class driver
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\t\t\t\t :::Date_Calculator::: \n\n\n\t\t\t\t(Month-Date-TargetDate)\n\n\n");
            Console.Write("Enter 3 value in one line with space's = ");
            string[] line = Console.ReadLine().Split();
            int Month = int.Parse(line[0]);
            if (Month < 0 || Month > 12)
            {
                Console.Write("Invalid Month\n");
                Environment.Exit(-1);
            }
            int Day = int.Parse(line[1]);
            if (Day < 0 || Day > 31)
            {
                Console.Write("Invalid Day\n");
                Environment.Exit(-1);
            }
            int Target_Date = int.Parse(line[2]);
            if (Target_Date < 0 || Target_Date > 365 - Day)
            {
                Console.WriteLine("Invalid Increment!!!");
                Environment.Exit(-1);
            }
            Date2019 Calender = new Date2019(Month,Day);
            Console.Write("\n" + Target_Date.ToString() + " Day's  After ");
            Calender.print();
            Console.Write(" is ");
            Calender.plusday(Target_Date);
            Calender.print();
            Console.WriteLine();
         // Date2019 d1 = new Date2019();
          //d1.SetDate(4,31);
          // d1.plusday(1);
           //d1.print();
        }
    }
}
