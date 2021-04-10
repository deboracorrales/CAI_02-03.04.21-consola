using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_ej._04
//Ej 4: Permita el ingreso de frases, finalizando cuando el usuario ingresa “fin”.
{
    class Program
    {
        static void Main(string[] args)
        {
			string texto;
			do
			{
				Console.WriteLine("Ingrese una frase. Escriba FIN para finalizar.");
				texto = Console.ReadLine();

				/*if(texto == "fin")
				{
					Console.WriteLine(" Programa finalizado");
					Console.ReadLine();
				}*/

			} while (texto != "fin");
			Console.WriteLine(texto);
			Console.ReadKey();

		}
	}
}
