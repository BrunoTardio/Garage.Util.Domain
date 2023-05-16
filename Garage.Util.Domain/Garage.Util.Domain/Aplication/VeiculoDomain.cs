using Garage.Util.Domain;
using Garage.Util.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Util.Domain.Aplication
{
    public class VeiculoDomain : Domain
    {
        public string Nome { get; set; } = string.Empty;
        public string Placa { get; set; } = string.Empty;
        public string Origem { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Observacao { get; set; } = string.Empty;
        public VeiculoMarcaModelo? MarcaModelo { get; set; }
        public VeiculoKilometragem? Kilometragem { get; set; }
        public VeiculoTipo? Tipo { get; set; }
        public VeiculoDetalhes? Detalhes { get; set; }
        public VeiculoCaracteristicaInterna? CaracteristicaInterna { get; set; }
        public VeiculoCaracteristicaExterna? CaracteristicaExterna { get; set; }
        public VeiculoDesempenho? Desempenho { get; set; }
        public VeiculoTransmissao? Transmissao { get; set; }
        public VeiculoCondicao? Condicao { get; set; }

        // historico manutencao inserir
        // documentacao e legalidade
        // preco
    }

    /// <summary>
    /// Descreva a condição geral do veículo, 
    /// mencionando se está em excelente estado, 
    /// bom estado, precisa de reparos, etc.
    /// </summary>
    public class VeiculoCondicao : DomainSub
    {
        public string Observacao { get; set; } = string.Empty;
    }

    /// <summary>
    /// Mencione se o veículo possui transmissão manual ou automática.
    /// </summary>
    public class VeiculoTransmissao : DomainSub
    {
        public string Observacao { get; set; } = string.Empty;
        public VEICULO_TRASMISSAO Transmissao { get; set; } = VEICULO_TRASMISSAO.DESCONHECIDO;
        public ushort QuantidadeMachas { get; set; } = 0;
        public string Tipo { get; set; } = string.Empty;
    }

    /// <summary>
    /// Discuta o desempenho do veículo, incluindo o tipo e tamanho do motor, 
    /// potência, velocidade máxima, 
    /// eficiência de combustível e 
    /// capacidade de carga (no caso de caminhões ou utilitários).
    /// </summary>
    public class VeiculoDesempenho : DomainSub
    {
        public ushort VelocidadeMaxima { get; set; } = 0;
        public ushort Potencia { get; set; } = 0;
        public ushort Motor { get; set; } = 0;
        public string CapacidadeCarga { get; set; } = string.Empty;
        public string Eficiencia { get; set; } = string.Empty;
    }

    /// <summary>
    ///  Identifique o tipo de veículo, como carro, SUV, caminhão, motocicleta, etc.
    /// </summary>
    public class VeiculoTipo : DomainSub
    {
        public string Tipo { get; set; } = string.Empty;
    }

    /// <summary>
    /// 
    /// </summary>
    public class VeiculoDetalhes : DomainSub
    {
        public ushort AnoFabricacao { get; set; } = 1800;
    }

    /// <summary>
    /// 
    /// </summary>
    public class VeiculoKilometragem : DomainSub
    {
        public uint KilometragemAtual { get; set; } = 0;
        public DateTime? DataAtualizadoKilometragemAtua { get; set; }


    }

    /// <summary>
    /// Forneça informações sobre os recursos e equipamentos internos, 
    /// como sistema de áudio, sistema de navegação, 
    /// bancos de couro, ar-condicionado, vidros elétricos, 
    /// conectividade Bluetooth, entre outros.
    /// </summary>
    public class VeiculoCaracteristicaInterna : DomainSub
    {
        public string Observacao { get; set; } = string.Empty;
    }

    /// <summary>
    ///  Descreva as características externas, como cor, carroceria (sedã, hatchback, cupê, etc.), 
    ///  tamanho, rodas e detalhes visuais distintos.
    /// </summary>
    public class VeiculoCaracteristicaExterna : DomainSub
    {
        public string Observacao { get; set; } = string.Empty;
    }

    public class VeiculoMarcaModelo
    {
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Observacao { get; set; } = string.Empty;

    }

}



