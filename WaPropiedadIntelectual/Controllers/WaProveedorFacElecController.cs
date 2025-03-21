using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models.ProveedorFacElec;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaProveedorFacElecController : ControllerBase
    {
        [HttpGet("selectAll")]
        public IEnumerable<ProveedorFacElecObject> SelectAll()
        {
            return ProveedorFacElec.SelectAll();
        }
    }
}
