using System;
using Empresas;
using Linhass;
using System.Collections.Generic;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<LinhasMoveis> lista = new List<LinhasMoveis>();
            List<LinhasFixas> listaFixa = new List<LinhasFixas>();
            LinhasMoveis movel1 = new LinhasMoveis();
            LinhasMoveis movel2 = new LinhasMoveis();
            LinhasMoveis movel3 = new LinhasMoveis();
            lista.Add(movel1);
            lista.Add(movel2);
            lista.Add(movel3);
            Empresa TMSEV = new Empresa (lista, "Te Mato Se Estiver Vivo", listaFixa);
            Empresa outraLinha = new Empresa (lista, "Outra linha", listaFixa);

            TMSEV.linhasMoveis[0].navegar();
            TMSEV.linhasMoveis[0].recarregar(150);
            TMSEV.linhasMoveis[0].navegar();
            TMSEV.linhasMoveis[1].EnviarSMS(outraLinha.linhasMoveis[1], "mensagem pra enviar");
            
        }
    }
}
