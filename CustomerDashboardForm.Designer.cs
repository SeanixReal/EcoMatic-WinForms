namespace Eco_Matic_Winforms
{
    partial class CustomerDashboardForm
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
            lblRfidValue = new Label();
            lblEmail = new Label();
            lblEmailValue = new Label();
            lblPoints = new Label();
            lblPointsValue = new Label();
            btnClose = new Button();
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
            lblTitle.Text = "RFID Customer Dashboard";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRfid
            // 
            lblRfid.AutoSize = true;
            lblRfid.ForeColor = Color.FromArgb(100, 116, 139);
            lblRfid.Location = new Point(24, 60);
            lblRfid.Name = "lblRfid";
            lblRfid.Size = new Size(63, 15);
            lblRfid.TabIndex = 1;
            lblRfid.Text = "Card UID:";
            // 
            // lblRfidValue
            // 
            lblRfidValue.AutoSize = true;
            lblRfidValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblRfidValue.Location = new Point(120, 60);
            lblRfidValue.Name = "lblRfidValue";
            lblRfidValue.Size = new Size(23, 15);
            lblRfidValue.TabIndex = 2;
            lblRfidValue.Text = "---";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(100, 116, 139);
            lblEmail.Location = new Point(24, 92);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblEmailValue
            // 
            lblEmailValue.AutoSize = true;
            lblEmailValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblEmailValue.Location = new Point(120, 92);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(23, 15);
            lblEmailValue.TabIndex = 4;
            lblEmailValue.Text = "---";
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.ForeColor = Color.FromArgb(100, 116, 139);
            lblPoints.Location = new Point(24, 126);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(70, 15);
            lblPoints.TabIndex = 5;
            lblPoints.Text = "Points:";
            // 
            // lblPointsValue
            // 
            lblPointsValue.AutoSize = true;
            lblPointsValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPointsValue.ForeColor = Color.FromArgb(39, 174, 96);
            lblPointsValue.Location = new Point(120, 116);
            lblPointsValue.Name = "lblPointsValue";
            lblPointsValue.Size = new Size(26, 30);
            lblPointsValue.TabIndex = 6;
            lblPointsValue.Text = "0";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(41, 128, 185);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(24, 168);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(332, 34);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(380, 222);
            Controls.Add(btnClose);
            Controls.Add(lblPointsValue);
            Controls.Add(lblPoints);
            Controls.Add(lblEmailValue);
            Controls.Add(lblEmail);
            Controls.Add(lblRfidValue);
            Controls.Add(lblRfid);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerDashboardForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RFID Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRfid;
        private Label lblRfidValue;
        private Label lblEmail;
        private Label lblEmailValue;
        private Label lblPoints;
        private Label lblPointsValue;
        private Button btnClose;
    }
}
