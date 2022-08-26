using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histgame.Game
{
    internal class Personagem : IPersonagem
    {
        private static System.Timers.Timer aTimer;
        private string name;
        private int damage;
        private decimal life;
      
       

        public Personagem()
        {
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getDamage()
        {
            return damage;
        }
        public void setDamage(int damage)
        {
            this.damage = damage;
        }
        public decimal getLife()
        {
            return life;
        }
        public void setLife(decimal life)
        {
            this.life = life;
        }

        public void RecebeDano(decimal dano)
        {
            if (dano > 0)
            {
                decimal v = this.getLife();
                v = v - dano;
                this.setLife(v);
            }
        }

        public void RecebeVida(decimal life)
        {
            if (life > 0)
            {
                decimal v = this.getLife();
                v = v + life;
                this.setLife(v);
            }
        }

        public void MostraPersonagem()
        {
            string v = "";
            Console.WriteLine("Personagem: " + this.getName());
            for (int i = 0; i < this.getLife(); i++)
            {
                v += "/";
            }
            Console.WriteLine("Vida: " + v);
        }

        public void RenderPersonagem()
        {
            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine("|");
                                aTimer = new System.Timers.Timer(5000);
                                
                                aTimer.AutoReset = true;
                                aTimer.Enabled = true;

                                break;
                            case 1:
                                Console.Clear();
                                Console.WriteLine("/");
                                aTimer = new System.Timers.Timer(5000);
                                
                                aTimer.AutoReset = true;
                                aTimer.Enabled = true;
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("-");
                                aTimer = new System.Timers.Timer(5000);
                               
                                aTimer.AutoReset = true;
                                aTimer.Enabled = true;
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("/");
                                aTimer = new System.Timers.Timer(5000);
                                
                                aTimer.AutoReset = true;
                                aTimer.Enabled = true;
                                break;                        
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
