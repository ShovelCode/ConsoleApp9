using System;
using System.Collections.Generic;
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test String");

            string cities = "Paris,Berlin,Madrid,New York,Comma Town";

            string[] citiesArray = cities.Split(',');

            foreach( string item in citiesArray)
            {
                Console.WriteLine(item);
            }

            var cities2 = new List<string>(); //a list not a long string
            cities2.Add("London");
            cities2.Add("Paris");
            cities2.Add("Milan");
            cities2.Insert(0, "Sydney");
            foreach(string city in cities2)
            {
                Console.WriteLine($"   {city}");
            }

        }
    }
}
