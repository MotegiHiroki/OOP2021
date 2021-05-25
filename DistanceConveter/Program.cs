﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConveter {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                PrintFeetToMeterList(1,10);
            } else {
                PrintMeterToFeetList(1,10);
            }



        }
        //メートルからフィートへの対応表
        private static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double feet = FeetConverter.MeeterToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);

            }
        }
        //フィートからメートルへの対応表
        private static void PrintFeetToMeterList(int start, int stop) {
            for (int feet = start; feet <= stop; feet++) {
                double meter = FeetConverter.FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);

            }
        }

    }

}
