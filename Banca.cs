using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Banca{
        public string Nome { get; set; }

        List<Cliente> clienti;
        List<Prestito> prestiti;
    }
}
