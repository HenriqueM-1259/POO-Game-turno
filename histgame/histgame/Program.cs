using histgame.Game;
using System.Security.Cryptography;

bool GameAtivo = true;
Personagem p = new Personagem();
Personagem p2 = new Personagem();
p.setName("Personagem1");
p.setLife(100);
p2.setName("Personagem2");
p2.setLife(100);

Turno t1 = new Turno(p);
Turno t2 = new Turno(p2);
t1.AtivaEavez();
while (GameAtivo)
{
	Console.Clear();
	p.MostraPersonagem();
	p2.MostraPersonagem();
	if (t1.Eavez)
	{
		Console.WriteLine("E a vez do: " + p.getName());

        int dano = int.Parse(Console.ReadLine());
        p2.RecebeDano(dano);
        t1.DesativaEavez();
        t2.AtivaEavez();
    }
    Console.Clear();
    p.MostraPersonagem();
    p2.MostraPersonagem();
    if (t2.Eavez)
	{
       
        Console.WriteLine("E a vez do: " + p2.getName());
        int dano = int.Parse(Console.ReadLine());
        p.RecebeDano(dano);
        t2.DesativaEavez();
        t1.AtivaEavez();
    }

   
}

