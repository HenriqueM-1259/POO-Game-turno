using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histgame.Game
{
    interface IPersonagem
    {
        public abstract void RecebeDano(decimal dano);
        public abstract void RecebeVida(decimal life);

    }
}
