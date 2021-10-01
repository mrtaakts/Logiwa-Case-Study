using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int MinimumStockQuantity { get; set; }

    }
}
