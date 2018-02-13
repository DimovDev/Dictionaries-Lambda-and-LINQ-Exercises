using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _3._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> resuorsesQuantites = new Dictionary<string, double>();
            var line = Console.ReadLine();
            while (line != "stop")
            {
                string resourse = line;
                double quantity = double.Parse(Console.ReadLine());
                if (!resuorsesQuantites.ContainsKey(resourse))
                {
                    resuorsesQuantites[resourse] = 0;
                }

                resuorsesQuantites[resourse] += quantity;
                 line = Console.ReadLine();

            }

            foreach (var resuorseQuantite in resuorsesQuantites)
            {
                string resuorse = resuorseQuantite.Key;
                var quantity = resuorseQuantite.Value;
                Console.WriteLine($"{resuorse} -> {quantity}");
            }
        }
    }
}
