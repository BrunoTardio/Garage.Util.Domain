using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Util.Domain.Aplication
{
    public class LoginDomain : DomainApp
    {
        public string Email { get; set; } = string.Empty;
        public string CpfCnpj { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
