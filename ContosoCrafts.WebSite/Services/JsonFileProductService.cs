using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using ContosoCrafts.WebSite.Models;
using System.Text.Json;

namespace ContosoCrafts.WebSite.Services
{
    public class JsonFileProductService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get {
                return Path.Combine(WebHostEnvironment.WebRootPath,"data","product.json");
                }
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(), 
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
        }
    }
}
