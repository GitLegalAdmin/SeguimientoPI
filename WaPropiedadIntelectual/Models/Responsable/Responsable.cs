using Dapper;
using System.Data;

namespace WaPropiedadIntelectual.Models.Responsable
{
    public class Responsable
    {
        public static IEnumerable<ResponsableObject> SelectAll()
        {
            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@ResponsableId", ResponsableId);

                cnn.Open();
                var res = cnn.Query<ResponsableObject>("usp_responsable_SelectAll", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return res;
            }
        }
    }
}
