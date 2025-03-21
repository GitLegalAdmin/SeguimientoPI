using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.TipoEnvioFac;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaTipoEnvioFacController : ControllerBase
    {
        [HttpGet("selectAll")]
        public IEnumerable<TipoEnvioFacObject> SelectAll()
        {
            return TipoEnvioFac.SelectAll();
        }
    }
}
