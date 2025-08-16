using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConversorTemperatura.Models
{
    public abstract class Temperatura
    {
        public double ValorTemperatura { get; set; }

        public Temperatura(double temperatura)
        {
            ValorTemperatura = temperatura;
        }
        public virtual void ConverterTemperatura()
        {

        }

    }
}