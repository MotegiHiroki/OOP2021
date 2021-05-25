using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConveter {
    class FeetConverter {

        //フィートからメートルを求める
         public double FeetToMeter(int feet) {
            return feet * 0.3048;
        }

        //メートルからフィートを求める
         public double MeeterToFeet(int meter) {
            return meter / 0.3048;
        }
    }
}
