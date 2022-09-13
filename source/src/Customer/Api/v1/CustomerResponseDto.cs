namespace CarRent.Customer.Api.v1
{
    using System.Text.Json.Serialization;

    public class CustomerResponseDto
    {
        [JsonPropertyName("id")]
        [JsonPropertyOrder(100)]
        public Guid CustomerId { get; set; }

        [JsonPropertyName("customer-number")]
        [JsonPropertyOrder(200)]
        public string CustomerNumber { get; set; }

      
    }
}
