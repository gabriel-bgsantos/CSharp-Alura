using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
            Console.WriteLine("Criando um Diretor...");
        }

        public override double GetBonificacao()
        {
            return Salario + (Salario * 0.50);
        }

        public override void AumentarSalario()
        {
            Console.WriteLine("Aumentando o salário do Diretor " + Nome + " em 15%...");
            Salario += Salario * 0.15;
        }
    }
}
