using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.TipoTarifa;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaTipoTarifaController : ControllerBase
    {
        [HttpGet("selectAll")]
        public IEnumerable<TipoTarifaObject> SelectAll()
        {
            return TipoTarifa.SelectAll();
        }
    }
}
