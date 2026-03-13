using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Analysis
{
    public class ProfitAnalyzer
    {
        public static double CalculateProfitPercentByItem(string itemName, SalesModel model)
        {
            /// 1. Получить выручку товара (услуги, ....) itemName
            List<Sale> itemSales = model.LoadSalesForItem(itemName);
            Item targetItem = model.GetItem(itemName);
            if (targetItem == null)
            {
                return 0.0;
            }
            double itemTotal = itemSales.Sum(sale => sale.Count * targetItem.Price);

            /// 2. Получить общую выручку
            double total = model.GetTotalProfit();
            if (total == 0.0)
            {
                return 0.0;
            }

            return itemTotal / total * 100.0;
        }
    }
}
