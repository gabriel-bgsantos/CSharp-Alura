using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string nome, string cpf, double salario): base(nome, cpf, salario)
        {
            Console.WriteLine("Criando um Gerente de Contas...");
        }

        public override double GetBonificacao()
        {
            return Salario + (Salario * 0.25);
        }

        public override void AumentarSalario()
        {
            Console.WriteLine("Aumentando o salário do Gerente de Contas " + Nome + " em 5%...");
            Salario += Salario * 0.05;
        }
    }
}
