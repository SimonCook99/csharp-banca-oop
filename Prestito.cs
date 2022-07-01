using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Prestito{
        public string ID { get; set; }
        Cliente intestatario { get; set; }
        public int ammontare { get; set; }
        public int rata { get; set; }
        public DateTime inizio { get; set; }
        public DateTime fine { get; set; }
    }
}