namespace RestGest
{
    public partial class Cliente
    {
        public override string ToString()
        {
            return this.Id.ToString() + " | " + this.Nome;
        }
    }
}
