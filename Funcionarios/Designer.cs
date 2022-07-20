using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cpf, double salario): base(nome, cpf, salario)
        {
            Console.WriteLine("Criando um Designer...");
        }

        public override double GetBonificacao()
        {
            return Salario + (Salario * 0.17);
        }

        public override void AumentarSalario()
        {
            Console.WriteLine("Aumentando o salário do Designer " + Nome + " em 11%...");
            Salario += Salario * 0.11;
        }
    }
}
