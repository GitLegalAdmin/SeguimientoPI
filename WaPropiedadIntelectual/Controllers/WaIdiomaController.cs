using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.Idioma;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaIdiomaController : ControllerBase
    {
        [Authorize]
        [HttpGet("selectAll")]
        public  IEnumerable<IdiomaObject> SelectAll()
        {
            return Idioma.SelectAll();
        }
    }
}
