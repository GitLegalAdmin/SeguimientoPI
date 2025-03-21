using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.Responsable;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaResponsableController : ControllerBase
    {
        [HttpGet("selectAll")]
        public IEnumerable<ResponsableObject> SelectAll()
        {
            return Responsable.SelectAll();
        }
    }
}
