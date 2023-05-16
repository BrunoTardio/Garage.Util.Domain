namespace Garage.Util.Domain
{
    public abstract class Domain
    {
        public ulong Identificador { get; set; } = 0;
    }


    /// <summary>
    /// Para objetos que sao depedentes de um dominio especifico
    /// </summary>
    public abstract class DomainSub 
    { 
    }
}