using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController(ILogger<EventoController> logger)
        {
          
        }

        [HttpGet]
        public string Get()
        {
            return "exempo de GET";
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
