using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Models.Dtos
{
    public class CategoryCreateDto
    {
        public string Name { get; set; }
        public int MinimumStockQuantity { get; set; }
    }
}
