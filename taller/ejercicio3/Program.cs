/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 09:05 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("calcular triple!");
			Console.WriteLine("digite un numero");
			int num = int.Parse(Console.ReadLine());
			pedir(num);
			Console.WriteLine("el triple de:"+num+" es "+triple(num));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static int pedir(int n){
			return n;
		}
		public static int triple(int n){
			int triplex = pedir(n)*3;
			return triplex;
		}
	}
}