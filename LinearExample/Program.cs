﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearExample
{
    class Program
    {
        //array to be searched
        int[] arr = new int[20];
        //number of element in the array
        int n;
        //get the number of element to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("enter the number of element in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 20 element.\n");
            }
            //accept array element
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" Enter Array Element ");
            Console.WriteLine("--------------------------------");
        }
        static void Main(string[] args)
        {
        }
    }
}
