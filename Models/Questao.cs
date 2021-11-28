using System;

using System.Collections.Generic;

namespace API.Models
{
    public class Questao
    {
          public Questao( ) => CriadoEm = DateTime.Now;

          public int             Id                { get; set; }
          public string        Pergunta     { get; set; }
          public string        RespostaCerta  { get; set; }
          public string        Resposta1 { get; set; }
          public string        Resposta2 { get; set; }
          public string        Resposta3 { get; set; }
          public string        Resposta4 { get; set; }
          public int              Ponto         { get; set; }
        public int               CategoriaId { get; set;}
        public Categoria   Categoria     { get; set; }
          public DateTime   CriadoEm { get; set; }

          public override string ToString( ) =>
        $"Pergunta: {Pergunta} | Criado em: {CriadoEm}" ;
    }

}