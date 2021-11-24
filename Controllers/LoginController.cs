using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        //------------------------------------Banco De Dados--------------------------------------
        private readonly DataContext _context; //para outro método poder receber o ( DataContext context) / readonly apenas para leitura
        public LoginController( DataContext context )
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

        //---------------------------Cadastrar um login-----------------------
        [HttpPost]// POST: api/login/Create
        [Route("create")]
        public IActionResult Create ([FromBody] Login login)
        {
            Jogador jogadorEncontrado = _context.Jogadores.FirstOrDefault(jogador => jogador.Email == login.Email && jogador.Senha == login.Senha);
            if ( jogadorEncontrado == null ){
                return NotFound("E-mail nao cadastrado ou senha incorreta!!! \n Click em CADASTRAR");
            }
            login.JogadorId = jogadorEncontrado.Id;
            login.Jogador = _context.Jogadores.Find(login.JogadorId);
             _context.Connected.Add( login );
             _context.SaveChanges( ); //salva todas as mudanças que foram feitas
            return Created(" E-mail e Senha corretos ", login);
        }

        //--------------------------Lista login ---------------------------
        [HttpGet]  // GET: api/login/list
        [Route("list")]
        public IActionResult List ( ) =>  Ok(_context.Connected
        .Include( l => l.Jogador)
        .ToList( ));


        //--------------------------Deletar Login (Sair)--------------------------
        [HttpDelete] //api/login/delete/id
        [Route("delete")]
        public IActionResult Delete([FromRoute] int id)
        {
            //Buscar um objeto na tabela de jogador com base no email
            Login login = _context.Connected.Find(1);
            if (login == null)
            {
                return NotFound( );
            }
            _context.Connected.Remove(login); //Deletar o produto encontrado
            _context.SaveChanges( ); //Salvar
            return Ok( );
        }
    }
}
