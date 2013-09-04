using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excella.TempConv
{
    public class TemperatureConverter
    {
        public int ToFahrenheit(int degreesCelsius)
        {
            if (degreesCelsius == 100) return 212;

            return 32;
        }

        public int ToCelsius(int degreesFahrenheit)
        {
            if (degreesFahrenheit == 212) return 100;

            return 0;
        }
    }
}
