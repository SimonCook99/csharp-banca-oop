using csharp_banca_oop;

Banca b = new Banca();
b.Nome = "Intesa San Paolo";

b.clienti.Add(new Cliente("Simone", "Prova", "mrsmn998redqdsd244", 2000));
b.clienti.Add(new Cliente("Pippo", "test", "pptst998redqdsd2581", 1300));

b.stampaClienti(); //stampo prima la lista clienti con i clienti predefiniti


//creo un nuovo cliente, doopodichè lo aggiungo alla lista
Cliente nuovo = new Cliente("Filippo", "Aggiunta", "aggiunta test nuovo cliente", 1500);
b.AggiungiCliente(nuovo);
b.stampaClienti();


//modifica cliente della lista, tramite codice fiscale univoco
Console.WriteLine("Inserisci il codice fiscale del cliente che vuoi modificare");
string CF = Console.ReadLine();
b.ModificaCliente(CF, new Cliente("Pippo modificato", "test cliente modificato", "spero che funzioni", 1000));
