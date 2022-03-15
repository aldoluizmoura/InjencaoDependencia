namespace Injenção_de_Dependecia
{
    public class Operacao : IOperacaoTransiente, IOperacaoSccoped, IOperacaoSingleton
    {
        public Guid Id{ get; set; }

        public Operacao()
        {
            Id = Guid.NewGuid();
        }
    }
}
