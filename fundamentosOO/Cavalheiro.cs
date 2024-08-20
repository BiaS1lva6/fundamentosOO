using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentosOO
{
    public class Cavalheiro : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá eu sou o cavalheiro " + this.Nome + " tenho " + this.Vida + " pontos de vida, \nInteligência: " + this.Inteligencia + ", \nAgilidade: " + this.Agilidade + "\nForça: " + this.Forca + ". \nNivel atual é: " + this.Nivel);
            Console.WriteLine("=====================================================");


        }
    }
}
