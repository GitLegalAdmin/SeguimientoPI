using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.Moneda;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaMonedaController : ControllerBase
    {
        [HttpGet("selectAll")]
        public IEnumerable<MonedaObject> SelectAll()
        {
            return Moneda.SelectAll();
        }
    }
}
