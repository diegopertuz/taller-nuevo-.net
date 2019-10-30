/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 07:55 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace punto6
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
				Console.WriteLine("digite el radio");
				double r = double.Parse(Console.ReadLine());
				
				Console.WriteLine("el area es: "+AREA(r));
				
				Console.WriteLine("el perimetro es: "+perimetro(r));
		
				Console.WriteLine("el diametro es: "+diametro(r));
				
				Console.WriteLine("la circunferencia  es: "+circunferencia(r));
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static double AREA(double r){
			double PI = 3.14;
			double Area = PI*(r*r);
			return Area;
			
		}public static double perimetro(double r){
			double PI = 3.14;
			double P = (PI*PI)*r;
			return P;
			
		}public static double diametro(double r){
		
			double P =2*r;
			return P;
			
		}public static double circunferencia(double r){
			double PI = 3.14;
			double P = diametro(r)*PI;
			return P;
			
		}
		
	}
}