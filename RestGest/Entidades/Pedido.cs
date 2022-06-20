namespace RestGest
{
    public partial class Pedido
    {

        public decimal GetTotalValue()
        {
            decimal totalValue = 0;
            if (this.ItemMenu != null)
            {
                foreach (ItemMenu item in this.ItemMenu)
                    totalValue += item.Preco;
            }
            return totalValue;
        }
    }
}
