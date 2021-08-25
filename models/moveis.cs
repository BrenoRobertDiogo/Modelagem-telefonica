using System;
namespace Linhass
{
    public class LinhasMoveis : Linhas
    {
        // Obrigatorio
        public override string nomeTitular {get; set;}
        public override int numeroContratacao {get; set;}
        public override DateTime anoContratacao {get; set;}
        // Ex
        public double saldoAtual {get; set;}
        public string novaMensagem {get; set;}
        public bool possuiPlano {get; set;}
        public bool smsDisponivel {get; set;}

        public LinhasMoveis() : base() {
            this.possuiPlano = false;
            this.smsDisponivel = false;
            this.novaMensagem = "";
            this.saldoAtual = 0.0;
        }

        

        public void recarregar(double valor) 
        {
            this.possuiPlano = true;
            this.smsDisponivel = true;
            this.saldoAtual += valor;
        }

        public void navegar() 
        {
            if (this.possuiPlano)
            {
                Console.WriteLine("Quantidade de saldo a colocar: ");
                double qnt = int.Parse(Console.ReadLine())/4 * 0.99;
                this.saldoAtual += qnt;

            } else 
            {
                Console.WriteLine($"Serviço indisponível");
                
            }
        }

        public bool EnviarSMS(LinhasMoveis linhaMovel, string mensagem)
        {
            if (this.smsDisponivel)
            {
                Console.WriteLine($"Você: {mensagem}");
                this.saldoAtual += 0.10;
                return true;

            } else 
            {
                Console.WriteLine($"serviço indisponível");
                return false;
            }
        }

    }
}