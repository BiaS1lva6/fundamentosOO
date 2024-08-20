using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentosOO
{
    public class Mago : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá eu sou o mago " + this.Nome + " tenho " + this.Vida + " pontos de vida, \nInteligência: " + this.Inteligencia + ", \nAgilidade: " + this.Agilidade + "\nForça: " + this.Forca + ". \nNivel atual é: " + this.Nivel);
            Console.WriteLine("=====================================================");
        }
    }
}
