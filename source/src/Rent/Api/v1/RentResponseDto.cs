namespace CarRent.Rent.Api.v1
{
    using System.Text.Json.Serialization;

    public class RentResponseDto
    {
        [JsonPropertyName("id")]
        [JsonPropertyOrder(100)]
        public Guid RentId { get; set; }

        [JsonPropertyName("rent-number")]
        [JsonPropertyOrder(200)]
        public string RentNumber { get; set; }

  
    }
}
