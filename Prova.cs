using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static csharp_biblioteca.Prova;

namespace csharp_biblioteca
{
    internal class Prova
    {
        public class Biblioteca
        {
            private List<Documento> documenti;
            private List<Utente> utenti;
            private List<Prestito> prestiti;

            public Biblioteca()
            {
                documenti = new List<Documento>();
                utenti = new List<Utente>();
                prestiti = new List<Prestito>();
            }

            public void AggiungiDocumento(Documento documento)
            {
                documenti.Add(documento);
            }

            public void AggiungiUtente(Utente utente)
            {
                utenti.Add(utente);
            }

            public void AggiungiPrestito(Utente utente, Documento documento, int DataInizio, int DataFine)
            {
                Prestito prestito = new Prestito(utente, documento, DataInizio, DataFine);
                prestiti.Add(prestito);
            }
        }

        public class Documento
        {
            private string _codice;
            private string _titolo;
            private int _anno;
            private string _settore;
            private string _scaffale;
            private string _nomeautore;

            public string Codice
            {
                get { return _codice; }
                set { _codice = value; }
            }
            public string Titolo
            {
                get { return _titolo; }
                set { _titolo = value; }
            }
            public int Anno
            {
                get { return _anno; }
                set { _anno = value; }
            }
            public string Settore
            {
                get { return _settore; }
                set { _settore = value; }
            }
            public string Scaffale
            {
                get { return _scaffale; }
                set { _scaffale = value; }
            }
            public string NomeAutore
            {
                get { return _nomeautore; }
                set { _nomeautore = value; }
            }

            public Documento(string Codice, string Titolo, int Anno, string Settore, string Scaffale, string NomeAutore)
            {
                _codice = Codice;
                _titolo = Titolo;
                _anno = Anno;
                _settore = Settore;
                _scaffale = Scaffale;
                _nomeautore = NomeAutore;
            }
        }

        public class Libro : Documento
        {
            public int _numeropagine;

            public int NumeroPagine
            {
                get { return _numeropagine; }
                set { _numeropagine = value; }
            }

            public Libro(string Codice, string Titolo, int Anno, string Settore, string Scaffale, string NomeAutore, int NumeroPagine)
                : base(Codice, Titolo, Anno, Settore, Scaffale, NomeAutore)
            {
                NumeroPagine = _numeropagine;
            }
        }

        public class DVD : Documento
        {
            public int _durata;

            public int Durata
            {
                get { return _durata; }
                set { _durata = value; }
            }

            public DVD(string Codice, string Titolo, int Anno, string Settore, string Scaffale, string NomeAutore, int Durata)
                : base(Codice, Titolo, Anno, Settore, Scaffale, NomeAutore)
            {
                _durata = Durata;
            }
        }

        public class Utente
        {
            private string _nome;
            private string _cognome;
            private string _email;
            private string _password;
            private string _telefono;

            public string Nome
            {
                get { return _nome; }
                set { _nome = value; }
            }

            public string Cognome
            {
                get { return _cognome; }
                set { _cognome = value; }
            }
            public string Email
            {
                get { return _email; }
                set { _email = value; }
            }
            public string Password
            {
                get { return _password; }
                set { _password = value; }
            }
            public string Telefono
            {
                get { return _telefono; }
                set { _telefono = value; }
            }
            public Utente(string Nome, string Cognome, string Email, string Password, string Telefono)
            {
                _nome = Nome;
                _cognome = Cognome;
                _email = Email;
                _password = Password;
                _telefono = Telefono;
            }
        }

        public class Prestito
        {
            private Utente _utente;
            private Documento _documento;
            private int _datainizio;
            private int _datafine;

            public Utente Utente
            {
                get { return _utente; }
            }
            public Documento Documento
            {
                get { return _documento; }
            }
            public int DataInizio
            {
                get { return _datainizio; }
                set { _datainizio = value; }
            }
            public int DataFine
            {
                get { return _datafine; }
                set { _datafine = value; }
            }

            public Prestito(Utente Utente, Documento Documento, int DataInizio, int DataFine)
            {
                _utente = Utente;
                _documento = Documento;
                _datainizio = DataInizio;
                _datafine = DataFine;
            }
        }
    }
}
