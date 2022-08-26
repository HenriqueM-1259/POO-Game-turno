using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histgame.Game
{
    internal class Turno
    {
        private Personagem Personagem { get; set; }
        public bool Eavez;
        public Turno(Personagem personagem)
        {
            Personagem = personagem;
            Eavez = false;
        }

        public void AtivaEavez()
        {
            this.Eavez = true;
        }
        public void DesativaEavez()
        {
            this.Eavez = false;
        }
    }
}
