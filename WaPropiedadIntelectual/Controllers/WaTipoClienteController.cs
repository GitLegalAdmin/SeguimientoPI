using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.TipoCliente;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaTipoClienteController : ControllerBase
    {
        [HttpGet("selectAll")]
        public IEnumerable<TipoClienteObject> SelectAll()
        {
            return TipoCliente.SelectAll();
        }
    }
}
