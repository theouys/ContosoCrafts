using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace ContosoCrafts.WebSite.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        public string Title { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        //Shortversion of the below is
        //public override string ToString() => JsonSerializer.Serialize<Product>(this);
        
        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
        }
    }
}
