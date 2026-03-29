using System;
					
public class Program
{
	public static void Main()
	{
		int idade1 = 15;
		int idade2 = 20;
		int idade3 = 21;
		
		double media = (idade1 + idade2 + idade3) / 3.0;
		
		Console.WriteLine("A media das idades é: {0:0.0}", media);
	}
}
