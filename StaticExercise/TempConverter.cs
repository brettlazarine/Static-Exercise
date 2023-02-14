using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempF)
        {
            return (tempF - 32) / 1.8;
        }
        public static double CelsiusToFahrenheit(double tempC) { return (tempC * 1.8) + 32; }
    }
}
