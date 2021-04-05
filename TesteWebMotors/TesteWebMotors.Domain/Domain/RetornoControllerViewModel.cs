namespace TesteWebMotors.Domain.Domain
{
    public class RetornoControllerViewModel<ExibicaoMensagemViewModel, TObjeto>
    {
        public RetornoControllerViewModel(TObjeto objeto)
        {
            this.Objeto = objeto;
        }
        public ExibicaoMensagemViewModel ExibicaoMensagem { get; set; }
        public TObjeto Objeto { get; set; }
    }
}
