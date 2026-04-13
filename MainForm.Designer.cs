namespace Eco_Matic_Winforms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── MenuStrip ──
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReadmeMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // ── Panels ──
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();

            // ── Left panel contents ──
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblEcoMatic = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblJapanese = new System.Windows.Forms.Label();

            // ── Right panel buttons ──
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            // ── Footer ──
            this.lblFooter = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // ════════════════════════════════════════
            //  menuStrip
            // ════════════════════════════════════════
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.menuStrip.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileMenu, this.helpMenu });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(580, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;

            // fileMenu
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Text = "File";
            this.fileMenu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.openReadmeMenuItem.Name = "openReadmeMenuItem";
            this.openReadmeMenuItem.Text = "Open ReadMe";
            this.openReadmeMenuItem.Click += new System.EventHandler(this.openReadmeMenuItem_Click);
            this.fileMenu.DropDownItems.Add(this.openReadmeMenuItem);

            // helpMenu
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Text = "Help";
            this.helpMenu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            this.helpMenu.DropDownItems.Add(this.aboutMenuItem);

            // ════════════════════════════════════════
            //  leftPanel (logo area)
            // ════════════════════════════════════════
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leftPanel.Controls.Add(this.lblLogo);
            this.leftPanel.Controls.Add(this.lblEcoMatic);
            this.leftPanel.Controls.Add(this.lblSubtitle);
            this.leftPanel.Controls.Add(this.lblTagline);
            this.leftPanel.Controls.Add(this.lblJapanese);
            this.leftPanel.Location = new System.Drawing.Point(25, 40);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(260, 310);
            this.leftPanel.TabIndex = 1;

            // lblLogo
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 52F);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(0, 210, 255);
            this.lblLogo.Location = new System.Drawing.Point(0, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(260, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🌿";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblEcoMatic
            this.lblEcoMatic.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblEcoMatic.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.lblEcoMatic.Location = new System.Drawing.Point(0, 105);
            this.lblEcoMatic.Name = "lblEcoMatic";
            this.lblEcoMatic.Size = new System.Drawing.Size(260, 45);
            this.lblEcoMatic.TabIndex = 1;
            this.lblEcoMatic.Text = "ECO-MATIC";
            this.lblEcoMatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblSubtitle.Location = new System.Drawing.Point(0, 155);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(260, 22);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "VENDING MACHINE";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTagline
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblTagline.Location = new System.Drawing.Point(0, 185);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(260, 20);
            this.lblTagline.TabIndex = 3;
            this.lblTagline.Text = "Fresh \u2022 Fast \u2022 Eco-Friendly";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblJapanese
            this.lblJapanese = new System.Windows.Forms.Label();
            this.lblJapanese.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJapanese.ForeColor = System.Drawing.Color.FromArgb(232, 67, 147);
            this.lblJapanese.Location = new System.Drawing.Point(0, 215);
            this.lblJapanese.Name = "lblJapanese";
            this.lblJapanese.Size = new System.Drawing.Size(260, 20);
            this.lblJapanese.Text = "エコマティック 自動販売機";
            this.lblJapanese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ════════════════════════════════════════
            //  rightPanel (buttons)
            // ════════════════════════════════════════
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.rightPanel.Controls.Add(this.btnCustomer);
            this.rightPanel.Controls.Add(this.btnAdmin);
            this.rightPanel.Controls.Add(this.btnExit);
            this.rightPanel.Location = new System.Drawing.Point(310, 40);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(245, 310);
            this.rightPanel.TabIndex = 2;

            // btnCustomer
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(0, 150, 80);
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(8, 18);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(230, 75);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "CUSTOMER";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);

            // btnAdmin
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(30, 50, 80);
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(8, 115);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(230, 75);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);

            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(8, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(230, 75);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // ════════════════════════════════════════
            //  lblFooter
            // ════════════════════════════════════════
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblFooter.Location = new System.Drawing.Point(0, 360);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(580, 20);
            this.lblFooter.TabIndex = 3;
            this.lblFooter.Text = "\u00a9 2026 Seanix  ●  エコマティック";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ════════════════════════════════════════
            //  MainForm
            // ════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(580, 390);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.lblFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECO-MATIC VENDING MACHINE";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReadmeMenuItem;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblEcoMatic;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblJapanese;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFooter;
    }
}
