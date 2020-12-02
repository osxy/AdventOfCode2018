﻿using AoC2020.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020.Days
{

    public class Day1
    {

        public static void Execute()
        {

            var day = 1;

            //Input filenames
            string realInputFile = $"Day{day}_RealData.txt";

            //Get input contents
            var realInputValues = Helpers.General.GetDataFromInputFile(realInputFile);


            // Do JIT compilation
            Console.Clear();
            Console.WriteLine("Start JIT compilation");
            PartOne(realInputValues);
            PartTwo(realInputValues);
            Console.Clear();

            Stopwatch watch = Stopwatch.StartNew();
            Console.WriteLine($"Start work on Day {day}");
            Console.WriteLine("");
            Console.WriteLine($"Day {day} - Part One");
            watch.Restart();
            Console.Write("Answer: ");
            PartOne(realInputValues);
            watch.Stop();
            Console.WriteLine($"Done in: {watch.Elapsed.TotalMilliseconds}ms");

            Console.WriteLine("");

            Console.WriteLine($"Day {day} - Part Two");
            watch.Restart();
            Console.Write("Answer: ");
            PartTwo(realInputValues);
            watch.Stop();
            Console.WriteLine($"Done in: {watch.Elapsed.TotalMilliseconds}ms");

            //Present back to main window
            Program.BackToMain();

        }

        public static void PartOne(string[] input)
        {

            Console.WriteLine(ExecutePartOne(input));

        }

        public static void PartTwo(string[] input)
        {

            Console.WriteLine(ExecutePartTwo(input));

        }


        public static int ExecutePartTwo(string[] input)
        {
            var array = ArraysAndLists.StringArrayToIntArray(input);

            foreach (int current in array)
            {
                var smallerList = array.Where(x => x <= 2020 - current).Select(x => x);
                foreach (int i in smallerList)
                {
                    var smallestList = array.Where(x => x <= 2020 - current - i).Select(x => x);
                    foreach (int j in smallestList)
                    {
                        if (current + i + j == 2020)
                        {
                            return current * i * j;
                        }
                    }
                }
            }
            return 0;
        }

        public static int ExecutePartOne(string[] input)
        {
            var array = Helpers.ArraysAndLists.StringArrayToIntArray(input);
            foreach(int current in array)
            {
                var smallerList = array.Where(x => x <= 2020 - current).Select(x => x);
                foreach (int i in smallerList)
                {
                    if (current + i == 2020)
                    {
                        return current * i;
                    }
                }
            }
            return 0;
        }
    }

}
