using System;
public abstract class Personagem {
    public string Nome { get; set; }
    public int Vida { get; set; }
    public Personagem(string nome, int vida) {
        Nome = nome;
        Vida= vida;
    }
    public abstract void Atacar();
    public void ReceberDano(int dano) {
        Vida -= dano;
        Console.WriteLine($"{Nome} recebeu {dano} de dano e agora tem {Vida} de vida.");
        if (Vida <= 0) {
            Morrer();
        }
}
public void Morrer() {
    Console.WriteLine($"{Nome} morreu!");
    }
}
public class Guerreiro : Personagem {
    public Guerreiro(string nome, int vida) : base(nome, vida) {}
    public override void Atacar() {
        Console.WriteLine($"{Nome} atacar com sua espada!");
    }
}
public class Mago : Personagem {
    public Mago(string nome, int vida) : base(nome, vida) {}

    public override void Atacar () {
        Console.WriteLine($"{Nome} lança um fetiço mágico!");
    }
    }
