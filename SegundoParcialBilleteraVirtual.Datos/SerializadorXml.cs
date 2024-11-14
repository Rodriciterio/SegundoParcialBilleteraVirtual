using SegundoParcialBilleteraVirtual.Entidades;
using System.Xml.Serialization;

namespace SegundoParcialBilleteraVirtual.Datos
{
    public class SerializadorXml : IArchivo<Dictionary<string, Moneda>>
    {
        private string nombreArchivo = "Billetera.Xml";
        private string rutaProyecto = Environment.CurrentDirectory;
        private string? rutaCompletaArchivo;

        public SerializadorXml()
        {
            rutaCompletaArchivo = Path.Combine(rutaProyecto, nombreArchivo);
        }

        public void GuardarDatos(Dictionary<string, Moneda> obj)
        {
            using (var escritor = new StreamWriter(rutaCompletaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Moneda>));
                xmlSerializer.Serialize(escritor, obj);
            }
        }

        public Dictionary<string, Moneda> LeerDatos()
        {
            if (!File.Exists(rutaCompletaArchivo)) return new Dictionary<string, Moneda>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Moneda>));
            using (var lector = new StreamReader(rutaCompletaArchivo))
            {
                return (Dictionary<string, Moneda>)xmlSerializer.Deserialize(lector)!;
            }
        }
    }
}
