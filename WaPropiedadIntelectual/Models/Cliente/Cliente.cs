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

        public static ClienteObject Merge(ClienteObject _cliente)
        {

            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ClienteId", _cliente.ClienteId);
                parameters.Add("@ClienteClave", _cliente.ClienteClave);
                parameters.Add("@ClienteNombre", _cliente.ClienteNombre);
                parameters.Add("@ClienteTipoPersonaSAT", _cliente.ClienteTipoPersonaSAT);
                parameters.Add("@ClienteRFC", _cliente.ClienteRFC);
                parameters.Add("@ClienteCurp", _cliente.ClienteCurp);
                parameters.Add("@ClienteVAT", _cliente.ClienteVAT);
                parameters.Add("@IdiomaId", _cliente.IdiomaId);
                parameters.Add("@TipoComunicacionId", _cliente.TipoComunicacionId);
                parameters.Add("@TipoClienteId", _cliente.TipoClienteId);
                parameters.Add("@MonedaId", _cliente.MonedaId);
                parameters.Add("@ClienteWebSite", _cliente.ClienteWebSite);
                parameters.Add("@ClienteEmail", _cliente.ClienteEmail);
                parameters.Add("@ProveedorFacElecId", _cliente.ProveedorFacElecId);
                parameters.Add("@TipoEnvioFacId", _cliente.TipoEnvioFacId);
                parameters.Add("@ClienteObservacion", _cliente.ClienteObservacion);
                parameters.Add("@ClienteRecMarca", _cliente.ClienteRecMarca);
                parameters.Add("@ClienteRecPatente", _cliente.ClienteRecPatente);
                parameters.Add("@ClienteFechaAlta", _cliente.ClienteFechaAlta);
                parameters.Add("@ResponsableId", _cliente.ResponsableId);
                parameters.Add("@TipoTarifaId", _cliente.TipoTarifaId);
                parameters.Add("@Usuarioregistra", _cliente.Usuarioregistra);

                cnn.Open();
                var rs = cnn.Query<ClienteObject>("usp_cliente_Merge", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return rs;

            }
        }

        public static IEnumerable<ClienteObject> Delete(int Id)
        {

            using (var cnn = AppSettings.GetConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ClienteId", Id);
                cnn.Open();
                var rs =
                            cnn.Query<ClienteObject>("usp_cliente_Delete", parameters, commandType: CommandType.StoredProcedure).AsEnumerable();
                return rs;
            }
        }
    }
}
