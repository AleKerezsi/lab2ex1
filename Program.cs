using System;

namespace lab2ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        /* Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
		citit de la tastatura*/ 
		
		Console.WriteLine("Introduceti n");
		int n= int.Parse(Console.ReadLine());
		
		int sumaCifrelor = 0;
		
		while(n>0)
		{
			int ultimaCifra = n%10;
			n= n/10;
			sumaCifrelor = sumaCifrelor+ ultimaCifra;
		}
			Console.WriteLine("Suma cifrelor este "+ sumaCifrelor);
        }
    }
}
