namespace RestGest
{
    public partial class Cliente
    {
        public override string ToString()
        {
            return this.Nome + " (NIF: " + this.NumContribuinte + ")";
        }
    }
}
