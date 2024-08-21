using fundamentosOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defundamentos
{
    public class Cavaleiro : Personagem
    {
        public override void Apresentarse()
        {
            Console.WriteLine("Ola, eu sou o Cavaleiro " + this.Nome + ", tenho " + this.Vida + ", pontos de vida, inteligência: " + this.inteligencia + ", Agilidade: " + this.Agilidade + ", Força: " + this.Forca + ", Meu nivel atual é: " + this.Nivel);
        }
    }
}
