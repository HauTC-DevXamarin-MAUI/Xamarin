using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MyApp1.Models
{

    public class MakeUp
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string PriceSign { get; set; }
        public string Currency { get; set; }
        public string ImageLink { get; set; }
        public string ProductLink { get; set; }
        public string WebsiteLink { get; set; }
        public string Description { get; set; }
        public double? Rating { get; set; }
        public string Category { get; set; }
        public string ProductType { get; set; }
        public IList<string> TagList { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ProductApiUrl { get; set; }

        [JsonPropertyName("api_featured_image")]
        public string ApiFeaturedImage { get; set; }

        //
        [JsonIgnore]
        public string Image => $"https:{ApiFeaturedImage}";
        //
        public IList<ProductColor> ProductColors { get; set; }
    }
    public class ProductColor
    {
        public string HexValue { get; set; }
        public string ColourName { get; set; }
    }
}
