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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            backMenuItem = new ToolStripMenuItem();
            openReadmeMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            howToBuyMenuItem = new ToolStripMenuItem();
            cartContextMenu = new ContextMenuStrip(components);
            removeItemMenuItem = new ToolStripMenuItem();
            clearAllMenuItem = new ToolStripMenuItem();
            leftPanel = new Panel();
            productPanel = new FlowLayoutPanel();
            btnProd1 = new Button();
            btnProd2 = new Button();
            btnProd3 = new Button();
            btnProd4 = new Button();
            btnProd5 = new Button();
            btnProd6 = new Button();
            btnProd7 = new Button();
            btnProd8 = new Button();
            btnProd9 = new Button();
            btnProd10 = new Button();
            btnProd11 = new Button();
            btnProd12 = new Button();
            btnProd13 = new Button();
            btnProd14 = new Button();
            btnProd15 = new Button();
            paymentGroup = new GroupBox();
            lblCart = new Label();
            cartList = new ListBox();
            lblTotal = new Label();
            lblInsertHint = new Label();
            moneyFlow = new FlowLayoutPanel();
            btnMoney20 = new Button();
            btnMoney50 = new Button();
            btnMoney100 = new Button();
            btnMoney200 = new Button();
            btnMoney500 = new Button();
            btnMoney1000 = new Button();
            lblInserted = new Label();
            lblChange = new Label();
            lblExamine = new Label();
            cboExamineItem = new ComboBox();
            btnExamine = new Button();
            recycleGroup = new GroupBox();
            lblRecycleType = new Label();
            cboRecycleType = new ComboBox();
            lblRecycleQty = new Label();
            nudRecycleQty = new NumericUpDown();
            btnRecycle = new Button();
            lblRecycleStatus = new Label();
            btnPurchase = new Button();
            btnBack = new Button();
            btnClear = new Button();
            menuStrip.SuspendLayout();
            cartContextMenu.SuspendLayout();
            leftPanel.SuspendLayout();
            productPanel.SuspendLayout();
            paymentGroup.SuspendLayout();
            moneyFlow.SuspendLayout();
            recycleGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRecycleQty).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(230, 240, 230);
            menuStrip.Font = new Font("Segoe UI", 10F);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, helpMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(980, 27);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { backMenuItem, openReadmeMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(41, 23);
            fileMenu.Text = "File";
            // 
            // backMenuItem
            // 
            backMenuItem.Name = "backMenuItem";
            backMenuItem.Size = new Size(166, 24);
            backMenuItem.Text = "Back to Main";
            backMenuItem.Click += backMenuItem_Click;
            // 
            // openReadmeMenuItem
            // 
            openReadmeMenuItem.Name = "openReadmeMenuItem";
            openReadmeMenuItem.Size = new Size(166, 24);
            openReadmeMenuItem.Text = "Open ReadMe";
            openReadmeMenuItem.Click += openReadmeMenuItem_Click;
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { howToBuyMenuItem });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(49, 23);
            helpMenu.Text = "Help";
            // 
            // howToBuyMenuItem
            // 
            howToBuyMenuItem.Name = "howToBuyMenuItem";
            howToBuyMenuItem.Size = new Size(150, 24);
            howToBuyMenuItem.Text = "How to Buy";
            howToBuyMenuItem.Click += howToBuyMenuItem_Click;
            // 
            // cartContextMenu
            // 
            cartContextMenu.Items.AddRange(new ToolStripItem[] { removeItemMenuItem, clearAllMenuItem });
            cartContextMenu.Name = "cartContextMenu";
            cartContextMenu.Size = new Size(192, 48);
            // 
            // removeItemMenuItem
            // 
            removeItemMenuItem.Name = "removeItemMenuItem";
            removeItemMenuItem.Size = new Size(191, 22);
            removeItemMenuItem.Text = "Remove Selected Item";
            removeItemMenuItem.Click += removeItemMenuItem_Click;
            // 
            // clearAllMenuItem
            // 
            clearAllMenuItem.Name = "clearAllMenuItem";
            clearAllMenuItem.Size = new Size(191, 22);
            clearAllMenuItem.Text = "Clear All Items";
            clearAllMenuItem.Click += clearAllMenuItem_Click;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.BorderStyle = BorderStyle.FixedSingle;
            leftPanel.Controls.Add(productPanel);
            leftPanel.Location = new Point(10, 35);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(608, 540);
            leftPanel.TabIndex = 1;
            // 
            // productPanel
            // 
            productPanel.AutoScroll = true;
            productPanel.BackColor = Color.White;
            productPanel.Controls.Add(btnProd1);
            productPanel.Controls.Add(btnProd2);
            productPanel.Controls.Add(btnProd3);
            productPanel.Controls.Add(btnProd4);
            productPanel.Controls.Add(btnProd5);
            productPanel.Controls.Add(btnProd6);
            productPanel.Controls.Add(btnProd7);
            productPanel.Controls.Add(btnProd8);
            productPanel.Controls.Add(btnProd9);
            productPanel.Controls.Add(btnProd10);
            productPanel.Controls.Add(btnProd11);
            productPanel.Controls.Add(btnProd12);
            productPanel.Controls.Add(btnProd13);
            productPanel.Controls.Add(btnProd14);
            productPanel.Controls.Add(btnProd15);
            productPanel.Dock = DockStyle.Fill;
            productPanel.Location = new Point(0, 0);
            productPanel.Name = "productPanel";
            productPanel.Padding = new Padding(6);
            productPanel.Size = new Size(606, 538);
            productPanel.TabIndex = 0;
            // 
            // btnProd1
            // 
            btnProd1.BackColor = Color.White;
            btnProd1.Cursor = Cursors.Hand;
            btnProd1.FlatStyle = FlatStyle.Flat;
            btnProd1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd1.Location = new Point(10, 10);
            btnProd1.Margin = new Padding(4);
            btnProd1.Name = "btnProd1";
            btnProd1.Size = new Size(110, 70);
            btnProd1.TabIndex = 0;
            btnProd1.Text = "Product 1";
            btnProd1.UseVisualStyleBackColor = false;
            // 
            // btnProd2
            // 
            btnProd2.BackColor = Color.White;
            btnProd2.Cursor = Cursors.Hand;
            btnProd2.FlatStyle = FlatStyle.Flat;
            btnProd2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd2.Location = new Point(128, 10);
            btnProd2.Margin = new Padding(4);
            btnProd2.Name = "btnProd2";
            btnProd2.Size = new Size(110, 70);
            btnProd2.TabIndex = 1;
            btnProd2.Text = "Product 2";
            btnProd2.UseVisualStyleBackColor = false;
            // 
            // btnProd3
            // 
            btnProd3.BackColor = Color.White;
            btnProd3.Cursor = Cursors.Hand;
            btnProd3.FlatStyle = FlatStyle.Flat;
            btnProd3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd3.Location = new Point(246, 10);
            btnProd3.Margin = new Padding(4);
            btnProd3.Name = "btnProd3";
            btnProd3.Size = new Size(110, 70);
            btnProd3.TabIndex = 2;
            btnProd3.Text = "Product 3";
            btnProd3.UseVisualStyleBackColor = false;
            // 
            // btnProd4
            // 
            btnProd4.BackColor = Color.White;
            btnProd4.Cursor = Cursors.Hand;
            btnProd4.FlatStyle = FlatStyle.Flat;
            btnProd4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd4.Location = new Point(364, 10);
            btnProd4.Margin = new Padding(4);
            btnProd4.Name = "btnProd4";
            btnProd4.Size = new Size(110, 70);
            btnProd4.TabIndex = 3;
            btnProd4.Text = "Product 4";
            btnProd4.UseVisualStyleBackColor = false;
            // 
            // btnProd5
            // 
            btnProd5.BackColor = Color.White;
            btnProd5.Cursor = Cursors.Hand;
            btnProd5.FlatStyle = FlatStyle.Flat;
            btnProd5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd5.Location = new Point(482, 10);
            btnProd5.Margin = new Padding(4);
            btnProd5.Name = "btnProd5";
            btnProd5.Size = new Size(110, 70);
            btnProd5.TabIndex = 4;
            btnProd5.Text = "Product 5";
            btnProd5.UseVisualStyleBackColor = false;
            // 
            // btnProd6
            // 
            btnProd6.BackColor = Color.White;
            btnProd6.Cursor = Cursors.Hand;
            btnProd6.FlatStyle = FlatStyle.Flat;
            btnProd6.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd6.Location = new Point(10, 88);
            btnProd6.Margin = new Padding(4);
            btnProd6.Name = "btnProd6";
            btnProd6.Size = new Size(110, 70);
            btnProd6.TabIndex = 5;
            btnProd6.Text = "Product 6";
            btnProd6.UseVisualStyleBackColor = false;
            // 
            // btnProd7
            // 
            btnProd7.BackColor = Color.White;
            btnProd7.Cursor = Cursors.Hand;
            btnProd7.FlatStyle = FlatStyle.Flat;
            btnProd7.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd7.Location = new Point(128, 88);
            btnProd7.Margin = new Padding(4);
            btnProd7.Name = "btnProd7";
            btnProd7.Size = new Size(110, 70);
            btnProd7.TabIndex = 6;
            btnProd7.Text = "Product 7";
            btnProd7.UseVisualStyleBackColor = false;
            // 
            // btnProd8
            // 
            btnProd8.BackColor = Color.White;
            btnProd8.Cursor = Cursors.Hand;
            btnProd8.FlatStyle = FlatStyle.Flat;
            btnProd8.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd8.Location = new Point(246, 88);
            btnProd8.Margin = new Padding(4);
            btnProd8.Name = "btnProd8";
            btnProd8.Size = new Size(110, 70);
            btnProd8.TabIndex = 7;
            btnProd8.Text = "Product 8";
            btnProd8.UseVisualStyleBackColor = false;
            // 
            // btnProd9
            // 
            btnProd9.BackColor = Color.White;
            btnProd9.Cursor = Cursors.Hand;
            btnProd9.FlatStyle = FlatStyle.Flat;
            btnProd9.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd9.Location = new Point(364, 88);
            btnProd9.Margin = new Padding(4);
            btnProd9.Name = "btnProd9";
            btnProd9.Size = new Size(110, 70);
            btnProd9.TabIndex = 8;
            btnProd9.Text = "Product 9";
            btnProd9.UseVisualStyleBackColor = false;
            // 
            // btnProd10
            // 
            btnProd10.BackColor = Color.White;
            btnProd10.Cursor = Cursors.Hand;
            btnProd10.FlatStyle = FlatStyle.Flat;
            btnProd10.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd10.Location = new Point(482, 88);
            btnProd10.Margin = new Padding(4);
            btnProd10.Name = "btnProd10";
            btnProd10.Size = new Size(110, 70);
            btnProd10.TabIndex = 9;
            btnProd10.Text = "Product 10";
            btnProd10.UseVisualStyleBackColor = false;
            // 
            // btnProd11
            // 
            btnProd11.BackColor = Color.White;
            btnProd11.Cursor = Cursors.Hand;
            btnProd11.FlatStyle = FlatStyle.Flat;
            btnProd11.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd11.Location = new Point(10, 166);
            btnProd11.Margin = new Padding(4);
            btnProd11.Name = "btnProd11";
            btnProd11.Size = new Size(110, 70);
            btnProd11.TabIndex = 10;
            btnProd11.Text = "Product 11";
            btnProd11.UseVisualStyleBackColor = false;
            // 
            // btnProd12
            // 
            btnProd12.BackColor = Color.White;
            btnProd12.Cursor = Cursors.Hand;
            btnProd12.FlatStyle = FlatStyle.Flat;
            btnProd12.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd12.Location = new Point(128, 166);
            btnProd12.Margin = new Padding(4);
            btnProd12.Name = "btnProd12";
            btnProd12.Size = new Size(110, 70);
            btnProd12.TabIndex = 11;
            btnProd12.Text = "Product 12";
            btnProd12.UseVisualStyleBackColor = false;
            // 
            // btnProd13
            // 
            btnProd13.BackColor = Color.White;
            btnProd13.Cursor = Cursors.Hand;
            btnProd13.FlatStyle = FlatStyle.Flat;
            btnProd13.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd13.Location = new Point(246, 166);
            btnProd13.Margin = new Padding(4);
            btnProd13.Name = "btnProd13";
            btnProd13.Size = new Size(110, 70);
            btnProd13.TabIndex = 12;
            btnProd13.Text = "Product 13";
            btnProd13.UseVisualStyleBackColor = false;
            // 
            // btnProd14
            // 
            btnProd14.BackColor = Color.White;
            btnProd14.Cursor = Cursors.Hand;
            btnProd14.FlatStyle = FlatStyle.Flat;
            btnProd14.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd14.Location = new Point(364, 166);
            btnProd14.Margin = new Padding(4);
            btnProd14.Name = "btnProd14";
            btnProd14.Size = new Size(110, 70);
            btnProd14.TabIndex = 13;
            btnProd14.Text = "Product 14";
            btnProd14.UseVisualStyleBackColor = false;
            // 
            // btnProd15
            // 
            btnProd15.BackColor = Color.White;
            btnProd15.Cursor = Cursors.Hand;
            btnProd15.FlatStyle = FlatStyle.Flat;
            btnProd15.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnProd15.Location = new Point(482, 166);
            btnProd15.Margin = new Padding(4);
            btnProd15.Name = "btnProd15";
            btnProd15.Size = new Size(110, 70);
            btnProd15.TabIndex = 14;
            btnProd15.Text = "Product 15";
            btnProd15.UseVisualStyleBackColor = false;
            // 
            // paymentGroup
            // 
            paymentGroup.BackColor = Color.FromArgb(250, 252, 250);
            paymentGroup.Controls.Add(lblCart);
            paymentGroup.Controls.Add(cartList);
            paymentGroup.Controls.Add(lblTotal);
            paymentGroup.Controls.Add(lblInsertHint);
            paymentGroup.Controls.Add(moneyFlow);
            paymentGroup.Controls.Add(lblInserted);
            paymentGroup.Controls.Add(lblChange);
            paymentGroup.Controls.Add(lblExamine);
            paymentGroup.Controls.Add(cboExamineItem);
            paymentGroup.Controls.Add(btnExamine);
            paymentGroup.Controls.Add(recycleGroup);
            paymentGroup.Controls.Add(btnPurchase);
            paymentGroup.Controls.Add(btnBack);
            paymentGroup.Controls.Add(btnClear);
            paymentGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            paymentGroup.ForeColor = Color.FromArgb(52, 73, 94);
            paymentGroup.Location = new Point(618, 35);
            paymentGroup.Name = "paymentGroup";
            paymentGroup.Size = new Size(352, 540);
            paymentGroup.TabIndex = 2;
            paymentGroup.TabStop = false;
            paymentGroup.Text = "  Payment and Actions  ";
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCart.Location = new Point(10, 24);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(33, 15);
            lblCart.TabIndex = 0;
            lblCart.Text = "Cart:";
            // 
            // cartList
            // 
            cartList.BorderStyle = BorderStyle.FixedSingle;
            cartList.ContextMenuStrip = cartContextMenu;
            cartList.Font = new Font("Consolas", 9F);
            cartList.FormattingEnabled = true;
            cartList.Location = new Point(10, 42);
            cartList.Name = "cartList";
            cartList.Size = new Size(330, 86);
            cartList.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(34, 139, 34);
            lblTotal.Location = new Point(10, 132);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(115, 25);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total:  P0.00";
            // 
            // lblInsertHint
            // 
            lblInsertHint.AutoSize = true;
            lblInsertHint.Font = new Font("Segoe UI", 9F);
            lblInsertHint.ForeColor = Color.Gray;
            lblInsertHint.Location = new Point(10, 162);
            lblInsertHint.Name = "lblInsertHint";
            lblInsertHint.Size = new Size(79, 15);
            lblInsertHint.TabIndex = 3;
            lblInsertHint.Text = "Insert Money:";
            // 
            // moneyFlow
            // 
            moneyFlow.Controls.Add(btnMoney20);
            moneyFlow.Controls.Add(btnMoney50);
            moneyFlow.Controls.Add(btnMoney100);
            moneyFlow.Controls.Add(btnMoney200);
            moneyFlow.Controls.Add(btnMoney500);
            moneyFlow.Controls.Add(btnMoney1000);
            moneyFlow.Location = new Point(10, 182);
            moneyFlow.Name = "moneyFlow";
            moneyFlow.Size = new Size(330, 76);
            moneyFlow.TabIndex = 4;
            // 
            // btnMoney20
            // 
            btnMoney20.BackColor = Color.FromArgb(241, 196, 15);
            btnMoney20.Cursor = Cursors.Hand;
            btnMoney20.FlatAppearance.BorderSize = 0;
            btnMoney20.FlatStyle = FlatStyle.Flat;
            btnMoney20.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoney20.Location = new Point(3, 3);
            btnMoney20.Name = "btnMoney20";
            btnMoney20.Size = new Size(100, 32);
            btnMoney20.TabIndex = 0;
            btnMoney20.Text = "P20";
            btnMoney20.UseVisualStyleBackColor = false;
            btnMoney20.Click += btnMoney_Click;
            // 
            // btnMoney50
            // 
            btnMoney50.BackColor = Color.FromArgb(241, 196, 15);
            btnMoney50.Cursor = Cursors.Hand;
            btnMoney50.FlatAppearance.BorderSize = 0;
            btnMoney50.FlatStyle = FlatStyle.Flat;
            btnMoney50.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoney50.Location = new Point(109, 3);
            btnMoney50.Name = "btnMoney50";
            btnMoney50.Size = new Size(100, 32);
            btnMoney50.TabIndex = 1;
            btnMoney50.Text = "P50";
            btnMoney50.UseVisualStyleBackColor = false;
            btnMoney50.Click += btnMoney_Click;
            // 
            // btnMoney100
            // 
            btnMoney100.BackColor = Color.FromArgb(241, 196, 15);
            btnMoney100.Cursor = Cursors.Hand;
            btnMoney100.FlatAppearance.BorderSize = 0;
            btnMoney100.FlatStyle = FlatStyle.Flat;
            btnMoney100.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoney100.Location = new Point(215, 3);
            btnMoney100.Name = "btnMoney100";
            btnMoney100.Size = new Size(100, 32);
            btnMoney100.TabIndex = 2;
            btnMoney100.Text = "P100";
            btnMoney100.UseVisualStyleBackColor = false;
            btnMoney100.Click += btnMoney_Click;
            // 
            // btnMoney200
            // 
            btnMoney200.BackColor = Color.FromArgb(241, 196, 15);
            btnMoney200.Cursor = Cursors.Hand;
            btnMoney200.FlatAppearance.BorderSize = 0;
            btnMoney200.FlatStyle = FlatStyle.Flat;
            btnMoney200.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoney200.Location = new Point(3, 41);
            btnMoney200.Name = "btnMoney200";
            btnMoney200.Size = new Size(100, 32);
            btnMoney200.TabIndex = 3;
            btnMoney200.Text = "P200";
            btnMoney200.UseVisualStyleBackColor = false;
            btnMoney200.Click += btnMoney_Click;
            // 
            // btnMoney500
            // 
            btnMoney500.BackColor = Color.FromArgb(241, 196, 15);
            btnMoney500.Cursor = Cursors.Hand;
            btnMoney500.FlatAppearance.BorderSize = 0;
            btnMoney500.FlatStyle = FlatStyle.Flat;
            btnMoney500.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoney500.Location = new Point(109, 41);
            btnMoney500.Name = "btnMoney500";
            btnMoney500.Size = new Size(100, 32);
            btnMoney500.TabIndex = 4;
            btnMoney500.Text = "P500";
            btnMoney500.UseVisualStyleBackColor = false;
            btnMoney500.Click += btnMoney_Click;
            // 
            // btnMoney1000
            // 
            btnMoney1000.BackColor = Color.FromArgb(241, 196, 15);
            btnMoney1000.Cursor = Cursors.Hand;
            btnMoney1000.FlatAppearance.BorderSize = 0;
            btnMoney1000.FlatStyle = FlatStyle.Flat;
            btnMoney1000.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoney1000.Location = new Point(215, 41);
            btnMoney1000.Name = "btnMoney1000";
            btnMoney1000.Size = new Size(100, 32);
            btnMoney1000.TabIndex = 5;
            btnMoney1000.Text = "P1000";
            btnMoney1000.UseVisualStyleBackColor = false;
            btnMoney1000.Click += btnMoney_Click;
            // 
            // lblInserted
            // 
            lblInserted.AutoSize = true;
            lblInserted.Font = new Font("Segoe UI", 10F);
            lblInserted.Location = new Point(10, 263);
            lblInserted.Name = "lblInserted";
            lblInserted.Size = new Size(101, 19);
            lblInserted.TabIndex = 5;
            lblInserted.Text = "Inserted: P0.00";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 10F);
            lblChange.Location = new Point(10, 284);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(102, 19);
            lblChange.TabIndex = 6;
            lblChange.Text = "Change:  P0.00";
            // 
            // lblExamine
            // 
            lblExamine.AutoSize = true;
            lblExamine.Font = new Font("Segoe UI", 9F);
            lblExamine.ForeColor = Color.Gray;
            lblExamine.Location = new Point(10, 312);
            lblExamine.Name = "lblExamine";
            lblExamine.Size = new Size(81, 15);
            lblExamine.TabIndex = 7;
            lblExamine.Text = "Examine Item:";
            // 
            // cboExamineItem
            // 
            cboExamineItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExamineItem.Font = new Font("Segoe UI", 9F);
            cboExamineItem.FormattingEnabled = true;
            cboExamineItem.Location = new Point(10, 331);
            cboExamineItem.Name = "cboExamineItem";
            cboExamineItem.Size = new Size(210, 23);
            cboExamineItem.TabIndex = 8;
            // 
            // btnExamine
            // 
            btnExamine.BackColor = Color.FromArgb(52, 152, 219);
            btnExamine.Cursor = Cursors.Hand;
            btnExamine.FlatAppearance.BorderSize = 0;
            btnExamine.FlatStyle = FlatStyle.Flat;
            btnExamine.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExamine.ForeColor = Color.White;
            btnExamine.Location = new Point(227, 330);
            btnExamine.Name = "btnExamine";
            btnExamine.Size = new Size(103, 25);
            btnExamine.TabIndex = 9;
            btnExamine.Text = "EXAMINE";
            btnExamine.UseVisualStyleBackColor = false;
            btnExamine.Click += btnExamine_Click;
            // 
            // recycleGroup
            // 
            recycleGroup.Controls.Add(lblRecycleType);
            recycleGroup.Controls.Add(cboRecycleType);
            recycleGroup.Controls.Add(lblRecycleQty);
            recycleGroup.Controls.Add(nudRecycleQty);
            recycleGroup.Controls.Add(btnRecycle);
            recycleGroup.Controls.Add(lblRecycleStatus);
            recycleGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            recycleGroup.Location = new Point(10, 360);
            recycleGroup.Name = "recycleGroup";
            recycleGroup.Size = new Size(330, 88);
            recycleGroup.TabIndex = 10;
            recycleGroup.TabStop = false;
            recycleGroup.Text = "Recycle for Credit";
            // 
            // lblRecycleType
            // 
            lblRecycleType.AutoSize = true;
            lblRecycleType.Font = new Font("Segoe UI", 9F);
            lblRecycleType.Location = new Point(9, 23);
            lblRecycleType.Name = "lblRecycleType";
            lblRecycleType.Size = new Size(32, 15);
            lblRecycleType.TabIndex = 0;
            lblRecycleType.Text = "Type";
            // 
            // cboRecycleType
            // 
            cboRecycleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRecycleType.Font = new Font("Segoe UI", 9F);
            cboRecycleType.FormattingEnabled = true;
            cboRecycleType.Location = new Point(58, 20);
            cboRecycleType.Name = "cboRecycleType";
            cboRecycleType.Size = new Size(142, 23);
            cboRecycleType.TabIndex = 1;
            // 
            // lblRecycleQty
            // 
            lblRecycleQty.AutoSize = true;
            lblRecycleQty.Font = new Font("Segoe UI", 9F);
            lblRecycleQty.Location = new Point(202, 24);
            lblRecycleQty.Name = "lblRecycleQty";
            lblRecycleQty.Size = new Size(69, 15);
            lblRecycleQty.TabIndex = 2;
            lblRecycleQty.Text = "Weight (kg)";
            // 
            // nudRecycleQty
            // 
            nudRecycleQty.DecimalPlaces = 2;
            nudRecycleQty.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudRecycleQty.Location = new Point(272, 21);
            nudRecycleQty.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudRecycleQty.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            nudRecycleQty.Name = "nudRecycleQty";
            nudRecycleQty.Size = new Size(52, 23);
            nudRecycleQty.TabIndex = 3;
            nudRecycleQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRecycle
            // 
            btnRecycle.BackColor = Color.FromArgb(39, 174, 96);
            btnRecycle.Cursor = Cursors.Hand;
            btnRecycle.FlatAppearance.BorderSize = 0;
            btnRecycle.FlatStyle = FlatStyle.Flat;
            btnRecycle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRecycle.ForeColor = Color.White;
            btnRecycle.Location = new Point(58, 49);
            btnRecycle.Name = "btnRecycle";
            btnRecycle.Size = new Size(132, 30);
            btnRecycle.TabIndex = 4;
            btnRecycle.Text = "ADD CREDIT";
            btnRecycle.UseVisualStyleBackColor = false;
            btnRecycle.Click += btnRecycle_Click;
            // 
            // lblRecycleStatus
            // 
            lblRecycleStatus.Font = new Font("Segoe UI", 9F);
            lblRecycleStatus.ForeColor = Color.FromArgb(39, 174, 96);
            lblRecycleStatus.Location = new Point(196, 53);
            lblRecycleStatus.Name = "lblRecycleStatus";
            lblRecycleStatus.Size = new Size(119, 23);
            lblRecycleStatus.TabIndex = 5;
            lblRecycleStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.FromArgb(34, 139, 34);
            btnPurchase.Cursor = Cursors.Hand;
            btnPurchase.Enabled = false;
            btnPurchase.FlatAppearance.BorderSize = 0;
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPurchase.ForeColor = Color.White;
            btnPurchase.Location = new Point(10, 452);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(330, 32);
            btnPurchase.TabIndex = 11;
            btnPurchase.Text = "PURCHASE";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(52, 73, 94);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(10, 490);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(160, 32);
            btnBack.TabIndex = 12;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 57, 43);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(180, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 32);
            btnClear.TabIndex = 13;
            btnClear.Text = "CLEAR CART";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 250, 245);
            ClientSize = new Size(980, 590);
            Controls.Add(paymentGroup);
            Controls.Add(leftPanel);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECO-MATIC  CUSTOMER";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            cartContextMenu.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            productPanel.ResumeLayout(false);
            paymentGroup.ResumeLayout(false);
            paymentGroup.PerformLayout();
            moneyFlow.ResumeLayout(false);
            recycleGroup.ResumeLayout(false);
            recycleGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRecycleQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem backMenuItem;
        private ToolStripMenuItem openReadmeMenuItem;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem howToBuyMenuItem;
        private ContextMenuStrip cartContextMenu;
        private ToolStripMenuItem removeItemMenuItem;
        private ToolStripMenuItem clearAllMenuItem;
        private Panel leftPanel;
        private FlowLayoutPanel productPanel;
        private Button btnProd1;
        private Button btnProd2;
        private Button btnProd3;
        private Button btnProd4;
        private Button btnProd5;
        private Button btnProd6;
        private Button btnProd7;
        private Button btnProd8;
        private Button btnProd9;
        private Button btnProd10;
        private Button btnProd11;
        private Button btnProd12;
        private Button btnProd13;
        private Button btnProd14;
        private Button btnProd15;
        private GroupBox paymentGroup;
        private Label lblCart;
        private ListBox cartList;
        private Label lblTotal;
        private Label lblInsertHint;
        private FlowLayoutPanel moneyFlow;
        private Button btnMoney20;
        private Button btnMoney50;
        private Button btnMoney100;
        private Button btnMoney200;
        private Button btnMoney500;
        private Button btnMoney1000;
        private Label lblInserted;
        private Label lblChange;
        private Label lblExamine;
        private ComboBox cboExamineItem;
        private Button btnExamine;
        private GroupBox recycleGroup;
        private Label lblRecycleType;
        private ComboBox cboRecycleType;
        private Label lblRecycleQty;
        private NumericUpDown nudRecycleQty;
        private Button btnRecycle;
        private Label lblRecycleStatus;
        private Button btnPurchase;
        private Button btnBack;
        private Button btnClear;
    }
}
