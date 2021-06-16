namespace SOLID.Exercicio5
{
    public class Pizzaria
    {
        private Pizza _pizza;
        private PizzaFactory _factory;

        public Pizzaria(PizzaFactory factory)
        {
            _factory = factory;
        }

        public void CriarPizza(string sabor)
        {
            _pizza = _factory.CriarPizza(sabor);
            _pizza.AssarPizza();
            _pizza.EntregarPizza();
        }
    }
}
