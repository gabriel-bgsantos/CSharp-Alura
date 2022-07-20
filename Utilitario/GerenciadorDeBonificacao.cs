using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public GerenciadorBonificacao()
        {
            Console.WriteLine("Gerenciador de Bonificação sendo gerado em segundo plano...\n");
        }

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
