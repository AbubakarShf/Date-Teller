using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date2019
{
    class Date2019
    {
        private int Day;
        private int Month;
        private int Total_Days;
        public Date2019()
        {
            this.Day = 1;
            this.Month = 1;
            this.Total_Days = 0;
        }
        public Date2019(int day)
        {
            if(day>=1 || day<=365)
            {
                this.Total_Days = day;
                if (day >= 1 && day <= 31)
                {
                    this.Month = 1;
                    this.Day =day;
                   
                }
               else if (day >31  && day <= 59)
                {
                    this.Month = 2;
                    this.Day = day-31;
                }
                else if (day > 59 && day <= 90)
                {
                    this.Month = 3;
                    this.Day = day - 59;
                }
                else if(day > 90 && day <= 120)
                {
                    this.Month = 4;
                    this.Day = day - 90;
                }
                else if (day > 120 && day <= 151)
                {
                    this.Month = 5;
                    this.Day = day - 120;
                }
                else if (day > 150 && day <= 181)
                {
                    this.Month = 6;
                    this.Day = day - 151;
                }
                else if (day > 181 && day <= 212)
                {
                    this.Month = 7;
                    this.Day = day - 181;
                }
                else if (day > 212 && day <= 243)
                {
                    this.Month = 8;
                    this.Day = day - 212;
                }
                else if (day > 243 && day <= 273)
                {
                    this.Month = 9;
                    this.Day = day - 243;
                }
                else if (day > 273 && day <= 304)
                {
                    this.Month = 10;
                    this.Day = day - 273;
                }
                else if (day > 304 && day <= 334)
                {
                    this.Month = 11;
                    this.Day = day - 304;
                }
                else//if (day > 334 && day <= 365)
                {
                    this.Month = 12;
                    this.Day = day - 334;
                }
            }
            else
                {
                    Console.WriteLine("Day out of Range");
                    System.Environment.Exit(-1);

                }
               }
        public Date2019(int mm, int dd)
        {
            ConvertToDays(mm,dd);
        }
              public void SetDate(int mm,int dd)
        {
            ConvertToDays(mm, dd);
        }
        public void ConvertToDays(int mm,int dd)
        {
            if ((dd >= 1 && dd <= 31) && (mm >= 1 && mm <= 12))
            {
                this.Month = mm;
                this.Day = dd;
                if (mm == 2 && (dd >= 29))
                {
                    Console.WriteLine("Invalid Date >28");
                    Environment.Exit(-1);
                }
                else if ((this.Month == 4 || this.Month == 6 || this.Month == 11 || this.Month == 9) && this.Day >= 31)
                {
                    Console.WriteLine("Invalid Date >30");
                    Environment.Exit(-1);
                }
                else if ((this.Month == 1 || this.Month == 3 || this.Month == 5 || this.Month == 7 || this.Month == 8 || this.Month == 10 || this.Month == 12) && this.Day >= 32)
                {
                    Console.WriteLine("Invalid Date >30");
                    Environment.Exit(-1);
                }
                else if (mm == 1)
                {
                    this.Day = dd;
                    this.Total_Days = dd;
                }
                else if (mm == 2)
                {
                    this.Day = dd;
                    this.Total_Days = 31 + dd;
                }
                else if (mm == 3)
                {
                    this.Day = dd;
                    this.Total_Days = 59 + dd;
                }
                else if (mm == 4)
                {
                    this.Day = dd;
                    this.Total_Days = 90 + dd;
                }
                else if (mm == 5)
                {
                    this.Day = dd;
                    this.Total_Days = 120 + dd;
                }
                else if (mm == 6)
                {
                    this.Day = dd;
                    this.Total_Days = 151 + dd;
                }
                else if (mm == 7)
                {
                    this.Day = dd;
                    this.Total_Days = 181 + dd;
                }
                else if (mm == 8)
                {
                    this.Day = dd;
                    this.Total_Days = 212 + dd;
                }
                else if (mm == 9)
                {
                    this.Day = dd;
                    this.Total_Days = 243 + dd;
                }
                else if (mm == 10)
                {
                    this.Day = dd;
                    this.Total_Days = 273 + dd;
                }
                else if (mm == 11)
                {
                    this.Day = dd;
                    this.Total_Days = 304 + dd;
                }
              else //  else if (mm == 12)
                {
                    this.Day = dd;
                    this.Total_Days = 334 + dd;
                }
            }
            else
            {
                Console.WriteLine("Day & month Out of range!");
                System.Environment.Exit(-1);
            }
        }
        public void print()
        {
            if (this.Total_Days <= 365)
            {
               
                if (this.Month == 1) 
                {
                    Console.Write(" " + DayName(this.Total_Days) + " Junuary " + this.Day + ",2019");
                }
                if (this.Month == 2) 
                {
                    Console.Write(" "+DayName(this.Total_Days) + " Febuary " + this.Day + ",2019");
                }
                if (this.Month == 3) 
                {
                    Console.Write(" " + DayName(this.Total_Days) + " March " + this.Day + ",2019");
                }
                if (this.Month == 4)
                {
                    Console.Write(DayName(this.Total_Days) + " April " + this.Day + ",2019");
                }
                if (this.Month == 5) 
                {
                    Console.Write(DayName(this.Total_Days) + " May " + this.Day + ",2019");
                }
                if (this.Month == 6)
                {
                    Console.Write(DayName(this.Total_Days) + " Jun " + this.Day + ",2019");
                }
                if (this.Month == 7)
                {
                    Console.Write(DayName(this.Total_Days) + " July " + this.Day + ",2019");
                }
                if (this.Month == 8)
                {
                    Console.Write(DayName(this.Total_Days) + " Augest " + this.Day + ",2019");
                }
                if (this.Month == 9)
                {
                    Console.Write(DayName(this.Total_Days) + " September " + this.Day + ",2019"); 
                }
                if (this.Month == 10)
                {
                    Console.Write(DayName(this.Total_Days) + " October " + this.Day + ",2019");
                }
                if (this.Month == 11)
                {
                    Console.Write(DayName(this.Total_Days) + " November " + this.Day + ",2019");
                }
                if (this.Month == 12) 
                {
                    Console.Write(DayName(this.Total_Days) + " December " + this.Day + ",2019"); 
                }
            }
            else
            {
                this.Month = 0;
                this.Day = 0;
                Console.WriteLine(" Date is not found in Year 2019!");
                System.Environment.Exit(-1);
            }

        }
        public void plusday(int add_days)
        {
            if (add_days >= 0 || add_days <= 365)
            {
                int day=this.Total_Days + add_days;
                this.Total_Days += add_days;
                if (day >= 1 && day <= 31)
                {
                    this.Month = 1;
                    this.Day = day;
                }
                else if (day > 31 && day <= 59)
                {
                    this.Month = 2;
                    this.Day = day - 31;
                }
                else if (day > 59 && day <= 90)
                {
                    this.Month = 3;
                    this.Day = day - 59;
                }
                else if (day > 90 && day <= 120)
                {
                    this.Month = 4;
                    this.Day = day - 90;
                }
                else if (day > 120 && day <= 151)
                {
                    this.Month = 5;
                    this.Day = day - 120;
                }
                else if (day > 150 && day <= 181)
                {
                    this.Month = 6;
                    this.Day = day - 151;
                }
                else if (day > 181 && day <= 212)
                {
                    this.Month = 7;
                    this.Day = day - 181;
                }
                else if (day > 212 && day <= 243)
                {
                    this.Month = 8;
                    this.Day = day - 212;
                }
                else if (day > 243 && day <= 273)
                {
                    this.Month = 9;
                    this.Day = day - 243;
                }
                else if (day > 273 && day <= 304)
                {
                    this.Month = 10;
                    this.Day = day - 273;
                }
                else if (day > 304 && day <= 334)
                {
                    this.Month = 11;
                    this.Day = day - 304;
                }
                else//else if (day > 334 && day <= 365)
                {
                    this.Month = 12;
                    this.Day = day - 334;
                }
            }
            else
            {
                Console.WriteLine("Out of Range");
                System.Environment.Exit(-1);
            }
        }
        public string DayName(int _Total_Days)
        {
           
             int Cal_Day = (2 + _Total_Days - 1) % 7;

            if (Cal_Day == 0)
            {
                return "Sunday";
            }
            else if (Cal_Day == 1)
            {
                return "Monday";
            }
            else if (Cal_Day == 2)
            {
                return "Tuesday";
            }
            else if (Cal_Day  == 3)
            {
                return "Wednsday";
            }
            else if (Cal_Day == 4)
            {
                return "Thursday";
            }
            else if (Cal_Day == 5)
            {
                return "friday";
            }
            else if (Cal_Day == 6)
            {
                return "Saturday";
            }
            else
                return "NULL";
        } 
    }
}