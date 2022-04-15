using System;
using System.Collections.Generic;
using ApiFilmes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFilmes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController: ControllerBase
    {
        private static List<Filme> listaFilmes = new List<Filme>();
        private static int id = 1;
        [HttpPost]
        public IActionResult AdicionarFilme([FromBody]Filme filme){
            filme.Id= id++;
            listaFilmes.Add(filme);
            return CreatedAtAction(nameof(RetornaFilmePorID), new {Id = filme.Id}, filme);
        }

        [HttpGet]
        public IActionResult RetornarFilmes(){

            return Ok(listaFilmes);
        }

        [HttpGet("{id}")]
        public IActionResult RetornaFilmePorID(int id){
            Filme filme = new Filme();
            if(filme.Id == id){
                return Ok(filme);
            }
            return NotFound("");            
        }
        
    }
}