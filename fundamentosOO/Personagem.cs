using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace defundamentos
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }

        public int inteligencia { get; set; }

        public int vida { get; set; }
        public int Vida { get; set; }

        //metodos

        public virtual void Apresentarse() { }
        public virtual void Evoluir()
        {
            this.Nivel += 2;
            this.Forca *= 2;
            this.inteligencia *= 2;
            this.Agilidade *= 2;
            Console.WriteLine("O jogador " + this.Nome + " evoluiu para o nível " + this.Nivel + ". Seus novos valores são:  \nAgilidade: " + this.Agilidade + "  \nInteligencia: " + this.inteligencia + "\nForca: " + this.Forca);
        }
        public virtual int Atacar()
        {
            int pontosdeAtaque = 0;
            pontosdeAtaque = (this.Agilidade + (this.Forca * 2) + this.inteligencia + this.Nivel + this.Vida) / 5;
            return pontosdeAtaque;
        }
        public virtual int Defender()
        {
            int defesa = 0;
            defesa = ((this.Agilidade * 2) + this.Forca + (this.inteligencia * 2) + this.Nivel + this.Vida) / 5;
            return defesa;
        }
        public virtual void Batalha(Personagem p)
        {


            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.Atacar();
                int valorDefesaInimigo = p.Defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                if (danoDeVida <= 0)
                {
                    danoDeVida = 1;
                }
                p.Vida = p.Vida - danoDeVida;
                Console.WriteLine("Dano na Vida do inimigo em " + danoDeVida);
                Console.WriteLine("O nivel de Vida do inimigo é " + p.Vida);

                int valorAtaqueInimigo = p.Atacar();
                int valorDefesa = this.Defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine("Dano na vida do atacante em " + danoDeVida2);
                Console.WriteLine("O nivel de vida do atacante agora é " + this.Vida);

                Console.WriteLine("==============================================================");

                if (this.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + p.Nome + "Venceu!");
                    vencedor = true;
                    p.Evoluir();
                }

                if (p.Vida <= 0)
                {
                    Console.WriteLine("O vencedor " + this.Nome + "venceu");
                    vencedor = true;
                    this.Evoluir();
                }
            }
        }


    }
}
