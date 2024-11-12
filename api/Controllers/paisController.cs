using apiData.Database;
using apiData.Database.Tables;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/paises")]
    public class paisController : ControllerBase
    {
        private readonly apiDbContext _db;
        public paisController(apiDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("")]
        public IActionResult listarpaiss()
        {
            var paiss = _db.pais.ToList();

            return Ok(paiss);
        }
        [HttpPost]
        [Route("crear")]
        public IActionResult crearpaiss([FromBody] pais body)
        {
            _db.pais.Add(body);
            int r = _db.SaveChanges();
            if (r != 1)
            {
                return StatusCode(500);
            }
            return Ok(body);
        }
    }
}
