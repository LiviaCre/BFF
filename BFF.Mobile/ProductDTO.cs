using System.Text.Json.Serialization;

namespace BFF.Mobile
{
    public class ProductDTO
    {

        [JsonIgnore]
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
