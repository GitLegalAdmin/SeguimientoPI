using Dapper;
using System.Data;

namespace WaPropiedadIntelectual.Models.TipoTarifa
{
    public class TipoTarifa
    {
        public static IEnumerable<TipoTarifaObject> SelectAll()
        {
            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@TipoTarifaId", TipoTarifaId);

                cnn.Open();
                var res = cnn.Query<TipoTarifaObject>("usp_tipotarifa_SelectAll", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return res;
            }
        }
    }
}
