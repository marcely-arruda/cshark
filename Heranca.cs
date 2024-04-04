public class Produto {
    private String nome;
    private Decimal preco;
    private String descricao;
    private String categoria;
    
    public Produto(string nome,decimal preco,string descricao,string categoria) {
        Nome = nome;
        Preco = preco;
        Descricao = descricao;
        Categoria = categoria;
    }

    public string Nome {
        get{return nome;}
        set{nome = value;} 
    }
    public decimal Preco {
        get {return preco;}
        set {preco = value;}
    }
    public string Descricao {
        get {return descricao;}
        set {descricao = value;} 
     }
      public string Categoria {
        get {return categoria;}
        set {categoria = value;} 
     }

}

public class ConsoleGame : Produto {
    private int capacidadeArmazenamento;

    public ConsoleGame(string nome,decimal preco,string descricao,string categoria,int capacidadeArmazenamento) : base(nome,preco,descricao,categoria) {
         CapacidadeArmazenamento = capacidadeArmazenamento;
    }

    public string CapacidadeArmazenamento{
        get {return capacidadeArmazenamento;}
        set {capacidadeArmazenamento = value;}
    }
}

public class Jogo : Produto {
    private int genero;

    public Jogo(string nome,decimal preco,string descricao,string categoria,int genero) : base(nome,preco,descricao,categoria) {
         Genero = genero;
    }

    public string Genero{
        get {return genero;}
        set {genero = value;}
    }
}

public class Acessorio : Produto {
    private int Tipo;

    public Acessorio(string nome,decimal preco,string descricao,string categoria,int tipo) : base(nome,preco,descricao,categoria) {
         Tipo = tipo;
    }

    public string Tipo{
        get {return tipo;}
        set {tipo = value;}
    }
}

public class Colecionavel : Produto {
    private int colecionavel;

    public Colecionavel(string nome,decimal preco,string descricao,string categoria,int colecionavel) : base(nome,preco,descricao,categoria) {
         Colecionavel = colecionavel;
    }

    public string Colecionavel{
        get {return colecionavel;}
        set {colecionavel = value;}
    }
}

public class Program {
    public static void main (string[] args) {
        Produto produto;
        produto = new ConsoleGame("PlayStation5", 5.900,"Console de Vídeo Game PlayStation 5 Slim com 1 Tera de armazenamento","Console",1024000);

        Jogo jogo = new Jogo("Marvel s Spider-Man 2 PREMIUM" 299.9, "Jogo completo Marvel s Spider-Man 2 para PS5.", "Jogo PS5", "Ação e Aventura");

        Acessorio acessorio = new Acessorio("oculos","500.00","Oculos preto de boa qualidade","Beleza","Quadrados")
    }
}

public class Program {
    public static void main (string[] args) {
        Produto produto;
        produto = new ConsoleGame("PlayStation5", 5.900,"Console de Vídeo Game PlayStation 5 Slim com 1 Tera de armazenamento","Console",1024000);

        Jogo jogo = new Jogo("Marvel s Spider-Man 2 PREMIUM" 299.9, "Jogo completo Marvel s Spider-Man 2 para PS5.", "Jogo PS5", "Ação e Aventura");

        Acessorio acessorio = new Acessorio("oculos","500.00","Oculos preto de boa qualidade","Beleza","Quadrados")
    }
}