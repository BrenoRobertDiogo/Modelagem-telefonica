using System;

namespace Linhas
{
    public class LinhasFixas : Linhas
    {
        // Obrigatorio
        public override string nomeTitular {get; set;}
        public override int numeroContratacao {get; set;}
        public override DateTime anoContratacao {get; set;}
        // Ex
        private double valorMensalidade {get; set;}
        private int franquiaMensalMin {get; set;}
        private int restanteFranquia {get; set;}
        private bool faturaPaga {get; set;}
        
        public void Ligar(int qntMin) 
        {
            if (this.faturaPaga && (this.restanteFranquia-qntMin > 0))
            {
                this.restanteFranquia -= qntMin;
            } else 
            {
                Console.WriteLine($"Saldo insuficiente");
                
            }
        }

        public void Pagarfatura() 
        {
            this.faturaPaga = true;
        }

    }
}