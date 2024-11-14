namespace SegundoParcialBilleteraVirtual.Entidades
{
    public class PesoArgentino : Moneda
    {
        private decimal CotizacionDolar = 350;
        private decimal CotizacionEUR = 370;
        private decimal CotizacionCNY = 50;

        public PesoArgentino(decimal cantidad) : base(cantidad, "ARS", "$") { }

        public override decimal ConvertirA(Type monedaDestino)
        {
            if (monedaDestino == typeof(Dolar))
            {
                return Cantidad * CotizacionDolar;
            }
            else if (monedaDestino == typeof(Euro))
            {
                return Cantidad * CotizacionEUR;
            }
            else if (monedaDestino == typeof(Yuan))
            {
                return Cantidad * CotizacionCNY;
            }
            else
            {
                throw new InvalidOperationException("Conversión no soportada");
            }
        }

    }
}
