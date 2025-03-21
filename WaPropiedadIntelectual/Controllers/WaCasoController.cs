using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.Caso;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaCasoController : ControllerBase
    {
        [HttpGet("selectAll")]
        public IEnumerable<CasoObject> SelectAll()
        {
            return Caso.SelectAll();
        }

        [HttpPost("Merge")]
        //public CasoObject Merge([FromBody] CasoObject _caso)

        //{
        //    _caso.Usuarioregistra = User.Identity.Name;
        //    return Caso.Merge(_caso);
        //}

        [HttpGet("Delete")]
        public void Delete(int Id)
        {
            Caso.Delete(Id);
        }
    }
}
