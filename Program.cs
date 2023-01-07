using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarCPF
{
	class Program
	{
		public static void Main()
		{
			string cpf;
			bool validar;
			char opcao;
			cpf:
			Console.WriteLine("Digite seu CPF:(Somente os números!)");
			cpf = Console.ReadLine();

			ValidacaoCPF validacaoCPF = new ValidacaoCPF();
			validar = validacaoCPF.ValidaCpf(cpf);

			if (validar == true)
			{
				Console.WriteLine("CPF Válido!");
				Console.ReadKey();
				Console.Clear();
				Console.WriteLine("Fechando sistema!");
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("CPF Inválido!");
				Console.WriteLine("Gostaria de Digitar novamente?(S/N)");
				opcao = char.Parse(Console.ReadLine());
				Console.Clear();
				while (opcao == 'S' || opcao == 's')
				{
					goto cpf;
				}
				Console.Clear();
				Console.WriteLine("Fechando sistema!");
				Console.ReadKey();
			}

		}
	}
}
