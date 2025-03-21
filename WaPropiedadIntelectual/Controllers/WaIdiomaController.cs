using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.Cliente;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaIdiomaController : ControllerBase
    {
        [Authorize]
        [HttpGet("selectAll")]
        public  IEnumerable<tipoTarifaObject> SelectAll()
        {
            return Idioma.SelectAll();
        }
    }
}
