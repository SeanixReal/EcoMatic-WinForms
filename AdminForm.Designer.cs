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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            backMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            adminHelpMenuItem = new ToolStripMenuItem();

            openReadmeMenuItem = new ToolStripMenuItem();
            inventoryGrid = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            restockGroup = new GroupBox();
            lblItem = new Label();
            cboItem = new ComboBox();
            lblQty = new Label();
            nudQty = new NumericUpDown();
            btnUpdate = new Button();
            btnBack = new Button();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).BeginInit();
            restockGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            SuspendLayout();

            menuStrip.BackColor = Color.FromArgb(230, 240, 230);
            menuStrip.Font = new Font("Segoe UI", 10F);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, helpMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(660, 27);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";

            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { backMenuItem, openReadmeMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(41, 23);
            fileMenu.Text = "File";

            backMenuItem.Name = "backMenuItem";
            backMenuItem.Size = new Size(158, 24);
            backMenuItem.Text = "Back to Main";
            backMenuItem.Click += backMenuItem_Click;
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
            // openReadmeMenuItem
            // 
            openReadmeMenuItem.Name = "openReadmeMenuItem";
            openReadmeMenuItem.Size = new Size(166, 24);
            openReadmeMenuItem.Text = "Open ReadMe";
            openReadmeMenuItem.Click += openReadmeMenuItem_Click;
            // 
            // inventoryGrid
            // 
            inventoryGrid.AllowUserToAddRows = false;
            inventoryGrid.AllowUserToDeleteRows = false;
            inventoryGrid.AllowUserToResizeRows = false;
            inventoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryGrid.BackgroundColor = Color.White;
            inventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            inventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGrid.Columns.AddRange(new DataGridViewColumn[] { colName, colPrice, colStock });
            inventoryGrid.EnableHeadersVisualStyles = false;
            inventoryGrid.Font = new Font("Segoe UI", 10F);
            inventoryGrid.Location = new Point(15, 40);
            inventoryGrid.Name = "inventoryGrid";
            inventoryGrid.ReadOnly = true;
            inventoryGrid.RowHeadersVisible = false;
            inventoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inventoryGrid.Size = new Size(630, 350);
            inventoryGrid.TabIndex = 1;

            // 
            // colName
            // 
            colName.HeaderText = "Item Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price (₱)";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // restockGroup
            // 
            restockGroup.Controls.Add(lblItem);
            restockGroup.Controls.Add(cboItem);
            restockGroup.Controls.Add(lblQty);
            restockGroup.Controls.Add(nudQty);
            restockGroup.Controls.Add(btnUpdate);
            restockGroup.Controls.Add(btnBack);
            restockGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            restockGroup.ForeColor = Color.FromArgb(52, 73, 94);
            restockGroup.Location = new Point(15, 400);
            restockGroup.Name = "restockGroup";
            restockGroup.Size = new Size(630, 100);
            restockGroup.TabIndex = 2;
            restockGroup.TabStop = false;
            restockGroup.Text = "  Restock  ";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Segoe UI", 10F);
            lblItem.Location = new Point(15, 30);
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
            cboItem.Items.AddRange(new object[] { "Sample Item" });
            cboItem.Location = new Point(115, 27);
            cboItem.Name = "cboItem";
            cboItem.Size = new Size(200, 25);
            cboItem.TabIndex = 1;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 10F);
            lblQty.Location = new Point(15, 63);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(66, 19);
            lblQty.TabIndex = 2;
            lblQty.Text = "Quantity:";
            // 
            // nudQty
            // 
            nudQty.Font = new Font("Segoe UI", 10F);
            nudQty.Location = new Point(115, 60);
            nudQty.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(100, 25);
            nudQty.TabIndex = 3;
            nudQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(34, 139, 34);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(440, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 35);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE STOCK";
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
            btnBack.Location = new Point(440, 60);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(175, 35);
            btnBack.TabIndex = 5;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack2_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 250, 245);
            ClientSize = new Size(660, 520);
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
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminHelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReadmeMenuItem;
        private System.Windows.Forms.DataGridView inventoryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.GroupBox restockGroup;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}
