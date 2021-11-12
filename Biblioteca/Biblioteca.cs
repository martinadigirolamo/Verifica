using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Biblioteca
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


        public Biblioteca(string nome, string indirizzo, int orarioApertura, int orarioChiusura, List<string> elencoLibri)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            ElencoLibri = elencoLibri;
        }


    }
}
