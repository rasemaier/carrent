using System.Text.Json.Serialization;

namespace CarRent.Car.Api.v1
{
    public class CarResponseDto
    {
        [JsonPropertyName("CarId")]
        [JsonPropertyOrder(100)]
        public Guid Id { get; set; }
        //[JsonPropertyName("car-number")] //name in json
        [JsonPropertyOrder(200)]
        public string CarNumber { get; set; }
        [JsonPropertyOrder(300)]
        public string Brand { get; set; }
        [JsonPropertyOrder(400)]
        public string CarClass { get; set; }
        [JsonPropertyOrder(500)]
        public string Type { get; set; }    
    }
}
