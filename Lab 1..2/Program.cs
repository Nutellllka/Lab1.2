using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace Lab_1.__2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("2 Завдання");
            
            string path = @"C:\Users\Vlada\RiderProjects\Lab 1..2\Lab 1..2\Properties\json.json";

            var d1 = new Dictionary<char, int>()
            {
                { 'a', 1 },
                { 'b', 2 },
                { 'c', 3 }
            };

            var d2 = new Dictionary<char, int>()
            {
                { 'a', 3 },
                { 'b', 2 },
                { 'd', 4 }
            };

            var d3 = new Dictionary<char,int>();

            foreach (var pair in d1 )
            {
                char key = pair.Key;
                int value = pair.Value;

                if (d2.ContainsKey(key))
                {
                    value += d2[key];
                }

                d3[key] = value;
            }

            foreach (var pair in d2 )
            {
                char key = pair.Key;
                int value = pair.Value;

                if (!d3.ContainsKey(key))
                {
                    d3[key] = value;
                }
            }

            foreach (var pair in d3)
            {
                Console.WriteLine("{0}:{1}", pair.Key,pair.Value );
            }
            
            string json = JsonSerializer.Serialize(d3);
            File.WriteAllText(path,json);
            Console.WriteLine();
            Console.WriteLine($"result in json file {path}");
            
        }
    }
}