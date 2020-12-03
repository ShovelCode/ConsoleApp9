using System;

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
        }
    }
}
