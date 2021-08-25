using System.Collections.Generic;
using Linhass;

namespace Empresas
{
    public class Empresa
    {
        public List<LinhasMoveis> linhasMoveis { get; set; }
        public List<LinhasFixas> linhasFixas { get; set; }
        public string Nome { get; set; }
        
        
        public Empresa (List<LinhasMoveis> _linha, string _nome, List<LinhasFixas> _linhas) {
            this.linhasMoveis = _linha;
            this.linhasFixas = _linhas;
            this.Nome = _nome;
        }
        
        

    }
}