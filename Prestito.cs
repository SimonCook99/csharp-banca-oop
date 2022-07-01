using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Prestito{
        public int ID { get; set; }
        Cliente intestatario { get; set; }
        public int ammontare { get; set; }
        public int rata { get; set; }
        public DateTime inizio { get; set; }
        public DateTime fine { get; set; }

        public Prestito(Cliente intestatario, int ammontare, int rata, DateTime inizio, DateTime fine){
            this.ID = new Random().Next(10000,99999);
            this.intestatario = intestatario;
            this.ammontare = ammontare;
            this.rata = rata;
            this.inizio = inizio;
            this.fine = fine;
        }
    }
}