using Serializar.XML;
using Deserializar.XML;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma opção:");

        var opcoes = new List<string>()
        {
            new string("1 - Serializar para XML"),
            new string("2 - Deserializar XML"),
        };

        opcoes.ForEach(lista => Console.WriteLine(lista));

        Console.Write("Selecione uma opção:");
        var opcao = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine();
        switch (opcao)
        {
            case 1:
                Console.WriteLine("============= Serializar XML =============");
                SerializarXML.SerializarFormatoXML();
                break;
            case 2:
                Console.WriteLine("============= Deserializar XML =============");
                DeserializarXML.DeserializerFormatoXML();
                break;
            default:
                Console.WriteLine("Não existe essa opção");
                break;
        }
    }
}