using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Models.Dtos
{
    public class ProductCriterias
    {
        [DefaultValue("")]
        public string Title { get; set; } = "";
        [DefaultValue("")]
        public string Description { get; set; } = "";
        [DefaultValue("")]
        public string CategoryName { get; set; } = "";
        [DefaultValue(1)]
        public int minquantity { get; set; } = 1;
        [DefaultValue(10000)]
        public int maxquantity { get; set; } = 10000;
    }
}
