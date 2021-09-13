using System;
using System.IO;
using System.Collections.Generic;
using IComparables.Entities;

namespace IComparables
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 1
            string path = @"C:\Users\Majevski\Documents\Dev\github\IComparable\IComparable\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    
                    list.Sort();

                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            // EXERCISE 2
            string path2 = @"C:\Users\Majevski\Documents\Dev\github\IComparable\IComparable\in2.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path2))
                {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
