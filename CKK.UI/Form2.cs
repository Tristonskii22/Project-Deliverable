
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistance.Models;

//hi
namespace CKK.UI
{
    public partial class Form2 : Form
    {
        private FileStore store;
        public Form2(FileStore _store)
        {
            store = _store;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadItems()
        {
            allStoreItems.Items.Clear();
            List<StoreItem> allItems = store.GetStoreItems();
            foreach(StoreItem item in allItems)
            {
                allStoreItems.Items.Add(item.Product.Id + "-" + item.Product.Name + "=" + item.Quantity);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = Int32.Parse(idTextBox.Text);
            product.Name = productTextBox.Text;
            int quantity = Int32.Parse(quantityTextBox.Text);

            store.AddStoreItem(product, quantity);
            InventoryListBox.Items.Add(product.Id + "-" +product.Name + "=" + quantity);
            idTextBox.Clear();
            productTextBox.Clear();
            quantityTextBox.Clear();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            List<StoreItem> items = store.GetStoreItems();
            if(allStoreItems.SelectedIndex != -1)
            {
                int itemToRemove = allStoreItems.SelectedIndex;
                string selectText = allStoreItems.Items[itemToRemove].ToString();
                int deshIndex = selectText.IndexOf("-");
                int prodId = int.Parse(selectText.Substring(0, deshIndex));
                store.DeleteStoreItem(prodId);
                LoadItems();
            }
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            
            LoadItems();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            store.Save();
        }

        private void SortByQuantity_Click(object sender, EventArgs e)
        {
            List<StoreItem> allItems = store.GetAllProductsByQuantity();
            LoadItems();

        }

        private void SortByPrice_Click(object sender, EventArgs e)
        {
            List<StoreItem> allItems = store.GetAllProductsByPrice();
            LoadItems();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<StoreItem> items = store.GetStoreItems();
            List<StoreItem> search = store.GetAllProductsByName(searchBox.Text);
            string searchName = search.FirstOrDefault().Product.Name;
            foreach(StoreItem item in items)
            {
                if(searchName == item.Product.Name)
                {
                    allStoreItems.Items.Add(item.Product.Id + "-" + item.Product.Name + "=" + item.Quantity);
                }
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            store.Load();
        }
    }
}
