public class Pessoa {
    private String nome;
    private Decimal idade;
    private String descricao;
    private String altura;
    
    public Pessoa(string nome,decimal idade,string descricao,string altura) {
        Nome = nome;
        Idade = idade;
        Descricao = descricao;
        Altura0 = altura;
    }

    public string Nome {
        get{return nome;}
        set{nome = value;} 
    }
    public decimal Idade {
        get {return idade;}
        set {idade= value;}
    }
    public string Descricao {
        get {return descricao;}
        set {descricao = value;} 
     }
      public string Altura {
        get {return altura;}
        set {altura = value;} 
     }
    public void Atacar () {
        Console.WriteLine("Ataque básico!");
    }
    public void Atacar(string habilidade){
        Console.WriteLine("Ataque especial" + habilidade);
    }
}

public class Estudante : Pessoa {
    private string genero;

    public Estudante(string nome,decimal idade,string descricao,string altura,string genero) : base(nome,idade,descricao,altura) {
         Genero = genero;
    }

    public string Genero{
        get {return genero;}
        set {genero = value;}
    }
    public void Atacar() {
         Console.WriteLine("Estudante ataca");
    }
}

public class Program {
    public static void main (string[] args) {
       
        Estudante estudante = new Estudante("Beatriz", 31, "Estudante exemplar da escola", 1.50, "Feminino");
        estudante.Atacar();
        estudante.Atacar("Força");
    }
}