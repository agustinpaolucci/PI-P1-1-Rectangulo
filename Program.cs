using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_P1_1_Rectangulo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // CREACION DEL OBJETO
            Rectangulo rec01 = new Rectangulo();

            // INGRESO DE DATOS
            Console.WriteLine("Ingrese la base del rectangulo en cms.");
            rec01.BaseR = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo en cms.");
            rec01.AlturaR = double.Parse(Console.ReadLine());

            // CALCULOS
            Console.WriteLine($"Teniendo un cuadrado rectangulo de BASE: {rec01.BaseR} cms. y ALTURA: {rec01.AlturaR} cms...\n\nSu PERIMETRO ES: {rec01.CalcularPerimetro()} cms. y su SUPERFICIE: {rec01.CalcularSuperficie()} cm3s.\n");
            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}

/*
 Problema 1.1:
Rectángulo. Calcular el perímetro y la superficie de un rectángulo de base 3 y alto 5.
 */
