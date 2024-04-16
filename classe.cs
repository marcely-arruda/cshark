using System;

public class Personagem 
{

    private string nome;
    private int nivel;
    private double pontuacao; 
    private double vida;
    private double forca;
    private double agilidade;
    private double inteligencia;
    private double [] armasEquipamentos;


    public Personagem(string nome,int nivel,double pontuacao,double vida,double forca,double agilidade,double inteligencia,string[] armasEquipamentos)
    {
        this.nome = nome;
        this.nivel = nivel;
        this.pontuacao = pontuacao;
        this.vida - vida;
        this.forca = forca
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

}