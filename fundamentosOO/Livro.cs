using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentosOO
{
    public class Livro
    {
        public string Titulo { get; set; } /*toda a vez que  criar um atributo tem que ter o gat (pegar as informaçoes) e a set*/

        public string Autor { get; set; }

        public string Editora { get; set; }

        public int AnoLancamento { get; set; }
    }
}

