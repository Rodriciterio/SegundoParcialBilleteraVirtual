using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SegundoParcialBilleteraVirtual.Entidades
{
    public class Dolar:Moneda
    {
        private decimal CotizacionARS = 350; 
        private decimal CotizacionEUR = 0.94m;
        private decimal CotizacionCNY = 7.1m; 

        public Dolar(decimal cantidad) : base(cantidad, "USD", "$") { }

        public override decimal ConvertirA(Type monedaDestino)
        {
            if (monedaDestino == typeof(PesoArgentino))
            {
                return Cantidad * CotizacionARS; 
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
