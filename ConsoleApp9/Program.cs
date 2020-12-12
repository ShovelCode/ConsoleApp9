using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

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

            //mapSample();
            //analyze_Url();
            //makePing();
            //dataTypeSample();
            dataBaseInfo();

        }

        static void dataBaseInfo()
        {
            Console.WriteLine("Object-relational mapping ORM, ORM associates columns in tables to properties" +
                "in classes");
        }

        static void analyze_Url()
        {
            Console.Write("Enter a valid web address.");
            string url = Console.ReadLine();
            var uri = new Uri(url);
            Console.WriteLine(uri.Host);
            Console.WriteLine(uri.Query);

        }

        static void mapSample()
        {
            var keywords = new Dictionary<string, string>();
            keywords.Add("int", "32-bit integer data type");
            keywords.Add("long", "64-bit integer data type");
            keywords.Add("float", "Single precision floating point number");

            Console.WriteLine("keywords and their definitions.");

            foreach (KeyValuePair<string, string> item in keywords)
            {
                Console.WriteLine($"  {item.Key}: {item.Value}");
            }
        }

        static void makePing()
        {
            Console.Write("Enter a valid web address.");
            try
            {
                string url = Console.ReadLine();
                var uri = new Uri(url);

                var ping = new Ping();
                PingReply reply = ping.Send(uri.Host);
                Console.WriteLine(reply.Address);
            }
            catch (Exception ex)
            {
                Console.WriteLine("oops!  \n" + ex.ToString());
            }
        }

        static void testControl()
        {
            Console.WriteLine("In textControl method");
        }

        static void dataTypeSample()
        {
            string verbatimSample = @"\\\n~`.'";
            string normalString = "Greetings";
            double piApproximation = 3.14;
            int bigNum = 70_000_000;
            long longerInt = 10000000;
            decimal price = 9.99M;
            char letter = 's';
            string deseret = "𐐯"; //deseret sample
            bool greenLight = false;
            //string password = string.Empty;

            string[] names = new string[4];

            names[0] = "Ert";
            names[1] = "Jill";
            names[2] = "Jack";
            names[3] = "Three";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Hello Again");
            Console.WriteLine(verbatimSample);
            Console.WriteLine(sizeof(int));
            Console.WriteLine(int.MinValue);
            Console.WriteLine(normalString);
            Console.WriteLine(piApproximation);
            Console.WriteLine(letter);
            Console.WriteLine(bigNum);
            Console.WriteLine(greenLight);
            Console.WriteLine(deseret);
            Console.WriteLine(price);
            Console.WriteLine(longerInt);
            //TimesTable(7);
            //Console.WriteLine(Factorial(4));
            Console.WriteLine();
        }
    }
}
