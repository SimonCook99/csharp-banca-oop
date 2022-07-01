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

        //funzione per stampare la lista dei clienti
        public void stampaClienti(){
            foreach (Cliente cliente in this.clienti){
                Console.WriteLine($"Nome: {cliente.Nome} \t Cognome: {cliente.Cognome} \t CF: {cliente.CF}");
            }
            Console.WriteLine();
        }

        //funzione per stampare una lista di prestiti (o tutti i prestiti della banca, o quelli relativi a un solo cliente)
        public void stampaPrestiti(List<Prestito> prestiti){
            foreach (Prestito prestito in prestiti){
                Console.WriteLine($"Prestito n. {prestito.ID} intestato a: {prestito.intestatario.Nome} {prestito.intestatario.Cognome} con un ammontare di {prestito.ammontare}€ da pagare in {prestito.rata} rate");
            }
            Console.WriteLine();
        }

        //funzione per la modifica di un cliente, dato il codice fiscale identificativo
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

        //funzione di ricerca di un cliente, utilizzato sia per l'aggiunta di prestiti, che per vedere le informazioni dei prestiti di un cliente
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

        //aggiunta prestito, associandolo ad un determinato cliente come intestatario
        public void aggiungiPrestito(Cliente intestatario, int ammontare, int rata, DateTime inizio, DateTime fine){
            if (this.clienti.Contains(intestatario)){
                this.prestiti.Add(new Prestito(intestatario, ammontare, rata, inizio, fine));
            }
            else{
                Console.WriteLine("Spiacente, l'utente non è registrato alla piattaforma");
            }
        }

        //funzione per ricavare la sottolista di prestiti di un solo cliente
        public List<Prestito> RicavaPrestitiCliente(Cliente intestatario){
            List<Prestito> prestitiCliente = new List<Prestito>();
            foreach (Prestito prestito in this.prestiti){
                if (prestito.intestatario == intestatario){
                    prestitiCliente.Add(prestito);
                }
            }
            return prestitiCliente;
        }

        //funzione per ricavare la somma di tutti i prestiti associati a un cliente
        public double sommaPrestitiDiUnCLiente(Cliente cliente){
            double totale = 0;

            foreach (Prestito prestito in this.prestiti){
                if(prestito.intestatario == cliente){
                    totale += prestito.ammontare;
                }
            }

            return totale;
        }
    }
}
