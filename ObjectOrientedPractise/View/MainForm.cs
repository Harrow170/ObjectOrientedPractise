using System.Security.Cryptography.Xml;

namespace ObjectOrientedPractise
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();
            itemsTabs1.Item = _store.Items;
            customersTab1.Customer = _store.Customers;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
