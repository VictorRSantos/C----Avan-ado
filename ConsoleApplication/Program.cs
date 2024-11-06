using JsonHelper;
using XMLHelper;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma opção:");

        var opcoes = new List<string>()
        {
            new string("1 - Serializar XML"),
            new string("2 - Deserializar XML"),
            new string("3 - Serializar Json"),
            new string("4 - Serializar Json V1"),
            new string("5 - Deserializar Json"),
            new string("6 - Deserializar Json V1"),
        };

        opcoes.ForEach(lista => Console.WriteLine(lista));
        
        Console.Write("\nSelecione uma opção:");
        var opcao = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine();
        switch (opcao)
        {
            case 1:
                Console.WriteLine("============= Serializar XML =============");
                XMLFormatter.Serializer();
                break;
            case 2:
                Console.WriteLine("============= Deserializar XML =============");
                XMLFormatter.Deserializer();
                break;
            case 3:
                Console.WriteLine("============= Serializar Json =============");
                JsonFormatter.Serializar();
                break;
            case 4:
                Console.WriteLine("============= Serializar Json V1 =============");
                JsonFormatter.SerializarV1();
                break;
            case 5:
                Console.WriteLine("============= Deserializar Json =============");
                JsonFormatter.Deserializar();
                break;
            case 6:
                Console.WriteLine("============= Deserializar Json V1 =============");
                JsonFormatter.DeserializarV1();
                break;
            default:
                Console.WriteLine("Não existe essa opção");
                break;
        }
    }
}