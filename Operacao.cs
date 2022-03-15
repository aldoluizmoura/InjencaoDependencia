namespace Injenção_de_Dependecia
{
    public abstract class Operacao : IOperacao
    {
        public Guid Id{ get; set; }

        protected Operacao()
        {
            Id = Guid.NewGuid();
        }
    }

    public class PrimeiraOperacao : Operacao { }
    public class SegundaOperacao : Operacao { }
    public class TerceiraOperacao : Operacao { }
}
