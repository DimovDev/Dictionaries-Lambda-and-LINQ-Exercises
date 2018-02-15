using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string,string> fixEmail =new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                string name = input;
                string email = (Console.ReadLine());
               

                fixEmail[name] = email;
                input = Console.ReadLine();
            }

            var sortedmails = fixEmail.Where(kvp => !(kvp.Value.EndsWith("us") || kvp.Value.EndsWith("uk")))
                .ToDictionary(kvp => kvp.Key,kvp =>kvp.Value);

            foreach (var name in sortedmails)
            {
               //var name= fixEmail.Key;
               // var mail = sortedmails.Value;
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }
        }
    }
}
