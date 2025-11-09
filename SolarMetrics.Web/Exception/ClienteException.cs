namespace SolarMetrics.Exceptions
{
    public class EmailDuplicadoException : Exception
    {
        public EmailDuplicadoException() 
            : base("Email já cadastrado") 
        { }
    }

    public class ClienteNaoEncontradoException : Exception
    {
        public ClienteNaoEncontradoException() 
            : base("Cliente não encontrado") 
        { }
    }
}