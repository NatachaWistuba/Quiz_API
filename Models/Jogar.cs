using System;

namespace API.Models
{
    public class Jogar
    {
        public int           Id              { get; set; }
        public string     Resposta    { get; set; }
        //public int          ponto          { get; set; }
        public int          QuestaoId  { get; set;}
        public Questao Questao     { get; set; }
    //    public int          LoginId       { get; set; }
    //    public Login     Login        { get; set; }
    }
}

//public string SouN           { get; set; }
