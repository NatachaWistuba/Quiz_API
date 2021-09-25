using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/jogador")]
    public class JogadorController : ControllerBase //fazendo com que o ProdutoController erde de ControllerBase(vai me da suporte da parte web)
    {
        //------------------------------------Banco De Dados--------------------------------------
        private readonly DataContext _context; //para outro método poder receber o ( DataContext context) / readonly apenas para leitura
        public JogadorController( DataContext context)
        {
            _context = context;
        }

        //---------------------------Cadastrar jogador-----------------------
        [HttpPost]// POST: api/jogador/Create
        [Route("create")]
        public IActionResult Create ([FromBody] Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges( ); //salva todas as mudanças que foram feitas
            return Created(" ", jogador);
        }

        //--------------------------Lista Jogadores---------------------------
         // GET: api/jogador/list
        [HttpGet] //Se não colocar nd ele é Get por padrão
        [Route("list")]
        public IActionResult List ( ) =>  Ok(_context.Jogadores.ToList( ));

        //-------------------------Buscar Jogador por e-mail--------------------
        //Get: api/jogador/getbyid/e-mail?
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Jogador jogador = _context.Jogadores.Find(id);
            if (jogador == null)
            {
                return NotFound( );
            }
            return Ok(jogador);
        }

        //--------------------------Deletar Jogador--------------------------
        //DELETE: /api/jogador/delete/bolinho
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {
            //Buscar um objeto na tabela de jogador com base no nome
            Jogador jogador = _context.Jogadores.FirstOrDefault(
                jogador => jogador.Nome == name  //procurando cliente pelo nome na lista, irá trazer o que achar primeiro
            );
            if (jogador == null)
            {
                return NotFound( );
            }
            _context.Jogadores.Remove(jogador); //Deletar o produto encontrado
            _context.SaveChanges( ); //Salvar
            return Ok( );
        }

        //--------------------------Editar Jogador-----------------------------
        //PUT: api/jogador/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Jogador jogador)
        {
            _context.Jogadores.Update(jogador);
            _context.SaveChanges();
            return Ok(jogador);
        }


    }
}