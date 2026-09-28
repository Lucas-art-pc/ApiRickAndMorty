using System.Text.Json.Serialization;

namespace RickAndMortyApi.Model;

internal class Origem
{
    [JsonPropertyName("name")]
    public string NomeOrigem { get; set; }

}
