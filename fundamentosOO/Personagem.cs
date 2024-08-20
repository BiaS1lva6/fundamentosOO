using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentosOO
{
    public abstract class Personagem
    {
        //atributos
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        //metodos
        public virtual void apresentarSe() { }
        public virtual void evoluir() { }
        public virtual int atacar()
        {
            int postosAtaque = 0;
            postosAtaque = (this.Inteligencia + this.Forca + this.Agilidade + this.Nivel + this.Vida) / 6;
            return postosAtaque;
        }
        public virtual int defender()
        {
            int pontosDefesa = 0;
            pontosDefesa = (this.Inteligencia + this.Forca + (this.Agilidade * 2) + this.Nivel + this.Vida) / 6;
            return pontosDefesa;
        }
        public virtual void batalha(Personagem p)
        {
            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.atacar();
                int valorDefesaInimigo = p.defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                if (danoDeVida <= 0)
                {
                    danoDeVida = 1;
                }
                p.Vida = p.Vida - danoDeVida;
                Console.WriteLine("Dano na Vida do Inimigo em " + danoDeVida);
                Console.WriteLine("O nível de vida do Inimigo agora é " + p.Vida);

                int valorAtaqueInimigo = p.atacar();
                int valorDefesa = this.defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine("Dano na Vida do Atacante em " + danoDeVida2);
                Console.WriteLine("O nível de vida do Atacante agora é " + this.Vida);
                Console.WriteLine("=====================================");

                if (this.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + p.Nome + " Venceu!");
                    vencedor = true;
                }
                if (p.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + this.Nome + " Venceu!");
                    vencedor = true;
                }
            }

        }
    }
}
