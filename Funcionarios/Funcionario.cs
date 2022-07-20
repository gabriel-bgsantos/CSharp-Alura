using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario //Classe abstrata, serve como molde para as classes concretas (auxiliar, designer, etc)
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; } //O Static indica propriedade da classe
        public abstract double GetBonificacao(); //Métodos abstratos, também são só base para implementação nas classes concretas, onde serão especializados
        public abstract void AumentarSalario(); //Métodos abstratos, também são só base para implementação nas classes concretas, onde serão especializados

        public Funcionario(string nome, string cpf, double salario) //Método Construtor, indicando obrigatoriedades na criação do Objeto
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

        public static int GetTotalFuncionarios() //O Static indica aqui um Método da classe
        {
            return TotalFuncionarios;
        }

        //public virtual void AumentarSalario() -> Método que seria aplicado caso tivessemos um corpo
        //{

        //}
    }
}
