namespace SOLID.Exercicio3
{
    interface ICalculaImpostoPais
    {
        decimal TotalRenda { get; set; }
        decimal TotalDeducao { get; set; }
        decimal CalcularValorImposto();
    }
}
