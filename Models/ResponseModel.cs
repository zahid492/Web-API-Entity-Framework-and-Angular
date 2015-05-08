using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class ResponseModel
    {
        public bool Issucess { get; set; }
        public string Message { get; set; }
        public List<EmployeeBasic> Data { get; set; }
    }
}
