using Microsoft.AspNetCore.Mvc;
using Peliculas.Shared.Entidades;
using System.Threading.Tasks;

namespace Peliculas.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController: ControllerBase
    {
        //Inyectar dependencias/Creacion de campo
        private readonly ApplicationDbContext context;

        public PersonasController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Post(Persona persona)
        {
            context.Add(persona);
            await context.SaveChangesAsync();
            return persona.Id;
        }
    }
}
