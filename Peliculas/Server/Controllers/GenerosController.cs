using Microsoft.AspNetCore.Mvc;
using Peliculas.Shared.Entidades;
using System.Threading.Tasks;

namespace Peliculas.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenerosController: ControllerBase
    {
        //Inyectar dependencias/Creacion de campo
        private readonly ApplicationDbContext context;
               
        public GenerosController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Post(Genero genero)
        {
            context.Add(genero);
            await context.SaveChangesAsync();
            return genero.Id;
        }
    }
}
