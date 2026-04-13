namespace Eco_Matic_Winforms
{
    partial class CustomerRegistrationForm
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
            lblTitle = new Label();
            lblRfid = new Label();
            txtRfid = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 64, 175);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(356, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "RFID Customer Registration";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRfid
            // 
            lblRfid.AutoSize = true;
            lblRfid.ForeColor = Color.FromArgb(51, 65, 85);
            lblRfid.Location = new Point(24, 56);
            lblRfid.Name = "lblRfid";
            lblRfid.Size = new Size(61, 15);
            lblRfid.TabIndex = 1;
            lblRfid.Text = "RFID Card";
            // 
            // txtRfid
            // 
            txtRfid.BackColor = Color.White;
            txtRfid.ForeColor = Color.FromArgb(30, 41, 59);
            txtRfid.Location = new Point(24, 74);
            txtRfid.Name = "txtRfid";
            txtRfid.ReadOnly = true;
            txtRfid.Size = new Size(332, 23);
            txtRfid.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(51, 65, 85);
            lblEmail.Location = new Point(24, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.ForeColor = Color.FromArgb(30, 41, 59);
            txtEmail.Location = new Point(24, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(332, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.FromArgb(51, 65, 85);
            lblPassword.Location = new Point(24, 164);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.FromArgb(30, 41, 59);
            txtPassword.Location = new Point(24, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(332, 23);
            txtPassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(39, 174, 96);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(192, 224);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(164, 32);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register Card";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 57, 43);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(24, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 32);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(380, 278);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtRfid);
            Controls.Add(lblRfid);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerRegistrationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RFID Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRfid;
        private TextBox txtRfid;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnCancel;
    }
}
