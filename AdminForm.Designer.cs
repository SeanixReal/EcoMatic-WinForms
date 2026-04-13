namespace Eco_Matic_Winforms
{
    partial class AdminForm
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
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            backMenuItem = new ToolStripMenuItem();
            openReadmeMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            adminHelpMenuItem = new ToolStripMenuItem();
            inventoryGrid = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colFlavor = new DataGridViewTextBoxColumn();
            restockGroup = new GroupBox();
            btnRestockAdd = new Button();
            lblRestockQty = new Label();
            nudRestockQty = new NumericUpDown();
            lblItem = new Label();
            cboItem = new ComboBox();
            btnUpdate = new Button();
            btnBack = new Button();
            addGroup = new GroupBox();
            lblAddName = new Label();
            txtAddName = new TextBox();
            lblAddType = new Label();
            cboAddType = new ComboBox();
            lblAddPrice = new Label();
            nudAddPrice = new NumericUpDown();
            lblAddStock = new Label();
            nudAddStock = new NumericUpDown();
            lblEditSlotId = new Label();
            nudEditSlotId = new NumericUpDown();
            lblAddFlavor = new Label();
            txtAddFlavor = new TextBox();
            lblAddCalories = new Label();
            nudAddCalories = new NumericUpDown();
            lblAddVolume = new Label();
            nudAddVolume = new NumericUpDown();
            btnBrowseImage = new Button();
            lblImagePath = new Label();
            picImagePreview = new PictureBox();
            btnAddItem = new Button();
            btnUpdateItem = new Button();
            dlgOpenImage = new OpenFileDialog();
            manageGroup = new GroupBox();
            lblRemoveItem = new Label();
            cboRemoveItem = new ComboBox();
            btnRemoveItem = new Button();
            btnViewLog = new Button();
            btnClearLog = new Button();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).BeginInit();
            restockGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRestockQty).BeginInit();
            addGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEditSlotId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddCalories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImagePreview).BeginInit();
            manageGroup.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(230, 240, 230);
            menuStrip.Font = new Font("Segoe UI", 10F);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, helpMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(900, 27);
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
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { adminHelpMenuItem });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(49, 23);
            helpMenu.Text = "Help";
            // 
            // adminHelpMenuItem
            // 
            adminHelpMenuItem.Name = "adminHelpMenuItem";
            adminHelpMenuItem.Size = new Size(150, 24);
            adminHelpMenuItem.Text = "Admin Help";
            adminHelpMenuItem.Click += adminHelpMenuItem_Click;
            // 
            // inventoryGrid
            // 
            inventoryGrid.AllowUserToAddRows = false;
            inventoryGrid.AllowUserToDeleteRows = false;
            inventoryGrid.AllowUserToResizeRows = false;
            inventoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryGrid.BackgroundColor = Color.White;
            inventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGrid.Columns.AddRange(new DataGridViewColumn[] { colId, colType, colName, colPrice, colStock, colFlavor });
            inventoryGrid.Location = new Point(15, 40);
            inventoryGrid.Name = "inventoryGrid";
            inventoryGrid.ReadOnly = true;
            inventoryGrid.RowHeadersVisible = false;
            inventoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inventoryGrid.Size = new Size(870, 255);
            inventoryGrid.TabIndex = 1;
            inventoryGrid.CellClick += inventoryGrid_CellClick;
            inventoryGrid.SelectionChanged += inventoryGrid_SelectionChanged;
            // 
            // colId
            // 
            colId.FillWeight = 50F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colType
            // 
            colType.FillWeight = 70F;
            colType.HeaderText = "Type";
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colName
            // 
            colName.FillWeight = 130F;
            colName.HeaderText = "Item Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.FillWeight = 80F;
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.FillWeight = 70F;
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colFlavor
            // 
            colFlavor.FillWeight = 220F;
            colFlavor.HeaderText = "Flavor / Description";
            colFlavor.Name = "colFlavor";
            colFlavor.ReadOnly = true;
            // 
            // restockGroup
            // 
            restockGroup.Controls.Add(btnRestockAdd);
            restockGroup.Controls.Add(lblRestockQty);
            restockGroup.Controls.Add(nudRestockQty);
            restockGroup.Controls.Add(lblItem);
            restockGroup.Controls.Add(cboItem);
            restockGroup.Controls.Add(btnUpdate);
            restockGroup.Controls.Add(btnBack);
            restockGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            restockGroup.ForeColor = Color.FromArgb(52, 73, 94);
            restockGroup.Location = new Point(15, 305);
            restockGroup.Name = "restockGroup";
            restockGroup.Size = new Size(870, 108);
            restockGroup.TabIndex = 2;
            restockGroup.TabStop = false;
            restockGroup.Text = "Restock Tools";
            // 
            // btnRestockAdd
            // 
            btnRestockAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnRestockAdd.FlatAppearance.BorderSize = 0;
            btnRestockAdd.FlatStyle = FlatStyle.Flat;
            btnRestockAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRestockAdd.ForeColor = Color.White;
            btnRestockAdd.Location = new Point(610, 64);
            btnRestockAdd.Name = "btnRestockAdd";
            btnRestockAdd.Size = new Size(246, 30);
            btnRestockAdd.TabIndex = 6;
            btnRestockAdd.Text = "ADD STOCK";
            btnRestockAdd.UseVisualStyleBackColor = false;
            btnRestockAdd.Click += btnRestockAdd_Click;
            // 
            // lblRestockQty
            // 
            lblRestockQty.AutoSize = true;
            lblRestockQty.Font = new Font("Segoe UI", 10F);
            lblRestockQty.Location = new Point(357, 34);
            lblRestockQty.Name = "lblRestockQty";
            lblRestockQty.Size = new Size(61, 19);
            lblRestockQty.TabIndex = 4;
            lblRestockQty.Text = "Add Qty";
            // 
            // nudRestockQty
            // 
            nudRestockQty.Font = new Font("Segoe UI", 10F);
            nudRestockQty.Location = new Point(419, 30);
            nudRestockQty.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            nudRestockQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRestockQty.Name = "nudRestockQty";
            nudRestockQty.Size = new Size(75, 25);
            nudRestockQty.TabIndex = 5;
            nudRestockQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Segoe UI", 10F);
            lblItem.Location = new Point(15, 34);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(79, 19);
            lblItem.TabIndex = 0;
            lblItem.Text = "Select Item:";
            // 
            // cboItem
            // 
            cboItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboItem.Font = new Font("Segoe UI", 10F);
            cboItem.FormattingEnabled = true;
            cboItem.Location = new Point(101, 30);
            cboItem.Name = "cboItem";
            cboItem.Size = new Size(250, 25);
            cboItem.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(34, 139, 34);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(610, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 32);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "RESTOCK MAX";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(52, 73, 94);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(736, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 32);
            btnBack.TabIndex = 3;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // addGroup
            // 
            addGroup.Controls.Add(lblAddName);
            addGroup.Controls.Add(txtAddName);
            addGroup.Controls.Add(lblAddType);
            addGroup.Controls.Add(cboAddType);
            addGroup.Controls.Add(lblAddPrice);
            addGroup.Controls.Add(nudAddPrice);
            addGroup.Controls.Add(lblAddStock);
            addGroup.Controls.Add(nudAddStock);
            addGroup.Controls.Add(lblEditSlotId);
            addGroup.Controls.Add(nudEditSlotId);
            addGroup.Controls.Add(lblAddFlavor);
            addGroup.Controls.Add(txtAddFlavor);
            addGroup.Controls.Add(lblAddCalories);
            addGroup.Controls.Add(nudAddCalories);
            addGroup.Controls.Add(lblAddVolume);
            addGroup.Controls.Add(nudAddVolume);
            addGroup.Controls.Add(btnBrowseImage);
            addGroup.Controls.Add(lblImagePath);
            addGroup.Controls.Add(picImagePreview);
            addGroup.Controls.Add(btnAddItem);
            addGroup.Controls.Add(btnUpdateItem);
            addGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addGroup.ForeColor = Color.FromArgb(52, 73, 94);
            addGroup.Location = new Point(15, 421);
            addGroup.Name = "addGroup";
            addGroup.Size = new Size(520, 230);
            addGroup.TabIndex = 3;
            addGroup.TabStop = false;
            addGroup.Text = "Add Item";
            // 
            // lblAddName
            // 
            lblAddName.AutoSize = true;
            lblAddName.Font = new Font("Segoe UI", 9F);
            lblAddName.Location = new Point(15, 28);
            lblAddName.Name = "lblAddName";
            lblAddName.Size = new Size(39, 15);
            lblAddName.TabIndex = 0;
            lblAddName.Text = "Name";
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(79, 25);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(190, 25);
            txtAddName.TabIndex = 1;
            // 
            // lblAddType
            // 
            lblAddType.AutoSize = true;
            lblAddType.Font = new Font("Segoe UI", 9F);
            lblAddType.Location = new Point(275, 28);
            lblAddType.Name = "lblAddType";
            lblAddType.Size = new Size(32, 15);
            lblAddType.TabIndex = 2;
            lblAddType.Text = "Type";
            // 
            // cboAddType
            // 
            cboAddType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAddType.Font = new Font("Segoe UI", 9F);
            cboAddType.FormattingEnabled = true;
            cboAddType.Location = new Point(312, 25);
            cboAddType.Name = "cboAddType";
            cboAddType.Size = new Size(190, 23);
            cboAddType.TabIndex = 3;
            cboAddType.SelectedIndexChanged += cboAddType_SelectedIndexChanged;
            // 
            // lblAddPrice
            // 
            lblAddPrice.AutoSize = true;
            lblAddPrice.Font = new Font("Segoe UI", 9F);
            lblAddPrice.Location = new Point(15, 58);
            lblAddPrice.Name = "lblAddPrice";
            lblAddPrice.Size = new Size(33, 15);
            lblAddPrice.TabIndex = 4;
            lblAddPrice.Text = "Price";
            // 
            // nudAddPrice
            // 
            nudAddPrice.DecimalPlaces = 2;
            nudAddPrice.Font = new Font("Segoe UI", 9F);
            nudAddPrice.Location = new Point(79, 56);
            nudAddPrice.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudAddPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAddPrice.Name = "nudAddPrice";
            nudAddPrice.Size = new Size(110, 23);
            nudAddPrice.TabIndex = 5;
            nudAddPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAddStock
            // 
            lblAddStock.AutoSize = true;
            lblAddStock.Font = new Font("Segoe UI", 9F);
            lblAddStock.Location = new Point(195, 58);
            lblAddStock.Name = "lblAddStock";
            lblAddStock.Size = new Size(36, 15);
            lblAddStock.TabIndex = 6;
            lblAddStock.Text = "Stock";
            // 
            // nudAddStock
            // 
            nudAddStock.Font = new Font("Segoe UI", 9F);
            nudAddStock.Location = new Point(236, 56);
            nudAddStock.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            nudAddStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAddStock.Name = "nudAddStock";
            nudAddStock.Size = new Size(82, 23);
            nudAddStock.TabIndex = 7;
            nudAddStock.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // lblEditSlotId
            // 
            lblEditSlotId.AutoSize = true;
            lblEditSlotId.Font = new Font("Segoe UI", 9F);
            lblEditSlotId.Location = new Point(324, 58);
            lblEditSlotId.Name = "lblEditSlotId";
            lblEditSlotId.Size = new Size(44, 15);
            lblEditSlotId.TabIndex = 8;
            lblEditSlotId.Text = "Slot ID";
            // 
            // nudEditSlotId
            // 
            nudEditSlotId.Font = new Font("Segoe UI", 9F);
            nudEditSlotId.Location = new Point(374, 56);
            nudEditSlotId.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudEditSlotId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudEditSlotId.Name = "nudEditSlotId";
            nudEditSlotId.Size = new Size(128, 23);
            nudEditSlotId.TabIndex = 9;
            nudEditSlotId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAddFlavor
            // 
            lblAddFlavor.AutoSize = true;
            lblAddFlavor.Font = new Font("Segoe UI", 9F);
            lblAddFlavor.Location = new Point(15, 89);
            lblAddFlavor.Name = "lblAddFlavor";
            lblAddFlavor.Size = new Size(67, 15);
            lblAddFlavor.TabIndex = 10;
            lblAddFlavor.Text = "Description";
            // 
            // txtAddFlavor
            // 
            txtAddFlavor.Location = new Point(91, 86);
            txtAddFlavor.Name = "txtAddFlavor";
            txtAddFlavor.Size = new Size(411, 25);
            txtAddFlavor.TabIndex = 11;
            // 
            // lblAddCalories
            // 
            lblAddCalories.AutoSize = true;
            lblAddCalories.Font = new Font("Segoe UI", 9F);
            lblAddCalories.Location = new Point(15, 121);
            lblAddCalories.Name = "lblAddCalories";
            lblAddCalories.Size = new Size(49, 15);
            lblAddCalories.TabIndex = 12;
            lblAddCalories.Text = "Calories";
            // 
            // nudAddCalories
            // 
            nudAddCalories.Font = new Font("Segoe UI", 9F);
            nudAddCalories.Location = new Point(79, 118);
            nudAddCalories.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudAddCalories.Name = "nudAddCalories";
            nudAddCalories.Size = new Size(110, 23);
            nudAddCalories.TabIndex = 13;
            // 
            // lblAddVolume
            // 
            lblAddVolume.AutoSize = true;
            lblAddVolume.Font = new Font("Segoe UI", 9F);
            lblAddVolume.Location = new Point(196, 121);
            lblAddVolume.Name = "lblAddVolume";
            lblAddVolume.Size = new Size(67, 15);
            lblAddVolume.TabIndex = 14;
            lblAddVolume.Text = "Volume mL";
            // 
            // nudAddVolume
            // 
            nudAddVolume.Font = new Font("Segoe UI", 9F);
            nudAddVolume.Location = new Point(269, 118);
            nudAddVolume.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudAddVolume.Name = "nudAddVolume";
            nudAddVolume.Size = new Size(110, 23);
            nudAddVolume.TabIndex = 15;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.BackColor = Color.FromArgb(41, 128, 185);
            btnBrowseImage.FlatAppearance.BorderSize = 0;
            btnBrowseImage.FlatStyle = FlatStyle.Flat;
            btnBrowseImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBrowseImage.ForeColor = Color.White;
            btnBrowseImage.Location = new Point(15, 154);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(110, 26);
            btnBrowseImage.TabIndex = 16;
            btnBrowseImage.Text = "Browse Image...";
            btnBrowseImage.UseVisualStyleBackColor = false;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // lblImagePath
            // 
            lblImagePath.Font = new Font("Segoe UI", 8F);
            lblImagePath.ForeColor = Color.Gray;
            lblImagePath.Location = new Point(131, 161);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(290, 18);
            lblImagePath.TabIndex = 17;
            lblImagePath.Text = "No image selected";
            // 
            // picImagePreview
            // 
            picImagePreview.BackColor = Color.FromArgb(240, 240, 240);
            picImagePreview.BorderStyle = BorderStyle.FixedSingle;
            picImagePreview.Location = new Point(426, 123);
            picImagePreview.Name = "picImagePreview";
            picImagePreview.Size = new Size(77, 60);
            picImagePreview.SizeMode = PictureBoxSizeMode.Zoom;
            picImagePreview.TabIndex = 18;
            picImagePreview.TabStop = false;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(39, 174, 96);
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(15, 192);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(240, 30);
            btnAddItem.TabIndex = 19;
            btnAddItem.Text = "ADD ITEM";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.BackColor = Color.FromArgb(243, 156, 18);
            btnUpdateItem.FlatAppearance.BorderSize = 0;
            btnUpdateItem.FlatStyle = FlatStyle.Flat;
            btnUpdateItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateItem.ForeColor = Color.White;
            btnUpdateItem.Location = new Point(262, 192);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(240, 30);
            btnUpdateItem.TabIndex = 20;
            btnUpdateItem.Text = "UPDATE SELECTED ITEM";
            btnUpdateItem.UseVisualStyleBackColor = false;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // dlgOpenImage
            // 
            dlgOpenImage.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif|All Files|*.*";
            dlgOpenImage.Title = "Select Product Image";
            // 
            // manageGroup
            // 
            manageGroup.Controls.Add(lblRemoveItem);
            manageGroup.Controls.Add(cboRemoveItem);
            manageGroup.Controls.Add(btnRemoveItem);
            manageGroup.Controls.Add(btnViewLog);
            manageGroup.Controls.Add(btnClearLog);
            manageGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            manageGroup.ForeColor = Color.FromArgb(52, 73, 94);
            manageGroup.Location = new Point(545, 421);
            manageGroup.Name = "manageGroup";
            manageGroup.Size = new Size(340, 186);
            manageGroup.TabIndex = 4;
            manageGroup.TabStop = false;
            manageGroup.Text = "Remove / Log Tools";
            // 
            // lblRemoveItem
            // 
            lblRemoveItem.AutoSize = true;
            lblRemoveItem.Font = new Font("Segoe UI", 9F);
            lblRemoveItem.Location = new Point(12, 30);
            lblRemoveItem.Name = "lblRemoveItem";
            lblRemoveItem.Size = new Size(77, 15);
            lblRemoveItem.TabIndex = 0;
            lblRemoveItem.Text = "Remove item";
            // 
            // cboRemoveItem
            // 
            cboRemoveItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRemoveItem.Font = new Font("Segoe UI", 9F);
            cboRemoveItem.FormattingEnabled = true;
            cboRemoveItem.Location = new Point(12, 48);
            cboRemoveItem.Name = "cboRemoveItem";
            cboRemoveItem.Size = new Size(316, 23);
            cboRemoveItem.TabIndex = 1;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.FromArgb(192, 57, 43);
            btnRemoveItem.FlatAppearance.BorderSize = 0;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(12, 77);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(316, 30);
            btnRemoveItem.TabIndex = 2;
            btnRemoveItem.Text = "REMOVE SELECTED ITEM";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnViewLog
            // 
            btnViewLog.BackColor = Color.FromArgb(41, 128, 185);
            btnViewLog.FlatAppearance.BorderSize = 0;
            btnViewLog.FlatStyle = FlatStyle.Flat;
            btnViewLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewLog.ForeColor = Color.White;
            btnViewLog.Location = new Point(12, 123);
            btnViewLog.Name = "btnViewLog";
            btnViewLog.Size = new Size(316, 28);
            btnViewLog.TabIndex = 3;
            btnViewLog.Text = "VIEW EVENT LOG";
            btnViewLog.UseVisualStyleBackColor = false;
            btnViewLog.Click += btnViewLog_Click;
            // 
            // btnClearLog
            // 
            btnClearLog.BackColor = Color.FromArgb(127, 140, 141);
            btnClearLog.FlatAppearance.BorderSize = 0;
            btnClearLog.FlatStyle = FlatStyle.Flat;
            btnClearLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearLog.ForeColor = Color.White;
            btnClearLog.Location = new Point(12, 154);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(316, 28);
            btnClearLog.TabIndex = 4;
            btnClearLog.Text = "CLEAR EVENT LOG";
            btnClearLog.UseVisualStyleBackColor = false;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 250, 245);
            ClientSize = new Size(900, 665);
            Controls.Add(manageGroup);
            Controls.Add(addGroup);
            Controls.Add(restockGroup);
            Controls.Add(inventoryGrid);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECO-MATIC  ADMIN";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).EndInit();
            restockGroup.ResumeLayout(false);
            restockGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRestockQty).EndInit();
            addGroup.ResumeLayout(false);
            addGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEditSlotId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddCalories).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImagePreview).EndInit();
            manageGroup.ResumeLayout(false);
            manageGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem backMenuItem;
        private ToolStripMenuItem openReadmeMenuItem;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem adminHelpMenuItem;
        private DataGridView inventoryGrid;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colFlavor;
        private GroupBox restockGroup;
        private Label lblItem;
        private ComboBox cboItem;
        private Button btnUpdate;
        private Button btnBack;
        private Label lblRestockQty;
        private NumericUpDown nudRestockQty;
        private Button btnRestockAdd;
        private GroupBox addGroup;
        private Label lblAddName;
        private TextBox txtAddName;
        private Label lblAddType;
        private ComboBox cboAddType;
        private Label lblAddPrice;
        private NumericUpDown nudAddPrice;
        private Label lblAddStock;
        private NumericUpDown nudAddStock;
        private Label lblEditSlotId;
        private NumericUpDown nudEditSlotId;
        private Label lblAddFlavor;
        private TextBox txtAddFlavor;
        private Label lblAddCalories;
        private NumericUpDown nudAddCalories;
        private Label lblAddVolume;
        private NumericUpDown nudAddVolume;
        private Button btnBrowseImage;
        private Label lblImagePath;
        private PictureBox picImagePreview;
        private OpenFileDialog dlgOpenImage;
        private Button btnAddItem;
        private Button btnUpdateItem;
        private GroupBox manageGroup;
        private Label lblRemoveItem;
        private ComboBox cboRemoveItem;
        private Button btnRemoveItem;
        private Button btnViewLog;
        private Button btnClearLog;
    }
}
