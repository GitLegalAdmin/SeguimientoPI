using Dapper;
using System.Data;

namespace WaPropiedadIntelectual.Models.Cliente
{
    public class Idioma
    {
        public static IEnumerable<IdiomaObject> SelectAll()
        {
            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@usuario", Usuario);

                cnn.Open();
                var res = cnn.Query<IdiomaObject>("usp_idioma_SelectAll", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return res;
            }
        }
    }
}
