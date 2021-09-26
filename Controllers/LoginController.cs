using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
          //------------------------------------Banco De Dados--------------------------------------
        private readonly DataContext _context; //para outro método poder receber o ( DataContext context) / readonly apenas para leitura
        public LoginController( DataContext context)
        {
            _context = context;
        }
        // Pegar login e senha
        // validar login e senha fazendo uma busca na lista de jogadore
        //Se login e senha confirmar PROSSEGUIR

    //-------------------------Buscar e Validação do Jogador por e-mail e senha--------------------
        [HttpGet]  //Get: api/jogador/getbyid/e-mail+senha
        [Route("getbylogin/{email}+{senha}")]
        public IActionResult GetById([FromRoute] string email, string senha)
        {
            Jogador jogador = _context.Jogadores.FirstOrDefault(jogador => jogador.Email == email && jogador.Senha == senha);
            if (jogador == null)
            {
                return NotFound("E-mail nao cadastrado ou senha incorreta!!! \n Click em CADASTRAR");
            }
           //Aqui retornar uma liberação (ainda não sei como vou fazer isso!!! F);
           return Ok("Cadastrado: "+jogador);
        }
    }
}