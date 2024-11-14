namespace SegundoParcialBilleteraVirtual.Entidades
{
    public class Yuan:Moneda
    {
        private decimal CotizacionUSD = 7.1m;
        
        public Yuan(decimal cantidad) : base(cantidad, "CNY", "¥") { }

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

