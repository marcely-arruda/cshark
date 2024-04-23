using System;

public abstract class Soldado 
{

    private string nome;
    private int nivel;
    private double pontuacao; 
    private double vida;
    private double forca;
    private double agilidade;
    private double inteligencia;
    private string [] armasEquipamentos;


    public Soldado(string nome,int nivel,double pontuacao,double vida,double forca,double agilidade,double inteligencia,string[] armasEquipamentos)
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

    // Métodos
    public void Mover(string direcao, double distancia){
        Console.WriteLine($"{GetNome()} esta se movendo na direcao {direcao} por {distancia} passos.");
    }

    public void ReceberDano(double dano){
        vida -= dano;
        if (vida <= 0){
            Morrer();
        }else{
            Console.WriteLine($"{GetNome()} recebeu {dano} de dano. Vida restante: {GetVida()}");
        }
    }

    public void UsarHabilidade(string habilidade, Soldado alvo){
        Console.WriteLine($"{GetNome()} esta usando a habilidade {habilidade} em {alvo.GetNome()}."); 
    }

    public abstract void SubirDeNivel();
    public abstract void Morrer();
        
}


public class Sargento : Soldado {
    public Sargento(string nome, int nivel, double pontuacao, double vida, double forca, double agilidade, double inteligencia, string[] armasEquipamentos) : base(nome, nivel, pontuacao, vida, forca, agilidade, inteligencia, armasEquipamentos) {}
    public override void SubirDeNivel() {
        Console.WriteLine($"{GetNome()} subir de nivel para Cabo!");
    }

    public override void Morrer() {
        Console.WriteLine($"{GetNome()} após subir de nivel o cabo morreu!");
    }
}
public class Cabo : Soldado {
    public Cabo(string nome, int nivel, double pontuacao, double vida, double forca, double agilidade, double inteligencia, string[] armasEquipamentos) : base(nome, nivel, pontuacao, vida, forca, agilidade, inteligencia, armasEquipamentos) {}

    public override void Morrer() {
        Console.WriteLine($"{GetNome()} morrer!");
    }
    public override void SubirDeNivel() {
        Console.WriteLine($"{GetNome()} subir de nivel!");
    }
}
class Program{
    static void Main(string[] args){
        Sargento sargento = new Sargento("Maysa", 100,128,5,67,654,90,new string[] {"ak47", "fuzil", "pistola" });

            Console.WriteLine("Sargento Heroi");
            Console.WriteLine($"Nome: {sargento.GetNome()}");
            Console.WriteLine($"Nivel: {sargento.GetNivel()}");
            Console.WriteLine($"Pontuacao do sargento: {sargento.GetPontuacao()}");
            Console.WriteLine($"Vida: {sargento.GetVida()}");
            Console.WriteLine($"Forca: {sargento.GetForca()}");
            Console.WriteLine($"Agilidade: {sargento.GetAgilidade()}");
            Console.WriteLine($"Inteligencia: {sargento.GetInteligencia()}");
            Console.WriteLine($"Armas e Equipamentos: {string.Join(",",sargento.GetArmasEquipamentos())}");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");

            Cabo cabo = new Cabo("Sofia", 100,128,5,67,654,90,new string[] {"ak47", "fuzil", "pistola" });
            Console.WriteLine("Cabo Inimigo");  
            Console.WriteLine($"Nome: {cabo.GetNome()}");  
            Console.WriteLine($"Nivel: {cabo.GetNivel()}");
            Console.WriteLine($"Pontuacao do cabo: {cabo.GetPontuacao()}");
            Console.WriteLine($"Vida: {cabo.GetVida()}");
            Console.WriteLine($"Forca: {cabo.GetForca()}");
            Console.WriteLine($"Agilidade: {cabo.GetAgilidade()}");
            Console.WriteLine($"Inteligencia: {cabo.GetInteligencia()}");
            Console.WriteLine($"Armas e Equipamentos: {string.Join(",",cabo.GetArmasEquipamentos())}");

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");

            sargento.Mover("norte",10);
            cabo.Mover("sul",10);
            sargento.Mover("norte",15);
            sargento.UsarHabilidade("Multi-Batarangue",cabo);
            cabo.ReceberDano(50);
            sargento.SetPontuacao(50);
            Console.WriteLine($"Pontuacao do sargento : {sargento.GetPontuacao()}");
            cabo.UsarHabilidade("Gas do Riso",sargento);
            cabo.SetPontuacao(30);
            Console.WriteLine($"Pontuacao da cabo : {cabo.GetPontuacao()}");
            sargento.UsarHabilidade("Ultra Bat-Garra",cabo);
            cabo.ReceberDano(999);
            sargento.SetPontuacao(100);
            Console.WriteLine($"Pontuacao do sargento : {sargento.GetPontuacao()}");
            sargento.SubirDeNivel();
            Console.ReadLine();

    }
}

