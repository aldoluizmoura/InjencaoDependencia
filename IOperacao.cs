namespace Injenção_de_Dependecia
{
    public interface IOperacao
    {
        public Guid Id{ get; set; }
    }


    public interface IOperacaoTransiente : IOperacao { }
    public interface IOperacaoSccoped : IOperacao { }
    public interface IOperacaoSingleton : IOperacao { }

}


