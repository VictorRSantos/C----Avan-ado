using System.Xml.Serialization;
using Xmlhelper;

namespace XMLHelper
{
    public class XMLFormatter
    {
        private const string _caminho = @"D:\Victor\Estudos\udemy\Csharp-Avancado\ConsoleApplication\Documentos\01_SerializarXML.xml";
        public static void Serializer()
        {
            Usuario usuario = new Usuario()
            {
                Nome = "José Costa da Silva",
                CPF = "222.222.222.22",
                Email = "josedasilva@gmail.com"
            };

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            StreamWriter stream = new StreamWriter(_caminho);

            serializador.Serialize(stream, usuario);

            mostrarMensagemFormatoXML(usuario, serializador);

        }
        public static void Deserializer()
        {            
            StreamReader stream = new StreamReader(_caminho);

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            var usuario = (Usuario?)serializador.Deserialize(stream);

            Console.WriteLine($"Usuario:" +
                $"{usuario?.Nome}\n" +
                $"CPF:{usuario?.CPF}\n" +
                $"Email:{usuario?.Email}");
        }
        private static void mostrarMensagemFormatoXML(Usuario usuario, XmlSerializer serializador)
        {
            using (var stringWriter = new StringWriter())
            {
                serializador.Serialize(stringWriter, usuario);
                string xmlOutput = stringWriter.ToString();

                // Exibe o XML no console
                Console.WriteLine(xmlOutput);
            }
        }

    }
}
