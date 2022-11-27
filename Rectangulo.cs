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
		private int baseR;
        private int alturaR;
		private int perimetro;
		private int superficie;

		// PROPIEDADES PUBLICAS
        public int BaseR
		{
			get { return baseR; }
			set { baseR = value; }
		}

		public int AlturaR
		{
			get { return alturaR; }
			set { alturaR = value; }
		}

		public int Perimetro
		{
			get { return perimetro; }
			set { perimetro = value; }
		}
		
		public int Superficie
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
        public Rectangulo(int baseR, int alturaR)
		{
			this.baseR = baseR;
			this.alturaR = alturaR;
		}

        // METODO PARA CALCULAR EL PERIMETRO DEL CUADRADO
		
		public int CalcularPerimetro()
		{
			perimetro = (baseR * 2) + (alturaR * 2);
			return perimetro;
		}

        public int CalcularSuperficie()
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
