using apiData.Database;
using apiData.Database.Tables;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class generoController : ControllerBase
    {
        private readonly apiDbContext _db;
        public generoController(apiDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("")]
        public IActionResult listargeneros()
        {
            var generos = _db.generoMusicals.ToList();

            return Ok(generos);
        }
        [HttpPost]
        [Route("crear")]
        public IActionResult creargeneros([FromBody] generoMusical body)
        {
            _db.generoMusicals.Add(body);
            int r = _db.SaveChanges();
            if (r != 1)
            {
                return StatusCode(500);
            }
            return Ok(body);
        }
    }
}
