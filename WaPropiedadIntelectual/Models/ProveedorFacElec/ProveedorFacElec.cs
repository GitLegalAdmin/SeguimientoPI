using Dapper;
using System.Data;

namespace WaPropiedadIntelectual.Models.ProveedorFacElec
{
    public class ProveedorFacElec
    {
        public static IEnumerable<ProveedorFacElecObject> SelectAll()
        {
            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@ProveedorFacElecId", ProveedorFacElecId);

                cnn.Open();
                var res = cnn.Query<ProveedorFacElecObject>("usp_proveedorfacelec_SelectAll", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return res;
            }
        }
    }
}
