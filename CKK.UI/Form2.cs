using CKK.Logic.Interfaces;
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
            

        }
    }
}
