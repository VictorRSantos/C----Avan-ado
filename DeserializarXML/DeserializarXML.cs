using Serializar;
using System.Xml.Serialization;

namespace Deserializar.XML
{
    public class DeserializarXML
    {
        public static void DeserializerFormatoXML()
        {
            StreamReader stream = new StreamReader(@"D:\Victor\Estudos\udemy\C# - Avançado\SerializarXML\Documentos\01_SerializarXML.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            var usuario = (Usuario?)serializador.Deserialize(stream);

            Console.WriteLine($"Usuario:" +
                $"{usuario.Nome}\n" +
                $"CPF:{usuario.CPF}\n" +
                $"Email:{usuario.Email}");
        }
    }
}
