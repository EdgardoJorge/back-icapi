using apiData.Database;
using apiData.Database.Tables;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/canciones")]
    public class cancionController : ControllerBase
    {
        private readonly apiDbContext _db;
        public cancionController(apiDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("")]
        public IActionResult listarcancions()
        {
            var cancions = _db.cancion.ToList();

            return Ok(cancions);
        }
        [HttpPost]
        [Route("crear")]
        public IActionResult crearcancions([FromBody] cancion body)
        {
            _db.cancion.Add(body);
            int r = _db.SaveChanges();
            if (r != 1)
            {
                return StatusCode(500);
            }
            return Ok(body);
        }
    }
}
