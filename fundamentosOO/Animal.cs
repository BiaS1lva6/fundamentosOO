using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentosOO
{
    public abstract class Animal
    {
        //Declaração de atributo
        public string Especie { get; set; }
        public string Nome { get; set; }


        //Declaração de um metodo
        public abstract void emitirSom();

    }
}
