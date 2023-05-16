using Garage.Util.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Util.Domain.Aplication
{
    public class HistoricoManutencaoVeiculoDomain : DomainApp
    {

        public uint QuilometragemAferida { get; set; } = 0;

        public uint ProximaQuilometragemRecomendadaAferimento { get; set; } = 0;
        public List<ServicoDomain>? Servico { get; set; } = new List<ServicoDomain>();
        public List<string>? DescricaoServicos { get; set; } = new List<string>();

        // COLOCAR USUARIO PRESTADOR SERVICO -> localizacao , 
        // Mecanico responsavel - oficina
        public List<Util.Domain.Domain.PecaVeiculoDomain> PecasTrocadas { get; set; } = new List<Util.Domain.Domain.PecaVeiculoDomain> { };
        public string ReparoImportante { get; set; } = string.Empty;
        public string Garantia { get; set; } = string.Empty;
        public string Recalls { get; set; } = string.Empty;
        public string NotaAdicional { get; set; } = string.Empty;

    }

}
