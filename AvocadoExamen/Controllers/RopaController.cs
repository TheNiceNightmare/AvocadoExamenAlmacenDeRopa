using AvocadoExamen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvocadoExamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RopaController : ControllerBase
    {
        private static List<Ropa> _ropa = new List<Ropa> {

            new Ropa
            {
                Id = 1,
                Tipo = "Camiseta",
                Marca = "Gucci"
            },
            new Ropa
            {
                Id = 2,
                Tipo = "Falda",
                Marca = "Forever 21"
            },
            new Ropa
            {
                Id = 3,
                Tipo = "Hoddie",
                Marca = "H&M"
            },
            new Ropa
            {
                Id = 4,
                Tipo = "Pantalón",
                Marca = "Levis"
            },
            new Ropa
            {
                Id = 5,
                Tipo = "Gorra",
                Marca = "PsychoBunny"
            },
            new Ropa
            {
                Id = 6,
                Tipo = "Ropa interior",
                Marca = "Calvin Klein"
            },


        };

        [HttpGet]
        public IEnumerable<Ropa> GetAllRopa()
        {
            return _ropa;
        }

        [HttpGet("{id}")]
        public IActionResult GetRopaById(int id)
        {
            var ropa = _ropa.Find(ropa => ropa.Id == id);

            if (ropa == null)
            {
                return NotFound($"No se encontró ningúna prenda con el ID {id}."); // Devuelve un código 404 con un mensaje
            }

            return Ok(ropa);
        }
    }
}
