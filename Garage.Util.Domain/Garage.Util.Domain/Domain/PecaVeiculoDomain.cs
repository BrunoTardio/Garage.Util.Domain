using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Util.Domain.Domain
{
    public class PecaVeiculoDomain : DomainApp
    {
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; } = 0;
    }
}
