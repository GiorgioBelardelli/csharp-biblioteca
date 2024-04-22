using static csharp_biblioteca.Prova;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();


            /// UTENTI REGISTRATI
            Utente utente1 = new Utente("Rossi", "Mario", "mario.rossi@example.com", "password123", "123456789");
            biblioteca.AggiungiUtente(utente1);
            Utente utente2 = new Utente("Verdi", "Anna", "anna.verdi@example.com", "password456", "987654321");
            biblioteca.AggiungiUtente(utente2);
            Utente utente3 = new Utente("Bianchi", "Luca", "luca.bianchi@example.com", "password789", "456789123");
            biblioteca.AggiungiUtente(utente3);


            ///CREAZIONE LIBRI E DVD

            //libri
            Libro libro1 = new Libro("L001", "Il Signore degli Anelli", 1954, "Fantasy", "A1", "J.R.R.Tolkien", 1000);
            biblioteca.AggiungiDocumento(libro1);
            Libro libro2 = new Libro("L002", "Cronache del ghiaccio e del fuoco", 1996, "Fantasy", "A2", "George R.R.Martin", 800);
            biblioteca.AggiungiDocumento(libro2);
            Libro libro3 = new Libro("L003", "1984", 1949, "Distopia", "B1", "George Orwell", 300);
            biblioteca.AggiungiDocumento(libro3);

            //dvd
            DVD dvd1 = new DVD("D001", "Inception", 2010, "Thriller", "C1", "Christopher Nolan", 148);
            biblioteca.AggiungiDocumento(dvd1);
            DVD dvd2 = new DVD("D002", "Interstellar", 2014, "Fantascienza", "C2", "Christopher Nolan", 169);
            biblioteca.AggiungiDocumento(dvd2);
            DVD dvd3 = new DVD("D003", "La vita è bella", 1997, "Drammatico", "D1", "Roberto Benigni", 116);
            biblioteca.AggiungiDocumento(dvd3);

        }
    }


}
