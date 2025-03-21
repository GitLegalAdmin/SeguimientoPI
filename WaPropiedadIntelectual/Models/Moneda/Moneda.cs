using Dapper;
using System.Data;

namespace WaPropiedadIntelectual.Models.Moneda
{
    public class Moneda
    {
        public static IEnumerable<MonedaObject> SelectAll()
        {
            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@monedaId", Moneda);

                cnn.Open();
                var res = cnn.Query<MonedaObject>("usp_moneda_SelectAll", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return res;
            }
        }
    }
}
