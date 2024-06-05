using AtividadeDiagramaClasse;

Gerente g1 = new Gerente(1, "Paulo", 24, 1500);
GerenciadorEmpresarial ger = new GerenciadorEmpresarial();
ger.CalcularBonificacao(g1);
g1.BonusAnual = 10000;
Console.WriteLine("Meu bonus anual "+ g1.BonusAnual);