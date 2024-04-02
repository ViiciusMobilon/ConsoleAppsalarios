using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppsalarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se você deseja começar digite sim");
            string sim = Console.ReadLine().ToLower();

            Console.WriteLine("Digite se vocâ e assalariado, comissioonado, Horista");
            string tipo = Console.ReadLine().ToLower();

            double fp = 0;
            double sal2 = 0;

            while (sim == "sim" )
            {
                switch (tipo)
                {
                    case "assalariado":
                        Console.WriteLine("Qual o seu salario bruto ");
                        double sal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o desconto ");
                        double d = double.Parse(Console.ReadLine());
                        sal2 = sal - d;
                        fp = fp + sal2;

                        break;

                    case "comissionado":
                        Console.WriteLine("Qual a quantidade de peças produzidas ");
                        int pecas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o valor de cada de peças produzidas ");
                        int Ppecas = int.Parse(Console.ReadLine());
                        sal2 = Ppecas * pecas;
                        fp = fp + sal2;
                        break;
                    case "horista":
                        Console.WriteLine("Digite a quantidades de horas trabalhadas ");
                        int h = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a quantidades de horas trabalhadas ");
                        int ht = int.Parse(Console.ReadLine());
                        sal2 = h * ht;
                        fp = fp + sal2;
                        break;

                }
            }
            
        }
    }
}
