using Dapper;
using System.Data;

namespace WaPropiedadIntelectual.Models.TipoEnvioFac
{
    public class TipoEnvioFac
    {
        public static IEnumerable<TipoEnvioFacObject> SelectAll()
        {
            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@TipoEnvioFacId", TipoEnvioFacId);

                cnn.Open();
                var res = cnn.Query<TipoEnvioFacObject>("usp_tipoenviofac_SelectAll", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return res;
            }
        }
    }
}
