using apiData.Database;
using apiData.Database.Tables;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/bandas")]
    public class bandaController : ControllerBase
    {
        private readonly apiDbContext _db;
        public bandaController(apiDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("")]
        public IActionResult listarbandas()
        {
            var bandas = _db.bandas.ToList();

            return Ok(bandas);
        }
        [HttpPost]
        [Route("crear")]
        public IActionResult crearbandas([FromBody] banda body)
        {
            _db.bandas.Add(body);
            int r = _db.SaveChanges();
            if (r != 1)
            {
                return StatusCode(500);
            }
            return Ok(body);
        }
    }
}
