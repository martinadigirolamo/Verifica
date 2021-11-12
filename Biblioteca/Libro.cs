using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        protected string _autore;
        protected string _titolo;
        protected int _annoPubblicazione;
        protected string _editore;
        protected int _numeroPagine;

        public string Autore
        {
            set; get;
        }
        public string Titolo
        {
            set; get;
        }
        public string Editore
        {
            set; get;
        }
        public int AnnoPubblicazione
        {
            set; get;
        }
        public int NumeroPagine
        {
            set; get;
        }


        public Libro(string autore, string titolo, int annoPubblicazione, string editore, int numeroPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Editore = editore;
            NumeroPagine = numeroPagine;
            
        }

        public override string ToString()
        {
            return Autore+Titolo+AnnoPubblicazione+Editore+NumeroPagine.ToString();
        }

        public int ReadingTime()
        {
            int tempolettura = 0;

            if(NumeroPagine<=100)
            {
                tempolettura = 1;
            }
            else if (NumeroPagine>100 && NumeroPagine<=200)
            {
                tempolettura = 2;
            }
            else
            {
                tempolettura = 3;
            }
            return tempolettura;
        }
    }
}
