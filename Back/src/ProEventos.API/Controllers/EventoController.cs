using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

//VERBOS HTTP

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento() { 
                EventoId = 1, 
                tema = "Angular 11 e .net 5",
                local = "Belo Horizonte",
                Lote = "1° lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd-MM-yyyy"),
                ImagemURL = "foto.png"
            },

            new Evento() { 
                EventoId = 2, 
                tema = "novidades",
                local = "São Paulo",
                Lote = "2° lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd-MM-yyyy"),
                ImagemURL = "foto1.png"

            }
        };
        public EventoController  ()
        {
        }

        [HttpGet]
        public IEnumerable <Evento> Get() //retornará todos eventos
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable <Evento> GetById(int id) // retornará um evento especifico pelo id
        {
           return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(string id)
        {
            return $"Exemplo de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            return $"Exemplo de delete com id = {id}";
        }

    }
}