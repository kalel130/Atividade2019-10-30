﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 1; i <= 10000; i++)
            {
                Console.Write("{0},", i);
            }
            Console.ReadKey();
        }
    }
}
