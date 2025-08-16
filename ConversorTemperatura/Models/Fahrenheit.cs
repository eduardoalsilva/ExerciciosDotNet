using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConversorTemperatura.Models
{
    public class Fahrenheit : Temperatura
    {
        public Fahrenheit(double temperatura) : base(temperatura)
        {
            ValorTemperatura = temperatura;
        }

        public override void ConverterTemperatura()
        {
            double temperaturaFahrenheit = ValorTemperatura * 1.8 + 32;
            Console.WriteLine($"{ValorTemperatura}º C = {temperaturaFahrenheit}º F");
        }
    }
}