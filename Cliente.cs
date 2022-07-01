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

        public Cliente(string nome, string cognome, string cF, int stipendio){
            this.Nome = nome;
            this.Cognome = cognome;
            this.CF = cF;
            this.stipendio = stipendio;
        }
    }
}