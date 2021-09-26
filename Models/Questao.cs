using System;

namespace API.Models
{
    public class Questao
    {
          public Questao( ) => CriadoEm = DateTime.Now;

          public int Id { get; set; }
          public string       Nquestao { get; set; }
          public string       Pergunta  { get; set; }
          public string       Resposta  { get; set; } //Aqui deve ser um Array, guardar mais de uma resposta
          public int             Ponto       { get; set; }
          public DateTime CriadoEm { get; set; }

          public override string ToString( ) =>
        $"Pergunta: {Pergunta} | Respostas: {Resposta} | Criado em: {CriadoEm}" ;
    }
}