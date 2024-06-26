﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public static class CriadorFuncionarios
    {
        public static Marketing CriarMarketing()
        {
            Console.WriteLine("Qual o nome do funcionário?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a idade do funcionário?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o sálario do funcionário?");
            double salario = double.Parse(Console.ReadLine());

            Marketing marketing = new Marketing(1, nome, idade, salario);

            return marketing;
        }
        public static Gerente CriarGerente()
        {
            Console.WriteLine("Qual o nome do funcionário?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a idade do funcionário?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o sálario do funcionário?");
            double salario = double.Parse(Console.ReadLine());

            Gerente gerente = new Gerente(1, nome, idade, salario);

            return gerente;
        }
        public static Caixa CriarCaixa()
        {
            Console.WriteLine("Qual o nome do funcionário?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a idade do funcionário?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o sálario do funcionário?");
            double salario = double.Parse(Console.ReadLine());

            Caixa caixa = new Caixa(1, nome, idade, salario);

            return caixa;
        }
        public static Desenvolvedor CriarDesenvolvedor()
        {
            Console.WriteLine("Qual o nome do funcionário?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a idade do funcionário?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o sálario do funcionário?");
            double salario = double.Parse(Console.ReadLine());

            Desenvolvedor dev = new Desenvolvedor(1, nome, idade, salario);

            return dev;
        }
    }
}
