using System.Collections.Generic;
using System.Linq;
using EventMaker.Domain;
using EventMaker.Persistence.Contextos;
using Microsoft.AspNetCore.Mvc;

namespace EventMaker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {

    
        private readonly EventMakerContext context;

        public EventosController(EventMakerContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return context.Eventos.FirstOrDefault(evento => evento.Id == id);
        }


        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id = {id}";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }
}
