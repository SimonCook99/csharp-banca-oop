using csharp_banca_oop;

Banca b = new Banca();
b.Nome = "Intesa San Paolo";

Cliente Simone = new Cliente("Simone", "Prova", "mrsmn998redqdsd244", 2000);
Cliente Pippo = new Cliente("Pippo", "test", "pptst998redqdsd2581", 1300);
b.clienti.Add(Simone);
b.clienti.Add(Pippo);

b.stampaClienti(); //stampo prima la lista clienti con i clienti predefiniti
b.stampaPrestiti();

int counter = 0;
while(counter < 4){
    Console.WriteLine("Scegli un opzione: ");
    Console.WriteLine("1. aggiungi cliente");
    Console.WriteLine("2. modifica cliente");
    Console.WriteLine("3. aggiungi prestito");
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Inserisci il nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome:");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci il codice fiscale:");
            string CFiscale = Console.ReadLine();
            Console.WriteLine("Inserisci lo stipendio:");
            int stipendio = int.Parse(Console.ReadLine());

            //creo un nuovo cliente, doopodichè lo aggiungo alla lista
            Cliente nuovo = new Cliente(nome, cognome, CFiscale, stipendio);
            b.AggiungiCliente(nuovo);
            b.stampaClienti();
            counter++;
            break;
        case 2:

            //modifica cliente della lista, tramite codice fiscale univoco
            Console.WriteLine("Inserisci il codice fiscale del cliente che vuoi modificare");
            string CF = Console.ReadLine();
            b.ModificaCliente(CF, new Cliente("Pippo modificato", "test cliente modificato", "prova bla bla", 1000));
            counter++;
            break;

        case 3:

            Cliente intestatario = null;
            while (intestatario == null){
                Console.WriteLine("Inserisci il codice fiscale del cliente a cui vuoi aggiungere il prestito");
                string CFSearch = Console.ReadLine();
                intestatario = b.ricercaCliente(CFSearch);
            }
            b.aggiungiPrestito(intestatario, 2000, 15, new DateTime(2022, 8, 5), new DateTime(2023, 6, 21));
            b.stampaPrestiti();
            counter++;
            break;
    }

}











//b.aggiungiPrestito(nuovo, 2000, 15, new DateTime(2022, 8, 5), new DateTime(2023, 6, 21));
//b.aggiungiPrestito(Simone, 2500, 20, new DateTime(2022, 8, 5), new DateTime(2023, 6, 21));
//b.aggiungiPrestito(Pippo, 5000, 52, new DateTime(2022, 8, 5), new DateTime(2023, 6, 21));

b.stampaPrestiti();
