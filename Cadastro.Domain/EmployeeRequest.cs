using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain
{
    public class EmployeeRequest
    {
        public string CompleteName { get; set; }
        public string Function { get; set; }
        public string Session { get; set; }
        public Company? Company { get; set; }
    }
}
