namespace Richard_Pizzaria_UML2
{
    public class Pizza
    {
        private int _pizzaId;
        private string _pizzaName;
        private int _pizzaPrice;



        public Pizza()
        {
            _pizzaId = pizzaId;
            _pizzaName = pizzaName;
            _pizzaPrice = pizzaPrice;
        }



        public int pizzaId { get; set; }
        public string pizzaName { get; set; }
        public int pizzaPrice { get; set; }

        public override string ToString()
        {
            return $"\n - Navn: {pizzaName} - Pris: {pizzaPrice}kr. - Nummer: {pizzaId}";
        }

    }
}