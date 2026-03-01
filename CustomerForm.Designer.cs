namespace Eco_Matic_Winforms
{
    partial class CustomerForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // Create controls
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.backMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.howToBuyMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.openReadmeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProd1 = new System.Windows.Forms.Button();
            this.btnProd2 = new System.Windows.Forms.Button();
            this.btnProd3 = new System.Windows.Forms.Button();
            this.btnProd4 = new System.Windows.Forms.Button();
            this.btnProd5 = new System.Windows.Forms.Button();
            this.btnProd6 = new System.Windows.Forms.Button();
            this.btnProd7 = new System.Windows.Forms.Button();
            this.btnProd8 = new System.Windows.Forms.Button();
            this.btnProd9 = new System.Windows.Forms.Button();
            this.btnProd10 = new System.Windows.Forms.Button();
            this.btnProd11 = new System.Windows.Forms.Button();
            this.btnProd12 = new System.Windows.Forms.Button();
            this.btnProd13 = new System.Windows.Forms.Button();
            this.btnProd14 = new System.Windows.Forms.Button();
            this.btnProd15 = new System.Windows.Forms.Button();
            this.paymentGroup = new System.Windows.Forms.GroupBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.cartList = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblInsertHint = new System.Windows.Forms.Label();
            this.moneyFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInserted = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.menuStrip.SuspendLayout();
            this.cartContextMenu.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.paymentGroup.SuspendLayout();
            this.SuspendLayout();

            // MenuStrip
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(230, 240, 230);
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(790, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";

            // File Menu
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenuItem,
            this.openReadmeMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Text = "File";
            this.backMenuItem.Name = "backMenuItem";
            this.backMenuItem.Text = "Back to Main";
            this.backMenuItem.Click += new System.EventHandler(this.backMenuItem_Click);

            // Help Menu
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToBuyMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Text = "Help";
            this.howToBuyMenuItem.Name = "howToBuyMenuItem";
            this.howToBuyMenuItem.Text = "How to Buy";
            this.howToBuyMenuItem.Click += new System.EventHandler(this.howToBuyMenuItem_Click);

            // Open ReadMe Item
            this.openReadmeMenuItem.Name = "openReadmeMenuItem";
            this.openReadmeMenuItem.Text = "Open ReadMe";
            this.openReadmeMenuItem.Click += new System.EventHandler(this.openReadmeMenuItem_Click);

            // Context Menu
            this.cartContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemMenuItem,
            this.clearAllMenuItem});
            this.cartContextMenu.Name = "cartContextMenu";
            this.cartContextMenu.Size = new System.Drawing.Size(190, 48);
            this.removeItemMenuItem.Name = "removeItemMenuItem";
            this.removeItemMenuItem.Text = "Remove Selected Item";
            this.removeItemMenuItem.Click += new System.EventHandler(this.removeItemMenuItem_Click);
            this.clearAllMenuItem.Name = "clearAllMenuItem";
            this.clearAllMenuItem.Text = "Clear All Items";
            this.clearAllMenuItem.Click += new System.EventHandler(this.clearAllMenuItem_Click);

            // Left Panel
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.productPanel);
            this.leftPanel.Location = new System.Drawing.Point(10, 35);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(420, 430);
            this.leftPanel.TabIndex = 1;

            // Product Flow Layout Panel
            this.productPanel.AutoScroll = true;
            this.productPanel.BackColor = System.Drawing.Color.White;
            this.productPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPanel.Location = new System.Drawing.Point(0, 0);
            this.productPanel.Name = "productPanel";
            this.productPanel.Padding = new System.Windows.Forms.Padding(5);
            this.productPanel.Size = new System.Drawing.Size(418, 428);
            this.productPanel.TabIndex = 0;
            // Add buttons to flow layout
            this.productPanel.Controls.Add(this.btnProd1);
            this.productPanel.Controls.Add(this.btnProd2);
            this.productPanel.Controls.Add(this.btnProd3);
            this.productPanel.Controls.Add(this.btnProd4);
            this.productPanel.Controls.Add(this.btnProd5);
            this.productPanel.Controls.Add(this.btnProd6);
            this.productPanel.Controls.Add(this.btnProd7);
            this.productPanel.Controls.Add(this.btnProd8);
            this.productPanel.Controls.Add(this.btnProd9);
            this.productPanel.Controls.Add(this.btnProd10);
            this.productPanel.Controls.Add(this.btnProd11);
            this.productPanel.Controls.Add(this.btnProd12);
            this.productPanel.Controls.Add(this.btnProd13);
            this.productPanel.Controls.Add(this.btnProd14);
            this.productPanel.Controls.Add(this.btnProd15);

            // Common Button Style
            System.Drawing.Font btnFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Size btnSize = new System.Drawing.Size(120, 65);

            // Button 1: Mr Chips
            this.btnProd1.Name = "btnProd1";
            this.btnProd1.Size = btnSize;
            this.btnProd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd1.Font = btnFont;
            this.btnProd1.Text = "Mr Chips\n₱30.50";
            this.btnProd1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd1.BackColor = System.Drawing.Color.White;
            this.btnProd1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd1.Margin = new System.Windows.Forms.Padding(4);

            // Button 2: Nova
            this.btnProd2.Name = "btnProd2";
            this.btnProd2.Size = btnSize;
            this.btnProd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd2.Font = btnFont;
            this.btnProd2.Text = "Nova\n₱40.00";
            this.btnProd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd2.BackColor = System.Drawing.Color.White;
            this.btnProd2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd2.Margin = new System.Windows.Forms.Padding(4);

            // Button 3: Coca Cola
            this.btnProd3.Name = "btnProd3";
            this.btnProd3.Size = btnSize;
            this.btnProd3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd3.Font = btnFont;
            this.btnProd3.Text = "Coca Cola\n₱30.50";
            this.btnProd3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd3.BackColor = System.Drawing.Color.White;
            this.btnProd3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd3.Margin = new System.Windows.Forms.Padding(4);

            // Button 4: Pepsi
            this.btnProd4.Name = "btnProd4";
            this.btnProd4.Size = btnSize;
            this.btnProd4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd4.Font = btnFont;
            this.btnProd4.Text = "Pepsi\n₱30.00";
            this.btnProd4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd4.BackColor = System.Drawing.Color.White;
            this.btnProd4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd4.Margin = new System.Windows.Forms.Padding(4);

            // Button 5: Bandaid Box
            this.btnProd5.Name = "btnProd5";
            this.btnProd5.Size = btnSize;
            this.btnProd5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd5.Font = btnFont;
            this.btnProd5.Text = "Bandaid Box\n₱20.00";
            this.btnProd5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd5.BackColor = System.Drawing.Color.White;
            this.btnProd5.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd5.Margin = new System.Windows.Forms.Padding(4);

            // Button 6: Eco Bag
            this.btnProd6.Name = "btnProd6";
            this.btnProd6.Size = btnSize;
            this.btnProd6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd6.Font = btnFont;
            this.btnProd6.Text = "Eco Bag\n₱30.75";
            this.btnProd6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd6.BackColor = System.Drawing.Color.White;
            this.btnProd6.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd6.Margin = new System.Windows.Forms.Padding(4);

            // Button 7: Piattos
            this.btnProd7.Name = "btnProd7";
            this.btnProd7.Size = btnSize;
            this.btnProd7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd7.Font = btnFont;
            this.btnProd7.Text = "Piattos\n₱35.00";
            this.btnProd7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd7.BackColor = System.Drawing.Color.White;
            this.btnProd7.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd7.Margin = new System.Windows.Forms.Padding(4);

            // Button 8: Chippy
            this.btnProd8.Name = "btnProd8";
            this.btnProd8.Size = btnSize;
            this.btnProd8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd8.Font = btnFont;
            this.btnProd8.Text = "Chippy\n₱32.00";
            this.btnProd8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd8.BackColor = System.Drawing.Color.White;
            this.btnProd8.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd8.Margin = new System.Windows.Forms.Padding(4);

            // Button 9: Roller Coaster
            this.btnProd9.Name = "btnProd9";
            this.btnProd9.Size = btnSize;
            this.btnProd9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd9.Font = btnFont;
            this.btnProd9.Text = "Roller Coaster\n₱28.50";
            this.btnProd9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd9.BackColor = System.Drawing.Color.White;
            this.btnProd9.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd9.Margin = new System.Windows.Forms.Padding(4);

            // Button 10: Fudge Bar
            this.btnProd10.Name = "btnProd10";
            this.btnProd10.Size = btnSize;
            this.btnProd10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd10.Font = btnFont;
            this.btnProd10.Text = "Fudge Bar\n₱25.00";
            this.btnProd10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd10.BackColor = System.Drawing.Color.White;
            this.btnProd10.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd10.Margin = new System.Windows.Forms.Padding(4);

            // Button 11: Cheese Ring
            this.btnProd11.Name = "btnProd11";
            this.btnProd11.Size = btnSize;
            this.btnProd11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd11.Font = btnFont;
            this.btnProd11.Text = "Cheese Ring\n₱30.00";
            this.btnProd11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd11.BackColor = System.Drawing.Color.White;
            this.btnProd11.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd11.Margin = new System.Windows.Forms.Padding(4);

            // Button 12: RC Cola
            this.btnProd12.Name = "btnProd12";
            this.btnProd12.Size = btnSize;
            this.btnProd12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd12.Font = btnFont;
            this.btnProd12.Text = "RC Cola\n₱25.00";
            this.btnProd12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd12.BackColor = System.Drawing.Color.White;
            this.btnProd12.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd12.Margin = new System.Windows.Forms.Padding(4);

            // Button 13: Sting
            this.btnProd13.Name = "btnProd13";
            this.btnProd13.Size = btnSize;
            this.btnProd13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd13.Font = btnFont;
            this.btnProd13.Text = "Sting\n₱27.50";
            this.btnProd13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd13.BackColor = System.Drawing.Color.White;
            this.btnProd13.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd13.Margin = new System.Windows.Forms.Padding(4);

            // Button 14: Zest-O Orange
            this.btnProd14.Name = "btnProd14";
            this.btnProd14.Size = btnSize;
            this.btnProd14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd14.Font = btnFont;
            this.btnProd14.Text = "Zest-O Orange\n₱15.00";
            this.btnProd14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd14.BackColor = System.Drawing.Color.White;
            this.btnProd14.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd14.Margin = new System.Windows.Forms.Padding(4);

            // Button 15: Del Monte
            this.btnProd15.Name = "btnProd15";
            this.btnProd15.Size = btnSize;
            this.btnProd15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd15.Font = btnFont;
            this.btnProd15.Text = "Del Monte Pineapple Juice\n₱22.50";
            this.btnProd15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProd15.BackColor = System.Drawing.Color.White;
            this.btnProd15.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnProd15.Margin = new System.Windows.Forms.Padding(4);

            // Payment Group
            this.paymentGroup.BackColor = System.Drawing.Color.FromArgb(250, 252, 250);
            this.paymentGroup.Controls.Add(this.lblCart);
            this.paymentGroup.Controls.Add(this.cartList);
            this.paymentGroup.Controls.Add(this.lblTotal);
            this.paymentGroup.Controls.Add(this.lblInsertHint);
            this.paymentGroup.Controls.Add(this.moneyFlow);
            this.paymentGroup.Controls.Add(this.lblInserted);
            this.paymentGroup.Controls.Add(this.lblChange);
            this.paymentGroup.Controls.Add(this.btnPurchase);
            this.paymentGroup.Controls.Add(this.btnBack);
            this.paymentGroup.Controls.Add(this.btnClear);
            this.paymentGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.paymentGroup.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.paymentGroup.Location = new System.Drawing.Point(440, 35);
            this.paymentGroup.Name = "paymentGroup";
            this.paymentGroup.Size = new System.Drawing.Size(340, 430);
            this.paymentGroup.TabIndex = 2;
            this.paymentGroup.TabStop = false;
            this.paymentGroup.Text = "  Payment Module  ";

            // lblCart
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCart.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblCart.Location = new System.Drawing.Point(10, 25);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(35, 15);
            this.lblCart.TabIndex = 0;
            this.lblCart.Text = "Cart:";

            // cartList
            this.cartList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartList.ContextMenuStrip = this.cartContextMenu;
            this.cartList.Font = new System.Drawing.Font("Consolas", 9F);
            this.cartList.Location = new System.Drawing.Point(10, 45);
            this.cartList.Name = "cartList";
            this.cartList.Size = new System.Drawing.Size(320, 80);
            this.cartList.TabIndex = 1;

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.lblTotal.Location = new System.Drawing.Point(10, 132);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:  ₱0.00";

            // lblInsertHint
            this.lblInsertHint.AutoSize = true;
            this.lblInsertHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInsertHint.ForeColor = System.Drawing.Color.Gray;
            this.lblInsertHint.Location = new System.Drawing.Point(10, 163);
            this.lblInsertHint.Name = "lblInsertHint";
            this.lblInsertHint.Size = new System.Drawing.Size(83, 15);
            this.lblInsertHint.TabIndex = 3;
            this.lblInsertHint.Text = "Insert Money:";

            // moneyFlow
            this.moneyFlow.Location = new System.Drawing.Point(10, 183);
            this.moneyFlow.Name = "moneyFlow";
            this.moneyFlow.Size = new System.Drawing.Size(320, 78);
            this.moneyFlow.TabIndex = 4;
            this.moneyFlow.WrapContents = true;

            // lblInserted
            this.lblInserted.AutoSize = true;
            this.lblInserted.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInserted.Location = new System.Drawing.Point(10, 268);
            this.lblInserted.Name = "lblInserted";
            this.lblInserted.Size = new System.Drawing.Size(103, 19);
            this.lblInserted.TabIndex = 5;
            this.lblInserted.Text = "Inserted: ₱0.00";

            // lblChange
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChange.Location = new System.Drawing.Point(10, 292);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(101, 19);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "Change:  ₱0.00";

            // btnPurchase
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.Enabled = false;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(10, 325);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(320, 45);
            this.btnPurchase.TabIndex = 7;
            this.btnPurchase.Text = "PURCHASE";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(10, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 35);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(175, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR CART";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // CustomerForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 250, 245);
            this.ClientSize = new System.Drawing.Size(790, 480);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.paymentGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECO-MATIC  CUSTOMER";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.cartContextMenu.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.paymentGroup.ResumeLayout(false);
            this.paymentGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToBuyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReadmeMenuItem;
        private System.Windows.Forms.ContextMenuStrip cartContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeItemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllMenuItem;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.FlowLayoutPanel productPanel;
        private System.Windows.Forms.Button btnProd1;
        private System.Windows.Forms.Button btnProd2;
        private System.Windows.Forms.Button btnProd3;
        private System.Windows.Forms.Button btnProd4;
        private System.Windows.Forms.Button btnProd5;
        private System.Windows.Forms.Button btnProd6;
        private System.Windows.Forms.Button btnProd7;
        private System.Windows.Forms.Button btnProd8;
        private System.Windows.Forms.Button btnProd9;
        private System.Windows.Forms.Button btnProd10;
        private System.Windows.Forms.Button btnProd11;
        private System.Windows.Forms.Button btnProd12;
        private System.Windows.Forms.Button btnProd13;
        private System.Windows.Forms.Button btnProd14;
        private System.Windows.Forms.Button btnProd15;
        private System.Windows.Forms.GroupBox paymentGroup;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.ListBox cartList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblInsertHint;
        private System.Windows.Forms.FlowLayoutPanel moneyFlow;
        private System.Windows.Forms.Label lblInserted;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}
