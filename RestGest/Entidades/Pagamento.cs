namespace RestGest
{
    public partial class Pagamento
    {
        public override string ToString()
        {
            return this.MetodoPagamento.Metodo + " --- " + this.Valor + "€";
        }
    }
}
