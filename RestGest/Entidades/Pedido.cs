namespace RestGest
{
    public partial class Pedido
    {

        public decimal GetTotalValue()
        {
            decimal totalValue = 0;

            foreach (var item in this.ItemPedido)
            {
                totalValue += item.ItemMenu.Preco; 
            }

            return totalValue;
        }
    }
}
