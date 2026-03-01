namespace Eco_Matic_Winforms
{
    partial class ReceiptForm
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
            lblThankYou = new Label();
            sep1 = new Panel();
            itemsPanel = new Panel();
            sep2 = new Panel();
            lblTotal = new Label();
            lblPaid = new Label();
            lblChange = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblThankYou
            // 
            lblThankYou.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            lblThankYou.ForeColor = Color.FromArgb(34, 139, 34);
            lblThankYou.Location = new Point(20, 15);
            lblThankYou.Name = "lblThankYou";
            lblThankYou.Size = new Size(340, 80);
            lblThankYou.TabIndex = 0;
            lblThankYou.Text = "Thank You for\r\nusing Eco-Matic!";
            lblThankYou.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sep1
            // 
            sep1.BackColor = Color.FromArgb(180, 180, 180);
            sep1.Location = new Point(20, 100);
            sep1.Name = "sep1";
            sep1.Size = new Size(340, 1);
            sep1.TabIndex = 1;
            // 
            // itemsPanel
            // 
            itemsPanel.AutoScroll = true;
            itemsPanel.Location = new Point(20, 108);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.Size = new Size(340, 170);
            itemsPanel.TabIndex = 2;

            // 
            // sep2
            // 
            sep2.BackColor = Color.FromArgb(180, 180, 180);
            sep2.Location = new Point(20, 285);
            sep2.Name = "sep2";
            sep2.Size = new Size(340, 1);
            sep2.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(34, 139, 34);
            lblTotal.Location = new Point(20, 293);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(340, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total:  ₱0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPaid
            // 
            lblPaid.Font = new Font("Consolas", 10F);
            lblPaid.ForeColor = Color.FromArgb(60, 60, 60);
            lblPaid.Location = new Point(20, 320);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(340, 20);
            lblPaid.TabIndex = 5;
            lblPaid.Text = "Paid:   ₱0.00";
            lblPaid.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblChange
            // 
            lblChange.Font = new Font("Consolas", 10F);
            lblChange.ForeColor = Color.FromArgb(60, 60, 60);
            lblChange.Location = new Point(20, 342);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(340, 20);
            lblChange.TabIndex = 6;
            lblChange.Text = "Change: ₱0.00";
            lblChange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(52, 73, 94);
            btnExit.Cursor = Cursors.Hand;
            btnExit.DialogResult = DialogResult.OK;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(90, 380);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 40);
            btnExit.TabIndex = 7;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(380, 435);
            Controls.Add(btnExit);
            Controls.Add(lblChange);
            Controls.Add(lblPaid);
            Controls.Add(lblTotal);
            Controls.Add(sep2);
            Controls.Add(itemsPanel);
            Controls.Add(sep1);
            Controls.Add(lblThankYou);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ECO-MATIC VENDING MACHINE";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Panel sep1;
        private System.Windows.Forms.Panel itemsPanel;
        private System.Windows.Forms.Panel sep2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnExit;
    }
}
