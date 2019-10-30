/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 09:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("numero mayor ");
			Console.WriteLine("-----");
			Console.WriteLine("ingrese los numeros");
			int n1 = int.Parse(Console.ReadLine());
		    int n2 = int.Parse(Console.ReadLine());
			int n3 = int.Parse(Console.ReadLine());
			
			calcularMayor(n1, n2, n3);
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void calcularMayor(int n1, int n2, int n3){
			
		
			
			if(n1>n2 && n1>n3){
				Console.WriteLine("el numero mayor es: "+n1);
			}else if (n2>n3 && n2>n1){
				Console.WriteLine("el numero mayor es: "+n2);
			}else if (n3>n1 && n3>n2){
				Console.WriteLine("el numero mayor es: "+n3);
			}else {
				Console.WriteLine("los numeros son iguales");
			}
			
			
		}
			
	}
	
}