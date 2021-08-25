using System.Collections.Generic;
using Linhass;

namespace Empresas
{
    public class Empresa
    {
        public List<Linhas> linhas { get; set; }
        public Empresa (List<Linhas> _linha) {
            this.linhas = _linha;
        }
        
        

    }
}