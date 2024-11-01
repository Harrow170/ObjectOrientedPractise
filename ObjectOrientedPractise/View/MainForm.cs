using System.Security.Cryptography.Xml;
using ObjectOrientedPractise.View.Tabs;
using ObjectOrientedPractise.Model;

namespace ObjectOrientedPractise
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartsTab.RefreshData();
        }
    }
}
