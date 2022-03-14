namespace Injenção_de_Dependecia
{
    public class Operacao : IOperacao
    {
        public Guid Id{ get; set; }

        public Operacao()
        {
            Id = Guid.NewGuid();
        }
    }
}