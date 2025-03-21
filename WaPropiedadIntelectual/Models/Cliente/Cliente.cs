using Dapper;
using System.Data;

namespace WaPropiedadIntelectual.Models.Cliente
{
    public class Cliente
    {
        public static IEnumerable<ClienteObject> SelectAll()
        {
            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@ClienteId", ClienteId);

                cnn.Open();
                var res = cnn.Query<ClienteObject>("usp_cliente_SelectAll", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return res;
            }
        }
    }
}
