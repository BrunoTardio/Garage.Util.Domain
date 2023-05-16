using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Util.Domain.Aplication
{
    public class LoginDomain : Domain
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
