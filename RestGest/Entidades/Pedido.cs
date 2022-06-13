using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestGest
{
    public partial class Pedido
    {

        public decimal GetTotalValue()
        {
            //Initialize defuault value
            decimal totalValue = 0;
            //Get each item from the pedido
            foreach (ItemMenu item in this.ItemMenu)
                //Save the value from the item
                totalValue += item.Preco;
            ///Return the total value
            return totalValue;
        }
    }
}
