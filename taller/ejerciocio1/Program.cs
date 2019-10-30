/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 09:00 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejerciocio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello todos");
			
			
			Console.WriteLine("");
			
			calcularMasaCorporal();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void calcularMasaCorporal(){
		 
			Console.WriteLine("digite su estatura: ");
			double estatura= double.Parse(Console.ReadLine());
			Console.WriteLine("digite su peso: ");
			double peso = double.Parse (Console.ReadLine());
			double imc = peso/(estatura*estatura);
			Console.WriteLine("su masa corporal es de: "+imc);
	}
	
	}
}