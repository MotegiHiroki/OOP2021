using System;
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
            for (int meter = 1; meter <= 10; meter++) {
                double feet = MeeterToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);

            }
        }
        //フィートからメートルへの対応表
        private static void PrintFeetToMeterList(int start, int stop) {
            for (int feet = 1; feet <= 10; feet++) {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);

            }
        }

        //フィートからメートルを求める
        private static double FeetToMeter(int feet) {
            return feet * 0.3048;
        }

        //メートルからフィートを求める
        private static double MeeterToFeet(int meter) {
            return meter / 0.3048;
        }
    }

}
