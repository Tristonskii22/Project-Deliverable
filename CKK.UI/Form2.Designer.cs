using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistance.Models;
namespace CKK.UI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.allStoreItems = new System.Windows.Forms.ListBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SortByQuantity = new System.Windows.Forms.Button();
            this.SortByPrice = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(33, 66);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(208, 23);
            this.idTextBox.TabIndex = 0;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(287, 66);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(204, 23);
            this.productTextBox.TabIndex = 1;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(543, 66);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(193, 23);
            this.quantityTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(33, 105);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(208, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(33, 143);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(208, 23);
            this.removeItemButton.TabIndex = 4;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(33, 181);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(208, 23);
            this.viewAllButton.TabIndex = 5;
            this.viewAllButton.Text = "View All Items";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.ItemHeight = 15;
            this.InventoryListBox.Location = new System.Drawing.Point(33, 218);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(361, 214);
            this.InventoryListBox.TabIndex = 6;
            // 
            // allStoreItems
            // 
            this.allStoreItems.FormattingEnabled = true;
            this.allStoreItems.ItemHeight = 15;
            this.allStoreItems.Location = new System.Drawing.Point(429, 218);
            this.allStoreItems.Name = "allStoreItems";
            this.allStoreItems.Size = new System.Drawing.Size(359, 214);
            this.allStoreItems.TabIndex = 7;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(33, 46);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 15);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(287, 46);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(49, 15);
            this.productLabel.TabIndex = 9;
            this.productLabel.Text = "Product";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(543, 46);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(53, 15);
            this.quantityLabel.TabIndex = 10;
            this.quantityLabel.Text = "Quantity";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(713, 409);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SortByQuantity
            // 
            this.SortByQuantity.Location = new System.Drawing.Point(543, 143);
            this.SortByQuantity.Name = "SortByQuantity";
            this.SortByQuantity.Size = new System.Drawing.Size(102, 23);
            this.SortByQuantity.TabIndex = 12;
            this.SortByQuantity.Text = "Sort By Quantity";
            this.SortByQuantity.UseVisualStyleBackColor = true;
            this.SortByQuantity.Click += new System.EventHandler(this.SortByQuantity_Click);
            // 
            // SortByPrice
            // 
            this.SortByPrice.Location = new System.Drawing.Point(661, 143);
            this.SortByPrice.Name = "SortByPrice";
            this.SortByPrice.Size = new System.Drawing.Size(102, 23);
            this.SortByPrice.TabIndex = 13;
            this.SortByPrice.Text = "Sort By Price";
            this.SortByPrice.UseVisualStyleBackColor = true;
            this.SortByPrice.Click += new System.EventHandler(this.SortByPrice_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(543, 181);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(633, 181);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(139, 23);
            this.searchBox.TabIndex = 15;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(429, 409);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 16;
            this.Load.Text = "Load File";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SortByPrice);
            this.Controls.Add(this.SortByQuantity);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.allStoreItems);
            this.Controls.Add(this.InventoryListBox);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox idTextBox;
        private TextBox productTextBox;
        private TextBox quantityTextBox;
        private Button addButton;
        private Button removeItemButton;
        private Button viewAllButton;
        private ListBox InventoryListBox;
        private ListBox allStoreItems;
        private Label idLabel;
        private Label productLabel;
        private Label quantityLabel;
        private Button SaveButton;
        private Button SortByQuantity;
        private Button SortByPrice;
        private Button Search;
        private TextBox searchBox;
        private Button Load;
    }
}