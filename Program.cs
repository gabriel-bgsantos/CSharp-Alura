using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Main();

void Main()
{
    Console.WriteLine("Boas vindas ao ByteBank Administração!\n");
    GerenciadorBonificacao gerenciador = new();

    Auxiliar auxiliar = new("Seu Zé", "386.124.644-95", 2000);
    Designer designer = new("Letícia", "284.048.471-09", 3000);
    GerenteDeContas gerentedecontas = new("Claudenes", "385.194.381-28", 4000);
    Diretor diretor = new("Pedrosa", "888.943.294-01", 5000);
    Console.WriteLine("------------------------------------------\n");

    gerenciador.Registrar(auxiliar);
    gerenciador.Registrar(designer);
    gerenciador.Registrar(gerentedecontas);
    gerenciador.Registrar(diretor);

    Console.WriteLine("Diretor - " + diretor.Nome +
                      "\n Salário base: " + diretor.Salario +
                      "\n Salário mais bonificação de 50%: " + diretor.GetBonificacao());
    Console.WriteLine("\nGerente de Contas - " + gerentedecontas.Nome +
                      "\n Salário base: " + gerentedecontas.Salario +
                      "\n Salário mais bonificação de 25%: " + gerentedecontas.GetBonificacao());
    Console.WriteLine("\nDesigner - " + designer.Nome +
                      "\n Salário base: " + designer.Salario +
                      "\n Salário mais bonificação de 17%: " + designer.GetBonificacao());
    Console.WriteLine("\nAuxiliar - " + auxiliar.Nome +
                      "\n Salário base: " + auxiliar.Salario +
                      "\n Salário mais bonificação de 20%: " + auxiliar.GetBonificacao());
    Console.WriteLine("------------------------------------------\n");

    diretor.AumentarSalario();
    gerentedecontas.AumentarSalario();
    designer.AumentarSalario();
    auxiliar.AumentarSalario();
    
    Console.WriteLine("\nSalários após aumentos:" +
                      "\n Diretor " + diretor.Nome + ": R$" + diretor.Salario +
                      "\n Gerente de Contas " + gerentedecontas.Nome + ": R$" + gerentedecontas.Salario +
                      "\n Designer " + designer.Nome + ": R$" + designer.Salario +
                      "\n Auxiliar " + auxiliar.Nome + ": R$" + auxiliar.Salario);
    Console.WriteLine("------------------------------------------\n");

    Console.WriteLine("Gasto total com bonificações: " + gerenciador.GetTotalBonificacao());
    Console.WriteLine("Número de Objetos criados no total: " + Funcionario.GetTotalFuncionarios());

   
    Console.ReadKey();
}