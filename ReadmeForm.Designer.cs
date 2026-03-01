namespace Eco_Matic_Winforms
{
    partial class ReadmeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContent.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(584, 300);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = @"ECO-MATIC VENDING MACHINE

About
Eco-Matic is a Windows Forms vending machine simulator built with C# and .NET.
It features a customer purchase interface, admin inventory management, and receipt generation.

How to Use

Customer Mode
1. Click CUSTOMER on the home page
2. Click product buttons to add items to your cart
3. Right-click the cart to remove items
4. Insert money using the bill buttons (₱20 – ₱1000)
5. Click PURCHASE when your payment covers the total
6. Get your receipt from the home page after purchase

Admin Mode
1. Click ADMIN on the home page
2. Enter password: admin123
3. View current inventory in the data grid
4. Select an item, enter quantity, and click UPDATE STOCK to restock

Products
The machine is stocked with 15 items including snacks, drinks, and essentials.
All prices are in Philippine Peso (₱).

Technical Details
- Framework: .NET with Windows Forms
- Language: C#
- Data Storage: In-memory (resets on app close)
- Architecture: Multi-form with shared static DataStore class
- Toolbox Controls: MenuStrip, ContextMenuStrip, Panel, GroupBox, DataGridView

Author
© 2026 Seanix";

            this.btnClose.Location = new System.Drawing.Point(240, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "ReadmeForm";
            this.Text = "README";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnClose;
    }
}
