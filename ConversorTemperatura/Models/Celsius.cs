using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConversorTemperatura.Models
{
    public class Celsius : Temperatura
    {
        public Celsius(double temperatura) : base(temperatura)
        {
            ValorTemperatura = temperatura;
        }

        public override void ConverterTemperatura()
        {
            double temperaturaCelsius = (ValorTemperatura - 32) * 0.556;
            Console.WriteLine($"{ValorTemperatura}º F = {temperaturaCelsius}º C"); 
        }
    }
}