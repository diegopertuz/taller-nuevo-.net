/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 08:38 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace punto7
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("digite el numero");
			int num = int.Parse(Console.ReadLine());
			
			tabla(num);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static int tabla(int n){
			
			int resultado = 0;
			
			 for(int i=1;i<=10;i++){
				 resultado = n*i;
				Console.WriteLine(n+"x"+i+"="+resultado);
				
			}
		
			return resultado;
		}
	}
}