using apiData.Database;
using apiData.Database.Tables;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/artistas")]
    public class artistaController : ControllerBase
    {
        private readonly apiDbContext _db;
        public artistaController(apiDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("")]
        public IActionResult listarartistas()
        {
            var artistas = _db.artists.ToList();

            return Ok(artistas);
        }
        [HttpPost]
        [Route("crear")]
        public IActionResult crearartistas([FromBody] artista body)
        {
            _db.artists.Add(body);
            int r = _db.SaveChanges();
            if (r != 1)
            {
                return StatusCode(500);
            }
            return Ok(body);
        }
    }
}
