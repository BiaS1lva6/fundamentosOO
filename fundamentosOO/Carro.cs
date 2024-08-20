using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentosOO
{
    public class Carro
    {
        //atributos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        //metodos
        public void Acelerar()
        {
            this.Velocidade += 5;
            Console.WriteLine("A Velocidade Atual é  " + this.Velocidade + "km/h");
        }

        public void Desacelerar()
        {
            this.Velocidade -= 5;
            Console.WriteLine("A Velocidade Atual é  " + this.Velocidade + "km/h");
        }
    }
}
