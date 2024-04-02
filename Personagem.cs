using System;

public class Animal
{
    private string nome;
    private int idade;

    public Animal(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

public class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade)
    {
    }

    public override void FazerSom()
    {
        Console.WriteLine("Au Au!");
    }
}

public class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade)
    {
    }

    public override void FazerSom()
    {
        Console.WriteLine("Miau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instanciando objetos
        Cachorro cachorro1 = new Cachorro("Rex", 3);
        Gato gato1 = new Gato("Whiskers", 2);

        // Testando os métodos
        Console.WriteLine("Cachorro: " + cachorro1.Nome + " faz " );
        cachorro1.FazerSom();
        Console.WriteLine("Gato: " + gato1.Nome + " faz ");
        gato1.FazerSom();
    }
}