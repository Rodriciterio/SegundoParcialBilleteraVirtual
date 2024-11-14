using SegundoParcialBilleteraVirtual.Entidades;

namespace SegundoParcialBilleteraVirtual.Datos
{
    public class Billetera
    {
        private Dictionary<string, Moneda> monedas;
        public SerializadorXml SerializadorXml { get; set; }

        public Billetera()
        {
            monedas = new Dictionary<string, Moneda>();
            SerializadorXml = new SerializadorXml();
        }

        public void Deposito(Moneda moneda)
        {
            if (monedas.ContainsKey(moneda.Codigo))
            {
                monedas[moneda.Codigo].Cantidad += moneda.Cantidad;
                Console.WriteLine($"Se ha actualizado la cantidad de {moneda.Codigo} Nueva cantidad: {moneda.Cantidad}");
            }
            else
            {
                monedas.Add(moneda.Codigo, moneda);
                Console.WriteLine($"Se agrego {moneda.Cantidad} de {moneda.Codigo} a la billetera.");
            }
        }

        public (bool, string) Retiro(Moneda moneda)
        {
            if (monedas.ContainsKey(moneda.Codigo))
            {
                if (monedas[moneda.Codigo].Cantidad >= moneda.Cantidad)
                {
                    monedas[moneda.Codigo].Cantidad -= moneda.Cantidad;
                    Console.WriteLine($"Se ha retirado {moneda.Cantidad} de {moneda.Codigo}. Nueva cantidad: {monedas[moneda.Codigo].Cantidad}");
                    return (true, "Retiro exitoso");
                }
                else
                {
                    Console.WriteLine($"No hay suficiente {moneda.Codigo} para realizar el retiro");
                    return (false, "Cantidad insuficiente");
                }
            }
            else
            {
                Console.WriteLine($"{moneda.Codigo} no se encuentra en la billetera.");
                return (false, "Moneda no encontrada");
            }
        }

        public (bool, string) Pagar(decimal cantidad)
        {
            if (monedas.ContainsKey("ARS") && monedas["ARS"].Cantidad >= cantidad)
            {
                monedas["ARS"].Cantidad -= cantidad;
                Console.WriteLine($"Se ha realizado el pago de {cantidad} ARS. Nueva cantidad de ARS: {monedas["ARS"].Cantidad}");
                return (true, "Pago realizado con éxito.");
            }
            else
            {
                Console.WriteLine("No hay suficiente ARS para realizar el pago");
                return (false, "Fondos insuficientes en ARS.");
            }
        }



        public List<string> MostrarContenido()
        {
            List<string> contenido = new List<string>();
            foreach (var moneda in monedas)
            {
                contenido.Add(moneda.Value.ToString());
            }
            return contenido;
        }

        public void GuardarDatos()
        {
            SerializadorXml.GuardarDatos(monedas!);
        }

        public int GetCantidad()
        {
            return 1;//Generico
        }
    }
}

