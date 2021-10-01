
using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/Questao")]
    public class QuestaoController : ControllerBase
    {
         //------------------------------------Banco De Dados--------------------------------------
         private readonly DataContext _context;
         public QuestaoController( DataContext context)
         {
             _context = context;
         }


         //---------------------------Cadastrar Questao-----------------------
         [HttpPost]// POST: api/Questao/Create
         [Route("create")]
         public IActionResult Create ([FromBody] Questao questao)
         {
             _context.Questoes.Add(questao);
             _context.SaveChanges( );

             return Created(" ", questao);
         }


         //--------------------------Listar Questões---------------------------
        [HttpGet]// GET: api/questao/list
        [Route("list")]
        public IActionResult List ( ) =>  Ok(_context.Questoes.ToList( ));


        //--------------------------Deletar Questões--------------------------
        [HttpDelete] //DELETE: /api/questao/delete/nQuestão
        [Route("delete/{numero}")]
        public IActionResult Delete([FromRoute] string numero)
        {
            //Buscar um objeto na tabela de questao com base no nome
            Questao questao = _context.Questoes.FirstOrDefault(
                questao => questao.Nquestao == numero  //procurando cliente pelo nome na lista, irá trazer o que achar primeiro
            );
            if (questao == null)
            {
                return NotFound( );
            }
            _context.Questoes.Remove(questao); //Deletar o produto encontrado
            _context.SaveChanges( ); //Salvar
            return Ok( );
        }


         //--------------------------Editar Questao-----------------------------
        [HttpPut] //PUT: api/questao/update
        [Route("update")]
        public IActionResult Update([FromBody] Questao questao)
        {
            _context.Questoes.Update(questao);
            _context.SaveChanges();
            return Ok(questao);
        }

      //-----------------Buscar Questao por ID--------------------
      [HttpGet]
      [Route("getbyid/{id}")]
      public IActionResult GetById ([FromRoute] int id)
      {
        Questao questao = _context.Questoes.Find(id);
        if (questao == null)
        {
          return NotFound();
        }

        return Ok(questao);
      }



    }
}
