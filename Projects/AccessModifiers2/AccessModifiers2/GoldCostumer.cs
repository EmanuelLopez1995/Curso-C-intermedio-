using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers2
{
    public class GoldCostumer : Customer
    {
        public void OfferVouchar()
        {
            var rating = this.CalculateRating(true);
        }
    }
}
