using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.Cliente;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaClienteController : ControllerBase
    {
        [HttpGet("selectAll")]
        public IEnumerable<ClienteObject> SelectAll()
        {
            return Cliente.SelectAll();
        }
    }
}
