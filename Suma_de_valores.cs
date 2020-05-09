/*
 * Created by SharpDevelop.
 * User: Invitado
 * Date: 09/05/2020
 * Time: 11:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
					
public class Suma_de_valores
{
	public static void Main()
	{
		Console.WriteLine("Introduzca el valor 1:");
		int valorA = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Introduzca el valor 2:");
		int valorB = int.Parse(Console.ReadLine());

		Console.WriteLine("Introduzca el valor 3:");
		int valorC = int.Parse(Console.ReadLine());
		
		int sumaTotal = valorA + valorB + valorC;
		
		Console.WriteLine("La suma de los numeros es: " + sumaTotal);						  
	}
}