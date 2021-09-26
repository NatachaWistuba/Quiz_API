using System;

namespace API.Models
{
    public class Jogador
    {
        //Construtor
        public Jogador( ) => CriadoEm = DateTime.Now;

        //prop + TAB =  public int MyProperty { get; set; }
        public int Id { get; set; }
        public string        Nome        { get; set; }
        public string        Senha        { get; set; }
        public string        Email        { get; set; }
        public int             Pontuacao { get; set; }
        public DateTime CriadoEm  { get; set; } //Fazer using systen

        public override string ToString( ) =>
        $"Nome: {Nome} | e-mail: {Email} | Criado em: {CriadoEm}" ;

    }
}