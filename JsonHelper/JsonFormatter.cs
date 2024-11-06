using Nancy.Json;
using System.Text.Json;
using Xmlhelper;

namespace JsonHelper
{
    public class JsonFormatter
    {
        private const string _caminho = @"D:\Victor\Estudos\udemy\Csharp-Avancado\ConsoleApplication\Documentos\02_SerializarJson.json";

        static Usuario usuario = new Usuario()
        {
            Nome = "Maria",
            CPF = "321.555.888-28",
            Email = "maria@email.com"
        };

        public static void Serializar()
        {
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objetoSerializado = serializador.Serialize(usuario);

            using (StreamWriter stream = new StreamWriter(_caminho))
            {
                stream.WriteLine(objetoSerializado);
                stream.Close();
            }

            Console.WriteLine(objetoSerializado);
        }
        public static void SerializarV1()
        {
            usuario.Nome = "Victor";
            usuario.CPF = "222.555.111-89";
            usuario.Email = "victor@meuemail.com.br";

            string objetoSerializado = JsonSerializer.Serialize(usuario);

            using (StreamWriter stream = new StreamWriter(_caminho))
            {
                stream.WriteLine(objetoSerializado);
                stream.Close();
            }

            Console.WriteLine(objetoSerializado);
        }
        public static void Deserializar()
        {
            JavaScriptSerializer serializador = new JavaScriptSerializer();


            using (StreamReader stream = new StreamReader(_caminho))
            {
                string meuArquivo = stream.ReadToEnd();
                Usuario usuario = serializador.Deserialize<Usuario>(meuArquivo);
            }

            Console.WriteLine($"Usuário\n Nome: {usuario.Nome}, CPF:{usuario.CPF}, Email:{usuario.Email}");

        }

        public static void DeserializarV1()
        {
            using (StreamReader stream = new StreamReader(_caminho))
            {
                string meuArquivo = stream.ReadToEnd();
                var usuario = JsonSerializer.Deserialize<Usuario>(meuArquivo);
            }

            Console.WriteLine($"Usuário\n Nome: {usuario.Nome}, CPF:{usuario.CPF}, Email:{usuario.Email}");

        }
    }
}
