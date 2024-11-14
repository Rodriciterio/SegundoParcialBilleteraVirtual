using System.Text.RegularExpressions;

namespace SegundoParcialBilleteraVirtual.Entidades
{
    public abstract class Moneda
    {
        private decimal cantidad;
        private string? codigo;
        private string? simbolo;

        public Moneda() { }

        public Moneda(decimal cantidad, string codigo, string simbolo)
        {
            Cantidad = cantidad;
            Codigo = codigo;
            Simbolo = simbolo;
        }

        public decimal Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cantidad no válida");
                }
                cantidad = value;
            }
        }

        public string? Codigo
        {
            get { return codigo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Código es requerido");
                }
                codigo = value;
            }
        }

        public string? Simbolo
        {
            get { return simbolo; }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Símbolo es requerido");
                }
                simbolo = value;
            }
        }

        public override string ToString()
        {
            return $"{Codigo} | {Simbolo} | {Cantidad}";
        }

        public abstract decimal ConvertirA(Type monedaDestino);
    }
}
