using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class DadosFuncionario
	{
		public static string Nome;
		public static double SalarioBruto;
		public static double Imposto;
		public static double Porcentagem;

		public static double SalarioLiquido()
		{
			return SalarioBruto - Imposto;
		}
		public static double AumentarSalario()
		{
			return (SalarioBruto - Imposto) + (SalarioBruto * (Porcentagem / 100));
		}
	}
}
