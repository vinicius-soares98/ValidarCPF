using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarCPF
{
	public class ValidacaoCPF
	{
		public bool ValidaCpf(string cpf)
		{

			int pos, cont = 10, soma = 0, numero, result, digito1, digito2;


			if (cpf.Length > 11 || cpf.Length < 11)
			{
				return (false);
			}
			else
			{

				if (cpf != "11111111111" && cpf != "22222222222" && cpf != "33333333333" && cpf != "44444444444" && cpf != "55555555555" && cpf != "66666666666" && cpf != "77777777777" && cpf != "88888888888" && cpf != "99999999999" && cpf != "00000000000")
				{

					for (pos = 0; pos < cpf.Length - 2; pos++)
					{

						numero = (int.Parse(cpf[pos].ToString()));
						soma = soma + numero * cont;
						cont--;

					}

					result = 11 - (soma % 11);

					if (result >= 10)
					{
						digito1 = 0;
					}
					else
					{
						digito1 = result;
					}

					if (digito1 == (int.Parse(cpf[9].ToString())))
					{
						return (true);
					}
					else
						return (false);

					cont = 11;
					soma = 0;
					for (pos = 0; pos < cpf.Length - 1; pos++)
					{
						numero = (int.Parse(cpf[pos].ToString()));
						soma = soma + numero * cont;
						cont--;
					}

					result = 11 - (soma % 11);

					if (result >= 10)
					{
						digito2 = 0;
					}
					else
					{
						digito2 = result;
					}

					if (digito2 == (int.Parse(cpf[10].ToString())))
					{
						return (true);
					}
					else   
						return (false);
				}
				else
					return (false);
			}
		}
	}
}
