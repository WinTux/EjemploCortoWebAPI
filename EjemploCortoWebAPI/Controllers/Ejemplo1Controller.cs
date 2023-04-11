using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace EjemploCortoWebAPI.Controllers
{
    [Route("api/ejemplo1")]
    public class Ejemplo1Controller : Controller
    {
        [HttpGet("prueba1")] // http://www.pepe.com/api/ejemplo1/prueba1
        public async Task<IActionResult> prueba1() {
            try
            {
                return Ok("Esta es una prueba");
            }
            catch {
                return BadRequest();
            }
        }
        [Produces("text/html")]
        [HttpGet("prueba2")] // http://www.pepe.com/api/ejemplo1/prueba2
        public async Task<IActionResult> prueba2()
        {
            try
            {
                return Ok("<h2><b><i>Esta es otra prueba</i></b></h2>");
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("prueba3/{val}")] // http://www.pepe.com/api/ejemplo1/prueba1
        public async Task<IActionResult> prueba3(string val)
        {
            try
            {
                return Ok("Buenas noches señor "+ val);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
