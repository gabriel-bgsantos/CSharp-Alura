using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, string cpf, double salario): base(nome, cpf, salario)
        {
            Console.WriteLine("Criando um Auxiliar...");
        }

        public override double GetBonificacao()
        {
            return Salario + (Salario * 0.20);
        }

        public override void AumentarSalario()
        {
            Console.WriteLine("Aumentando o salário do Auxiliar " + Nome + " em 10%...");
            Salario += Salario * 0.10;
        }
    }
}
