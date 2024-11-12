using apiData.Database;
using apiData.Database.Tables;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/album")]
    public class albumController : ControllerBase
    {
        private readonly apiDbContext _db;
        public albumController(apiDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("")]
        public IActionResult listaralbums()
        {
            var albums = _db.albums.ToList();

            return Ok(albums);
        }
        [HttpPost]
        [Route("crear")]
        public IActionResult crearalbums([FromBody] album body)
        {
            _db.albums.Add(body);
            int r = _db.SaveChanges();
            if (r != 1)
            {
                return StatusCode(500);
            }
            return Ok(body);
        }
    }
}
