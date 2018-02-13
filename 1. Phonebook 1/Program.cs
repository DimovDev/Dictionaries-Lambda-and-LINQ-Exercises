using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;

namespace _1._Phonebook_1
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,string> phonebook=new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] phonebookParameters = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string command = phonebookParameters[0];
                if (command == "A")
                {
                    string key = phonebookParameters[1];
                    string value = phonebookParameters[2];
                    phonebook[key] = value;
                }
                else
                {
                    string key = phonebookParameters[1];
                    if (phonebook.ContainsKey(key))
                    {
                              Console.WriteLine($"{key} -> {phonebook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {key} does not exist.");

                    }
                }

                input = Console.ReadLine();

            }

        }
    }
}
