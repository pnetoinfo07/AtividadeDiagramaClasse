﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class Desenvolvedor:Funcionario
    {
        public Desenvolvedor(int id, string nome, int idade, double salario)
        : base(id, nome, idade, salario)
        {
            BonusAnual = Salario * 0.5;
        }
    }
}
