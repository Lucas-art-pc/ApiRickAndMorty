using RickAndMortyApi.Menus;
using RickAndMortyApi.Model;
using System.Text.Json;

HttpClient client = new();

int page = MenuSelecaoDePagina.executar();

try
{
    string dataApi = await client.GetStringAsync($"https://rickandmortyapi.com/api/character?page={page}");
    var respostaApi = JsonSerializer.Deserialize<ResultApi>(dataApi);
   

    foreach (var personagem in respostaApi.Results)
    {
        Console.WriteLine($"{personagem.NomePersonagem} - {personagem.EspeciePersonagem} - {personagem.GeneroPersonagem} - {personagem.Origem.NomeOrigem}");
    }


    Console.WriteLine($"Página {page} de {respostaApi.InformacoesApi.PaginasPersonagens}");

    Console.WriteLine("Pressione qualquer tecla...");
    Console.ReadKey();
    Console.Clear();

}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex}");
}
