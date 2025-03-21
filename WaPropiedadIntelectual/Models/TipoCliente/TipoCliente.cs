using Dapper;
using System.Data;

namespace WaPropiedadIntelectual.Models.TipoCliente
{
    public class TipoCliente
    {
        public static IEnumerable<TipoClienteObject> SelectAll()
        {
            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@TipoClienteId", TipoClienteId);

                cnn.Open();
                var res = cnn.Query<TipoClienteObject>("usp_tipocliente_SelectAll", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return res;
            }
        }
    }
}
