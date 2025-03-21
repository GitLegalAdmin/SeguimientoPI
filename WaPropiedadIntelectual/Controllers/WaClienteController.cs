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

        [HttpPost("Merge")]
        public ClienteObject Merge([FromBody] ClienteObject _cliente)

        {
            _cliente.Usuarioregistra = User.Identity.Name;
            return Cliente.Merge(_cliente);
        }

        [HttpGet("Delete")]
        public void Delete(int Id)
        {
            Cliente.Delete(Id);
        }
    }
}
