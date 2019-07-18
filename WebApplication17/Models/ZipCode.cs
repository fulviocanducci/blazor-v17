using System.Text.Json.Serialization;
namespace Models
{
    public sealed class ZipCode
    {
        [JsonPropertyName("cep")]
        public string Zip { get; set; }

        [JsonPropertyName("logradouro")]
        public string Address { get; set; }

        [JsonPropertyName("complemento")]
        public string Complement { get; set; }

        [JsonPropertyName("bairro")]
        public string District { get; set; }

        [JsonPropertyName("localidade")]
        public string City { get; set; }

        [JsonPropertyName("uf")]
        public string UF { get; set; }

        [JsonPropertyName("unidade")]
        public string Unity { get; set; }

        [JsonPropertyName("ibge")]
        public string IBGE { get; set; }

        [JsonPropertyName("gia")]
        public string Gia { get; set; }
    }
}
