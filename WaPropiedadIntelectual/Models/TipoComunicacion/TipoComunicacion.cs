using Dapper;
using System.Data;

namespace WaPropiedadIntelectual.Models.TipoComunicacion
{
    public class TipoComunicacion
    {
        public static IEnumerable<TipoComunicacionObject> SelectAll()
        {
            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@TipoComunicacionId", TipoComunicacionId);

                cnn.Open();
                var res = cnn.Query<TipoComunicacionObject>("usp_tipocomunicacion_SelectAll", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return res;
            }
        }
    }
}
