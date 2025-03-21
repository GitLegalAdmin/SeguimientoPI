namespace WaPropiedadIntelectual.Models.Moneda
{
    public class MonedaObject :WaPropiedadIntelectual.Models.ModelSelect.ModelSelect
    {
        public int MonedaId { get; set; }
        public string MonedaDescrip { get; set; }
        public string MonedaSimbolo { get; set; }
        public string MonedaDescripSufijo { get; set; }

    }
}
