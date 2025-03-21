using Dapper;
using System.Data;

namespace WaPropiedadIntelectual.Models.Caso
{
    public class Caso
    {
        public static IEnumerable<CasoObject> SelectAll()
        {
            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                //parameters.Add("@CasoId", CasoId);

                cnn.Open();
                var res = cnn.Query<CasoObject>("usp_caso_SelectAll", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return res;
            }
        }

        public static IEnumerable<CasoObject> Delete(int Id)
        {

            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CasoId", Id);
                cnn.Open();
                var rs =
                            cnn.Query<CasoObject>("usp_caso_Delete", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return rs;
            }
        }
    }


}
