using MyShope.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyShope.Core.Contracts
{
   public interface IBasketService
    {
         void AddBasket(HttpContextBase httpContext, string productId);
         void RemoveBasket(HttpContextBase httpContext, string itemId);
         List<BasketItemViewModel> GetBasketItem(HttpContextBase httpContext);
        BasketSummaryViewModel GetBasketSummary(HttpContextBase httpContext);
    }
}
