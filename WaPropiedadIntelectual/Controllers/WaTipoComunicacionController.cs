using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.TipoComunicacion;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaTipoComunicacionController : ControllerBase
    {
        [HttpGet("selectAll")]
        public IEnumerable<TipoComunicacionObject> SelectAll()
        {
            return TipoComunicacion.SelectAll();
        }
    }
}
