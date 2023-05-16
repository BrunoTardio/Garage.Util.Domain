using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Util.Domain.Aplication
{
    public class UsuarioDomain : DomainApp
    {
        public string Nome { get; set; } = string.Empty;
        public List<string> Email { get; set; } = new List<string> { string.Empty };
        public List<string> Celular { get; set; } = new List<string> { string.Empty };
        public string CpfCnpj { get; set; } = string.Empty;

    }
}
