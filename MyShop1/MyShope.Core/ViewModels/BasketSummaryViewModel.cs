using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShope.Core.ViewModels
{
   public class BasketSummaryViewModel
    {
        public int BasketCount;
        public decimal BasketTotal;

        public BasketSummaryViewModel()
        {
             }

        public BasketSummaryViewModel(int basketCount, decimal basketTotal)
        {
            this.BasketCount = basketCount;
            this.BasketTotal = basketTotal;
        }
    }
}
