using ClassLibrary1;
using ClassLibrary1.Analysis;
using ClassLibrary1.Presenters;
using ClassLibrary1.Views;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveCharts
{
    public partial class MainForm : Form
    {
        private SalesPresenter presenter_;

        void FillCartesianChart()
        {
            ItemsListBox.DataSource = presenter_.GetAllItems();
            ItemsListBox.DisplayMember = "Name";
            if (ItemsListBox.Items.Count > 0)
            {
                presenter_.ShowSalesByItem(((Item)ItemsListBox.Items[0]).Name);
            }
        }
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new SalesPresenter(new List<ISalesView> { CartesianChart });
            FillCartesianChart();
        }
        private void ItemsList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Item selectedItem = ((Item)(ItemsListBox.SelectedItem));
            if (selectedItem == null)
            {
                return;
            }

            presenter_.ShowSalesByItem(selectedItem.Name);

        }
    }
}
