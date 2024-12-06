using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKK.UI
{
    public partial class Form2 : Form
    {
        private IStore store;
        public Form2(IStore _store)
        {
            store = _store;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.SetName("Widget");
            
            store.AddStoreItem(prod, 7);
            List<StoreItem> storeItems = new List<StoreItem>();
            storeItems = store.GetStoreItems();
            foreach (StoreItem item in storeItems)
            {
                listView1.Items.Add(item.Product.GetName());
                
            }
        }

        private void AddStore_Click(object sender, EventArgs e)
        {
            //get info for product

            Product product = new Product();

            product.price = 45.00;
            product.Name = "Stuff";
            product.Id = 2;
            int quant = 8;
            store.AddStoreItem(product, quant);
            listView1.Items.Add(product.Name);
            listView1.Items.Add(product.price);
        }
    }
}
