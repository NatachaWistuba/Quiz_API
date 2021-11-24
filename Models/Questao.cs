using System;

using System.Collections.Generic;

namespace API.Models
{
    public class Questao
    {
          public Questao( ) => CriadoEm = DateTime.Now;

          public int             Id                { get; set; }
          public string        Nquestao    { get; set; }
          public string        Pergunta     { get; set; }
          public string        RespostaC  { get; set; }
          public string        RespostaF1 { get; set; }
          public string        RespostaF2 { get; set; }
          public string        RespostaF3 { get; set; }
          //public string[]    RespostaF  { get; set; } = new string[3]; Não deu boa
          public int              Ponto         { get; set; }
          //public int              JogadorId   { get; set;}
          public DateTime   CriadoEm { get; set; }

          public override string ToString( ) =>
        $"Pergunta: {Pergunta} | Criado em: {CriadoEm}" ;
    }

}