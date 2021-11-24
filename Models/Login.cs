
using System;

namespace API.Models
{
    public class Login
    {
        public int      Id       { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int          JogadorId  { get; set;}
        public Jogador Jogador     { get; set; }

    }

}