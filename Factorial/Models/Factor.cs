using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factorial.Models
{
    public class Factor
    {

        public Factor(long numFactorial) {
            this.NumeroFactorial = numFactorial;
            Iteraciones = new List<string>();
            calcularFactorial(NumeroFactorial);
        }

        public long calcularFactorial(long num) {
            NumResultado= 1;
            
            for (int i = 1; i <= num; i++)
            {
                String iteracion = NumResultado + " * " + i+" = ";
                NumResultado = NumResultado * i;
                iteracion  += NumResultado;
                Iteraciones.Add(iteracion);

            }



            return NumResultado;
        }

        


        public long NumeroFactorial { get; set; }
        public long NumResultado { get; set; }
        public List<string> Iteraciones { get; set; }

    }
}
