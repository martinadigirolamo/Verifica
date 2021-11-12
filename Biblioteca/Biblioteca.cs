using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Biblioteca:Libro
    {
        protected string _nome;
        protected string _indirizzo;
        protected int _orarioApertura;
        protected int _orarioChiusura;
        protected List<string> _elencoLibri;

        public string Nome {set; get; }
        public string Indirizzo { set; get; }
        public int OrarioApertura { set; get; }
        public int OrarioChiusura { set; get; }
        public List<string> ElencoLibri { set; get; }

        public Biblioteca(string autore, string titolo, int annoPubblicazione, string editore, int numeroPagine, string nome, string indirizzo, int orarioApertura, int orarioChiusura, List<string> elencoLibri) : base(autore, titolo, annoPubblicazione, editore, numeroPagine)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            
        }

        public List<string> RiempiLista()
        {

            ElencoLibri.Add(Titolo);

            return ElencoLibri;
        }

    }
}
