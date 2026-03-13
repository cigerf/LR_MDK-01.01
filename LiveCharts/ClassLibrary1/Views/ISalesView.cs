using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Views
{
    public interface ISalesView
    {
        void Show(List<Sale> sales);
    }
}
