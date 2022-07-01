using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Banca{
        public string Nome { get; set; }

        public List<Cliente> clienti = new List<Cliente>();
        public List<Prestito> prestiti = new List<Prestito>();


        public void AggiungiCliente(Cliente cliente){
            this.clienti.Add(cliente);
        }

        public void stampaClienti(){
            foreach (Cliente cliente in this.clienti){
                Console.WriteLine($"Nome: {cliente.Nome} \t Cognome: {cliente.Cognome} \t CF: {cliente.CF}");
            }
            Console.WriteLine();
        }

        public void ModificaCliente(string codiceFiscaleVecchioCliente, Cliente nuovoCliente){
            foreach (Cliente cliente in this.clienti){
                if(cliente.CF == codiceFiscaleVecchioCliente){
                    this.clienti.Remove(cliente);
                    this.clienti.Add(nuovoCliente);
                    Console.WriteLine("Cliente modificato correttamente");
                    this.stampaClienti();
                    return;
                }
            }
            
        }

        public Cliente ricercaCliente(string codiceFiscaleDaCercare){
            foreach (Cliente cliente in this.clienti){
                if(cliente.CF == codiceFiscaleDaCercare){
                    Console.WriteLine("Cliente trovato");
                    return cliente;
                }
            }

            Console.WriteLine("Spiacente, non ho trovato nessun cliente con quel codice fiscale");
            return null;

        }

        public void aggiungiPrestito(Cliente intestatario, int ammontare, int rata, DateTime inizio, DateTime fine){
            this.prestiti.Add( new Prestito(intestatario, ammontare, rata, inizio, fine) );
        }
    }
}
