using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Models.Dtos
{
    public class ResponseDto
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public IEnumerable<string> Errors { get; set; }
        
    }
}
