using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;


namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento() {
                    EventoId = 1,
                    Tema = "Angula 11 e .NET 5",
                    Local = "Caxias",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                    ImagemURL = "foto.png"
                },

                new Evento() {
                    EventoId = 2,
                    Tema = "Node e .NET 5",
                    Local = "Caxias",
                    Lote = "2º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                    ImagemURL = "foto2.png"
                }
            };

        public EventoController()
        {
          
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GeById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

         [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo POST";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"exemplo PUT com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"exemplo DELETE com id = {id}";
        }
        
    }
}
