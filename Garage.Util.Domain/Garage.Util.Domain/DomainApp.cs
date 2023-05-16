namespace Garage.Util.Domain
{

    public class DomainApp
    {
        public ulong Identificador { get; set; } = 0;
    }


    /// <summary>
    /// Para objetos que sao depedentes de um dominio especifico
    /// </summary>
    public abstract class SubDomainApp 
    { 

    }
}