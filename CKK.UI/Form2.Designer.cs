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
            this.AddStore = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // AddStore
            // 
            this.AddStore.Location = new System.Drawing.Point(692, 274);
            this.AddStore.Name = "AddStore";
            this.AddStore.Size = new System.Drawing.Size(96, 73);
            this.AddStore.TabIndex = 1;
            this.AddStore.Text = "Add New Item";
            this.AddStore.UseVisualStyleBackColor = true;
            this.AddStore.Click += new System.EventHandler(this.AddStore_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1, -1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(798, 269);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.AddStore);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button AddStore;
        private ListView listView1;
    }
}