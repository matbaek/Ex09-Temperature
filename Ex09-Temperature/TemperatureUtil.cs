using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Temperature
{
    public class TemperatureUtil
    {
        public static double FahrenheitToCelsius(double v)
        {
            //return (5.0 / 9.0) * (v - 32);
            return 5 * (v - 32) / 9;
        }

        public static double CelsiusToFahrenheit(double v)
        {
            return ((9.0 * v) / 5.0) + 32;
        }
    }
}
