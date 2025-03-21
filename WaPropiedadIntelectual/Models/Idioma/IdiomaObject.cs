using WaPropiedadIntelectual.Models.ModelSelect;
namespace WaPropiedadIntelectual.Models.Idioma
{
    public class IdiomaObject : WaPropiedadIntelectual.Models.ModelSelect.ModelSelect
    {
        public int IdiomaId { get; set; }
        public string? IdiomaClave { get; set; }
        public string? IdiomaDescripcion { get; set; }
    }
}
