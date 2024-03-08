using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Libro
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Prestado { get; set; }

        public Libro(int codigo, string titulo, string autor)
        {
            Codigo = codigo; Titulo = titulo;  Autor = autor; Prestado = false;
        }
    }
}

