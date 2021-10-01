using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Models
{
    public class Product : BaseEntity
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        [JsonIgnore]
        public virtual Category category { get; set; }
        public int CategoryId { get; set; }
    }

}
