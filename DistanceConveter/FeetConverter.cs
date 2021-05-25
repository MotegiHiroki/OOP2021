using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConveter {
    //フィートとメートルの単位変換（静的クラス）
     public static class FeetConverter {
        private const double ratio = 0.3048;

        //フィートからメートルを求める
         public　static double FeetToMeter(int feet) {
            return feet * ratio;
        }

        //メートルからフィートを求める
         public static double MeeterToFeet(int meter) {
            return meter / ratio;
        }
    }
}
