using System;

namespace SEDC.cSharp.Class04.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday date");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(AgeCalculator(birthday));
        }

        //Homework Class 4 📒
        //Task
        //Make a method called AgeCalculator
        //The method will have one input parameter, your birthday date
        //The method should return your age
        //Show the age of a user after he inputs a date
        //Note: take into consideration if the birthday is today, after or before today

        static string AgeCalculator(DateTime birthday)
        {
            DateTime todaysDate = DateTime.Now;
            if (birthday.Year > todaysDate.Year)
            {
                return $"You are still not born!";
            }
            else if (birthday.Year < todaysDate.Year)
            {
                if (birthday.Month > todaysDate.Month)
                {
                    if(todaysDate.Year - birthday.Year <= 1)
                    {
                        return $"You are {12 - birthday.Month + todaysDate.Month} months old";
                    }
                    else
                    {
                        return $"You are {todaysDate.Year - birthday.Year -1} years and {12 - birthday.Month + todaysDate.Month} months old";
                    }
                }
                else if (birthday.Month < todaysDate.Month)
                {
                    return $"You are {todaysDate.Year - birthday.Year} years old";
                }
                else
                {
                    if (birthday.Day > todaysDate.Day)
                    {
                        return $"You are {todaysDate.Year - birthday.Year - 1} years old";
                    }
                    else if (birthday.Day < todaysDate.Day)
                    {
                        return $"You are {todaysDate.Year - birthday.Year} years old";
                    }
                    else
                    {
                        return $"Happy {todaysDate.Year - birthday.Year} birthday";
                    }
                }
            }
            else
            {
                if(birthday.Month > todaysDate.Month)
                {
                    return $"You are still not born";
                }
                else if(birthday.Month == todaysDate.Month)
                {
                    if(birthday.Day > todaysDate.Day)
                    {
                        return $"You are still not born";
                    }
                    else if(birthday.Day == todaysDate.Day)
                    {
                        return $"Welcome to the world!!";
                    }
                    else
                    {
                        return $"You are {todaysDate.Day - birthday.Day} days old";
                    }
                }
                else
                {
                    return $"You are {todaysDate.Month - birthday.Month} months old";
                }
            }
        }
    }
}
