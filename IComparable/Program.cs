﻿using System;
using System.Collections.Generic;
using System.IO;

namespace IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
