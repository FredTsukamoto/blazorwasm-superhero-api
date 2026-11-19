using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models;

// Mapeamento do JSON de https://www.superheroapi.com/api.php/{token}/search/{nome}
public class SearchResponse
{
    [JsonPropertyName("response")] public string? Response { get; set; }
    [JsonPropertyName("results-for")] public string? ResultsFor { get; set; }
    [JsonPropertyName("results")] public List<SuperHero>? Results { get; set; }
    [JsonPropertyName("error")] public string? Error { get; set; } // vem quando não acha o herói
}

public class SuperHero
{
    [JsonPropertyName("id")] public string? Id { get; set; }
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("powerstats")] public Powerstats? Powerstats { get; set; }
    [JsonPropertyName("biography")] public Biography? Biography { get; set; }
    [JsonPropertyName("appearance")] public Appearance? Appearance { get; set; }
    [JsonPropertyName("work")] public Work? Work { get; set; }
    [JsonPropertyName("connections")] public Connections? Connections { get; set; }
    [JsonPropertyName("image")] public Image? Image { get; set; }
}

public class Powerstats
{
    [JsonPropertyName("intelligence")] public string? Intelligence { get; set; }
    [JsonPropertyName("strength")] public string? Strength { get; set; }
    [JsonPropertyName("speed")] public string? Speed { get; set; }
    [JsonPropertyName("durability")] public string? Durability { get; set; }
    [JsonPropertyName("power")] public string? Power { get; set; }
    [JsonPropertyName("combat")] public string? Combat { get; set; }
}

public class Biography
{
    [JsonPropertyName("full-name")] public string? FullName { get; set; }
    [JsonPropertyName("alter-egos")] public string? AlterEgos { get; set; }
    [JsonPropertyName("aliases")] public List<string>? Aliases { get; set; }
    [JsonPropertyName("place-of-birth")] public string? PlaceOfBirth { get; set; }
    [JsonPropertyName("first-appearance")] public string? FirstAppearance { get; set; }
    [JsonPropertyName("publisher")] public string? Publisher { get; set; }
    [JsonPropertyName("alignment")] public string? Alignment { get; set; }
}

public class Appearance
{
    [JsonPropertyName("gender")] public string? Gender { get; set; }
    [JsonPropertyName("race")] public string? Race { get; set; }
    [JsonPropertyName("height")] public List<string>? Height { get; set; }
    [JsonPropertyName("weight")] public List<string>? Weight { get; set; }
    [JsonPropertyName("eye-color")] public string? EyeColor { get; set; }
    [JsonPropertyName("hair-color")] public string? HairColor { get; set; }
}

public class Work
{
    [JsonPropertyName("occupation")] public string? Occupation { get; set; }
    [JsonPropertyName("base")] public string? Base { get; set; }
}

public class Connections
{
    [JsonPropertyName("group-affiliation")] public string? GroupAffiliation { get; set; }
    [JsonPropertyName("relatives")] public string? Relatives { get; set; }
}

public class Image
{
    [JsonPropertyName("url")] public string? Url { get; set; }
}
