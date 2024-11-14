namespace SegundoParcialBilleteraVirtual.Entidades
{
    public class Euro : Moneda
    {
        private decimal CotizacionUSD = 0.94m;

        public Euro(decimal cantidad) : base(cantidad, "EUR", "€") { }

        public override decimal ConvertirA(Type monedaDestino)
        {
            if (monedaDestino == typeof(Dolar))
            {
                return Cantidad * CotizacionUSD;
            }
            else
            {
                throw new InvalidOperationException("Conversión no soportada");
            }
        }
    }
}
