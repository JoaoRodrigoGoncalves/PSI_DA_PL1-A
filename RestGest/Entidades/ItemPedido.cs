namespace RestGest
{
    public partial class ItemPedido
    {
        public override string ToString()
        {
            return $"{ItemMenu.Nome} | {ItemMenu.Preco}";
        }

    }
}
