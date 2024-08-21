using fundamentosOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defundamentos
{
    public class Mago : Personagem
    {

        public override void Apresentarse()
        {
            Console.WriteLine("Ola, eu sou o Mago " + this.Nome + ", tenho " + this.Vida + ", pontos de vida, inteligência: " + this.inteligencia + ", Agilidade: " + this.Agilidade + ", Força: " + this.Forca + ", Meu nivel atual é: " + this.Nivel);
        }






        //public override void batalha()
        //{

        //}



        public override void Evoluir()
        {

        }
    }
}
