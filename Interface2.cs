using System;

interface IAtacante {
    void Atacar();
}
public abstract class Heroi
{
    private string nome;
    private int nivel;
    private double pontuacao; 
    private double vida;
    private double forca;
    private double agilidade;
    private double inteligencia;
    private string[] armasEquipamentos;

    public Heroi(string nome,int nivel,double pontuacao,double vida,double forca,double agilidade,double inteligencia,string[] armasEquipamentos)
    {
        this.nome = nome;
        this.nivel = nivel;
        this.pontuacao = pontuacao;
        this.vida = vida;
        this.forca = forca;
        this.agilidade = agilidade;
        this.inteligencia = inteligencia;
        this.armasEquipamentos = armasEquipamentos;
    }

    public string GetNome(){
        return nome;
    }

    public void SetNome(string nome){
        this.nome = nome;
    }

    public int GetNivel(){
        return nivel;
    }

    public void SetNivel(int nivel){
        this.nivel = nivel;
    }

    public double GetPontuacao(){
        return pontuacao;
    }

    public void SetPontuacao(double pontuacao){
        this.pontuacao = pontuacao;
    }

    public double GetVida(){
        return vida;
    }

    public void SetVida(double vida){
        this.vida = vida;
    }

    public double GetForca(){
        return forca;
    }

    public void SetForca(double forca){
        this.forca = forca;
    }

    public double GetAgilidade(){
        return agilidade;
    }

    public void SetAgilidade(double agilidade){
        this.agilidade = agilidade;
    }     

    public double GetInteligencia(){
        return inteligencia;
    }

    public void SetInteligencia (double inteligencia){
        this.inteligencia = inteligencia;
    }

    public string[] GetArmasEquipamentos(){
        return armasEquipamentos;
    }

    public void SetArmasEquipamentos(string[] armasEquipamentos){
        this.armasEquipamentos = armasEquipamentos;
        
    }

    public abstract void Especial();
}
class Mago : Heroi, IAtacante {
    public Mago(string nome,int nivel,double pontuacao,double vida,double forca,double agilidade,double inteligencia,string[] armasEquipamentos) {}
    public void Atacar() {
        Console.WriteLine("Mago lança bola de fogo!");
    }
    public override void Especial() {
        Console.WriteLine("Mago lança bola de fogo especial!");
    }
}


class Arqueiro : Heroi,IAtacante {
        public Arqueiro(string nome,int nivel,double pontuacao,double vida,double forca,double agilidade,double inteligencia,string[] armasEquipamentos) {}
    public void Atacar() {
        Console.WriteLine("Arqueiro dispara flechas!");
    }
    public override void Especial() {
        Console.WriteLine("Arqueiro dipara flecha especiais!");
    }
}

class Guerreiro : Heroi,IAtacante {
    public Guerreiro(string nome,int nivel,double pontuacao,double vida,double forca,double agilidade,double inteligencia,string[] armasEquipamentos) {}
    public void Atacar() {
        Console.WriteLine("Gerreiro dispara flechas!");
    }

    public override void Especial() {
        Console.WriteLine($"{GetNome()} Gerreiro dispara flechas especiais!");
    }
}

class Program{
    static void Main(string[] args){
        Guerreiro guerreiro = new Guerreiro("Bernardo", 100,128,5,67,654,90,new string[] {"ak47", "fuzil", "pistola" });

            Console.WriteLine("Guerreiro Heroi");
            Console.WriteLine($"Nome: {guerreiro.GetNome()}");
            Console.WriteLine($"Nivel: {guerreiro.GetNivel()}");
            Console.WriteLine($"Pontuacao do guerreiro: {guerreiro.GetPontuacao()}");
            Console.WriteLine($"Vida: {guerreiro.GetVida()}");
            Console.WriteLine($"Forca: {guerreiro.GetForca()}");
            Console.WriteLine($"Agilidade: {guerreiro.GetAgilidade()}");
            Console.WriteLine($"Inteligencia: {guerreiro.GetInteligencia()}");
            Console.WriteLine($"Armas e Equipamentos: {string.Join(",",guerreiro.GetArmasEquipamentos())}");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");

            Arqueiro arqueiro = new Arqueiro("Sofia", 100,128,5,67,654,90,new string[] {"ak47", "fuzil", "pistola" });
            Console.WriteLine("Arqueiro Inimigo");  
            Console.WriteLine($"Nome: {arqueiro.GetNome()}");  
            Console.WriteLine($"Nivel: {arqueiro.GetNivel()}");
            Console.WriteLine($"Pontuacao do arqueiro: {arqueiro.GetPontuacao()}");
            Console.WriteLine($"Vida: {arqueiro.GetVida()}");
            Console.WriteLine($"Forca: {arqueiro.GetForca()}");
            Console.WriteLine($"Agilidade: {arqueiro.GetAgilidade()}");
            Console.WriteLine($"Inteligencia: {arqueiro.GetInteligencia()}");
            Console.WriteLine($"Armas e Equipamentos: {string.Join(",",arqueiro.GetArmasEquipamentos())}");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");

            Mago mago = new Mago("Maysa", 100,128,5,67,654,90,new string[] {"ak47", "fuzil", "pistola" });
            Console.WriteLine("Mago Inimigo");  
            Console.WriteLine($"Nome: {mago.GetNome()}");  
            Console.WriteLine($"Nivel: {mago.GetNivel()}");
            Console.WriteLine($"Pontuacao do mago: {mago.GetPontuacao()}");
            Console.WriteLine($"Vida: {mago.GetVida()}");
            Console.WriteLine($"Forca: {mago.GetForca()}");
            Console.WriteLine($"Agilidade: {mago.GetAgilidade()}");
            Console.WriteLine($"Inteligencia: {mago.GetInteligencia()}");
            Console.WriteLine($"Armas e Equipamentos: {string.Join(",",mago.GetArmasEquipamentos())}");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");

            guerreiro.SetPontuacao(50);
            Console.WriteLine($"Pontuacao do guerreiro : {guerreiro.GetPontuacao()}");
            arqueiro.SetPontuacao(30);
            Console.WriteLine($"Pontuacao da arqueiro : {arqueiro.GetPontuacao()}");
            guerreiro.SetPontuacao(100);
            Console.WriteLine($"Pontuacao do guerreiro : {guerreiro.GetPontuacao()}");
            Console.ReadLine();

            guerreiro.Atacar();
            guerreiro.Especial();

            arqueiro.Atacar();
            arqueiro.Especial();

            mago.Atacar();
            mago.Especial();
    }
}


    


