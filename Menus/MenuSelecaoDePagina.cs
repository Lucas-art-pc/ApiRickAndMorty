namespace RickAndMortyApi.Menus;

internal class MenuSelecaoDePagina
{
    public static int executar() {
        Console.WriteLine("Qual página de personagens deseja visualizar?");
        int page = int.Parse(Console.ReadLine());
        Console.Clear();

        return page;
    }
}

