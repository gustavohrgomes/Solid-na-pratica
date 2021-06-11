namespace DIP.Solucao
{
    class RecuperarSenha
    {
        private readonly IDataBaseConnection _conexaoBanco;
        public RecuperarSenha(IDataBaseConnection conexaoBanco)
        {
            _conexaoBanco = conexaoBanco;
        }
    }
}
