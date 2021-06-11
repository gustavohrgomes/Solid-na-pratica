namespace DIP.Violacao
{
    class RecuperarSenha
    {
        private readonly MySqlConnection _conexaoBanco;
        public RecuperarSenha()
        {
            _conexaoBanco = new MySqlConnection();
        }
    }
}
