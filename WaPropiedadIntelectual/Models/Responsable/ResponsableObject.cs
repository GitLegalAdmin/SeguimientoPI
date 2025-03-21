namespace WaPropiedadIntelectual.Models.Responsable
{
    public class ResponsableObject : WaPropiedadIntelectual.Models.ModelSelect.ModelSelect
    {
        public int ResponsableId { get; set; }
        public string? ResponsableClave { get; set; }
        public string? ResponsableNombre { get; set; }
        public string? ResponsablePuesto { get; set; }
        public string? ResponsableEmail { get; set; }

    }
}
