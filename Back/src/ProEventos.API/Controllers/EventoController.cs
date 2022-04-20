using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

//VERBOS HTTP

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

 private readonly DataContext _context;
public EventoController  (DataContext context)
{
    this._context = context;
}

[HttpGet]
public IEnumerable<Evento> Get() //retornará todos eventos
{
    return _context.Eventos;
}

[HttpGet("{id}")]
public Evento GetById(int id) // retornará um evento especifico pelo id
{
    return _context.Eventos.FirstOrDefault(
        evento => evento.EventoId == id
        );
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