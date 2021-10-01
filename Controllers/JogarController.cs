using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/Jogar")]
    public class JogarController : ControllerBase
    {
          //------------------------------------Banco De Dados--------------------------------------
        private readonly DataContext _context;
        public JogarController( DataContext context)
        {
            _context = context;
        }

         //------------------------Responder pergunta-------------------------
         //Validação de resposta recebida pelo jogador, Se resposta == questao.respostaC, do (Id) recebido.
        [HttpGet] //Get: api/jogar/getbyresposta/resposta?
        [Route("getbyresposta/{id}/{resposta}")]
       public IActionResult GetById([FromRoute] int id ,string resposta)
      {
          Questao questao =_context.Questoes.ToList( )[id - 1];
          //Jogador jogador = _context.Jogadores.ToList( )[id - 1];
          if(questao.RespostaC != resposta )
          {
              return NotFound("Resposta incorreta!!!");
          }
            return Ok("Resposta Correta: "+questao.RespostaC);
       }
       //falta relacionar com jogador para receber os pontos !!!


        //--------Buscar Pergunta por ID ( para mandar apenas 1 pergunta por vez para o FRONT )----------
        [HttpGet]// GET: api/jogar/questao
        [Route("questao/{id}")]
        public IActionResult List ([FromRoute] int id) {
            return  Ok(_context.Questoes.ToList( )[id - 1]);
        }

        /*
        //---------------------Método que caso a resposta seja a correta, jogador.pontuação == Ponto
        //recebendo id do jogar, id do jogador,
        [HttpPut] //PUT: api/jogar/updateJogadorPT
        [Route("updateJogadorPT/{id}/{idJogador}")]
        public IActionResult UpdatePT([FromBody]  int idJogador, int id)
        {
            Jogar jogar = _context.Jogadas.ToList( )[id - 1];
           Jogador jogador = _context.Jogadores.ToList( )[id - 1];
            if( jogar.SouN != "S" && jogador.Id == idJogador){
                return NotFound(false);
            }
            jogador.Pontuacao = 10;
            _context.Jogadores.Update(jogador);
            _context.SaveChanges( );
            return Ok(jogador);
        }
        */

    }
}