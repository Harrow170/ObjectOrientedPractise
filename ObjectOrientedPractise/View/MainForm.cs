using System.Security.Cryptography.Xml;

namespace ObjectOrientedPractise
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Item = _store.Items;
            CustomersTab.Customer = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartsTab.RefreshData();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
