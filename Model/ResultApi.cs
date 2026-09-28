using System.Text.Json.Serialization;

namespace RickAndMortyApi.Model;

internal class ResultApi
{
    [JsonPropertyName("results")]
    public List<Personagem> Results { get; set; }

    [JsonPropertyName("info")]
    public InfoApi InformacoesApi { get; set; }

}
