using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

     [ApiController]
    [Route("api/Categoria")]
    public class CategoriaController  : ControllerBase
    {
        //------------------------------------Banco De Dados--------------------------------------
         private readonly DataContext _context;
         public CategoriaController( DataContext context)
         {
             _context = context;
         }

         //---------------------------Cadastrar Questao-----------------------
         [HttpPost]// POST: api/Categoria/Create
         [Route("create")]
         public IActionResult Create ([FromBody] Categoria categoria)
         {
             _context.Categorias.Add(categoria);
             _context.SaveChanges( );

             return Created(" ", categoria);
         }

         //--------------------------Listar Categoria---------------------------
        [HttpGet]// GET: api/categoria/list
        [Route("list")]
        public IActionResult List ( ) =>  Ok(_context.Categorias.ToList( ));

        //--------------------------Deletar Categoria--------------------------
        [HttpDelete] //DELETE: /api/categoria/delete/id
        [Route("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(
                categoria => categoria.Id == id
            );
            if (categoria == null)
            {
                return NotFound( );
            }
            _context.Categorias.Remove(categoria); //Deletar o produto encontrado
            _context.SaveChanges( ); //Salvar
            return Ok( );
        }



    }
}