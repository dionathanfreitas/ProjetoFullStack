using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStack.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FullStack.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }
        
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento(){
               EventoID = 1,
               Tema = "FullStack com .Net + Angular",
               Local = "Florianópolis - SC",
               Lote = "1° Lote",
               QtdPessoas = 300,
               DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
               ImagemURL = "foto.png"

           },
           new Evento(){
               EventoID = 2,
               Tema = "FullStack o caminho da assertividade",
               Local = "São Paulo - SP",
               Lote = "2° Lote",
               QtdPessoas = 500,
               DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
               ImagemURL = "foto2.png"

           }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet ("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(_evento =>_evento.EventoID == id );
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }

         [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de Put com id = {id}";
        }

          [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de Delete com id = {id}";
        }
    }
}
