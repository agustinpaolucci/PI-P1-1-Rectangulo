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


	}
}
