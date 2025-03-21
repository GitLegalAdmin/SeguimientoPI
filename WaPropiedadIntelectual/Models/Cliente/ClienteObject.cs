namespace WaPropiedadIntelectual.Models.Cliente
{
    public class ClienteObject
    {
        public int ClienteId { get; set; }
        public string? ClienteClave { get; set; }
        public string? ClienteNombre { get; set; }
        public string? ClienteTipoPersonaSAT { get; set; }
        public string? ClienteRFC { get; set; }
        public string? ClienteCurp { get; set; }
        public string? ClienteVAT { get; set; }
        public int IdiomaId { get; set; }
        public int TipoComunicacionId { get; set; }
        public int TipoClienteId { get; set; }
        public int MonedaId { get; set; }
        public string? ClienteWebSite { get; set; }
        public string? ClienteEmail { get; set; }
        public int ProveedorFacElecId { get; set; }
        public int TipoEnvioFacId { get; set; }
        public string? ClienteObservacion { get; set; }
        public string? ClienteRecMarca { get; set; }
        public string? ClienteRecPatente { get; set; }
        public string? ClienteFechaAlta { get; set; }
        public int ResponsableId { get; set; }
        public int TipoTarifaId { get; set; }
        public string? Usuarioregistra { get; set; }

    }
}
