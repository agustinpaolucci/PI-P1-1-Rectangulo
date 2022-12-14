using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_P1_1_Rectangulo
{
    public class Rectangulo
    {
		// ATRIBUTOS PRIVADOS
		private double baseR;
        private double alturaR;
		private double perimetro;
		private double superficie;

		// PROPIEDADES PUBLICAS
        public double BaseR
		{
			get { return baseR; }
			set { baseR = value; }
		}

		public double AlturaR
		{
			get { return alturaR; }
			set { alturaR = value; }
		}

		public double Perimetro
		{
			get { return perimetro; }
			set { perimetro = value; }
		}
		
		public double Superficie
		{
			get { return superficie; }
			set { superficie = value; }
		}

		// METODOS. 
		// CONSTRUCTOR SIN PARAMETROS.

		public Rectangulo()
		{
			baseR = 0;
			alturaR = 0;
		}

        // METODOS. 
        // CONSTRUCTOR CON PARAMETROS.
        public Rectangulo(double baseR, double alturaR)
		{
			this.baseR = baseR;
			this.alturaR = alturaR;
		}

        // METODO PARA CALCULAR EL PERIMETRO DEL CUADRADO
		
		public double CalcularPerimetro()
		{
			perimetro = (baseR * 2) + (alturaR * 2);
			return perimetro;
		}

        public double CalcularSuperficie()
        {
            superficie = baseR * alturaR;
            return superficie;
        }


        //METODO TO STRING

        public override string ToString()
		{
			return "Rectangulo de BASE: " + baseR + "y ALTURA:" + alturaR;
		}
	}
}
