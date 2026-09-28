using System.Text.Json.Serialization;

namespace RickAndMortyApi.Model;

internal class Personagem
{
    [JsonPropertyName("name")]
    public string NomePersonagem { get; set; }

    [JsonPropertyName("species")]
    public string EspeciePersonagem { get; set; }
    [JsonPropertyName("gender")]
    public string GeneroPersonagem { get; set;  }

    [JsonPropertyName("origin")]
    public Origem Origem { get; set; }

    
}
