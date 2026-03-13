using ClassLibrary1.Models;
using ClassLibrary1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Presenters
{
    public class SalesPresenter
    {
        private SalesModel model_ = new SalesModel();
        private List<ISalesView> view_;
        public SalesPresenter(List<ISalesView> views)
        {
            view_ = views;

            model_.Load();
        }
        public void ShowSalesByItem(string itemName)
        {
            List<Sale> sales = model_.LoadSalesForItem(itemName);
            foreach (ISalesView view in view_)
            {
                view.Show(sales);
            }
        }
        public List<Item> GetAllItems()
        {
            return model_.GetAllItems();
        }

        public SalesModel GetModel()
        {
            return model_;
        }
    }
}
