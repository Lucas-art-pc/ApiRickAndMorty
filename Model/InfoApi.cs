
using System.Text.Json.Serialization;

namespace RickAndMortyApi.Model;

internal class InfoApi
{
    [JsonPropertyName("count")]
    public int ContadorDePersonagem { get; set; }

    [JsonPropertyName("pages")]
    public int PaginasPersonagens { get; set; }

    [JsonPropertyName("next")]
    public string? PaginaSucessoraApi { get; set; }

    [JsonPropertyName("prev")]
    public string? PaginaAntecessoraApi { get; set; }


}
