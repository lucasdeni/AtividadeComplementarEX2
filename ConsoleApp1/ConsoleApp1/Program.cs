using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            DadosFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            DadosFuncionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            DadosFuncionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario1 = DadosFuncionario.SalarioLiquido();
            Console.WriteLine("Funcionário: " + DadosFuncionario.Nome + ", R$" + salario1.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            DadosFuncionario.Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario2 = DadosFuncionario.AumentarSalario();
            Console.WriteLine("Dados atualizados: " + DadosFuncionario.Nome + ", R$" + salario2.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
