using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Cliente{
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CF { get; private set; }
        public int stipendio;
    }
}