using System.Xml.Serialization;

namespace Serializar.XML;

public static class SerializarXML
{
    public static void SerializarFormatoXML()
    {
        var caminho = @"D:\Victor\Estudos\udemy\C# - Avançado\SerializarXML\Documentos\01_SerializarXML.xml";

        Usuario usuario = new Usuario()
        {
            Nome = "José Costa da Silva",
            CPF = "222.222.222.22",
            Email = "josedasilva@gmail.com"
        };

        XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

        StreamWriter stream = new StreamWriter(caminho);

        serializador.Serialize(stream, usuario);


        using (var stringWriter = new StringWriter())
        {
            serializador.Serialize(stringWriter, usuario);
            string xmlOutput = stringWriter.ToString();

            // Exibe o XML no console
            Console.WriteLine(xmlOutput);
        }
    }
}
