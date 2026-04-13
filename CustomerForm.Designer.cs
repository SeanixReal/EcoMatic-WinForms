namespace Eco_Matic_Winforms
{
    partial class CustomerForm
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
            components = new System.ComponentModel.Container();

            // ── Title bar ──
            pnlTitleBar = new Panel();
            lblTitleBar = new Label();
            btnMinimize = new Button();
            btnClose = new Button();

            // ── Machine body ──
            pnlMachineBody = new Panel();

            // ── Header ──
            pnlHeader = new Panel();
            lblBrand = new Label();
            lblJpn = new Label();

            // ── Cabinet ──
            pnlCabinet = new Panel();
            pnlCabinetInner = new Panel();

            // ── 12 product slots ──
            pnlSlot1  = new Panel(); picSlot1  = new PictureBox(); lblName1  = new Label(); lblPrice1  = new Label(); btnSel1  = new Button();
            pnlSlot2  = new Panel(); picSlot2  = new PictureBox(); lblName2  = new Label(); lblPrice2  = new Label(); btnSel2  = new Button();
            pnlSlot3  = new Panel(); picSlot3  = new PictureBox(); lblName3  = new Label(); lblPrice3  = new Label(); btnSel3  = new Button();
            pnlSlot4  = new Panel(); picSlot4  = new PictureBox(); lblName4  = new Label(); lblPrice4  = new Label(); btnSel4  = new Button();
            pnlSlot5  = new Panel(); picSlot5  = new PictureBox(); lblName5  = new Label(); lblPrice5  = new Label(); btnSel5  = new Button();
            pnlSlot6  = new Panel(); picSlot6  = new PictureBox(); lblName6  = new Label(); lblPrice6  = new Label(); btnSel6  = new Button();
            pnlSlot7  = new Panel(); picSlot7  = new PictureBox(); lblName7  = new Label(); lblPrice7  = new Label(); btnSel7  = new Button();
            pnlSlot8  = new Panel(); picSlot8  = new PictureBox(); lblName8  = new Label(); lblPrice8  = new Label(); btnSel8  = new Button();
            pnlSlot9  = new Panel(); picSlot9  = new PictureBox(); lblName9  = new Label(); lblPrice9  = new Label(); btnSel9  = new Button();
            pnlSlot10 = new Panel(); picSlot10 = new PictureBox(); lblName10 = new Label(); lblPrice10 = new Label(); btnSel10 = new Button();
            pnlSlot11 = new Panel(); picSlot11 = new PictureBox(); lblName11 = new Label(); lblPrice11 = new Label(); btnSel11 = new Button();
            pnlSlot12 = new Panel(); picSlot12 = new PictureBox(); lblName12 = new Label(); lblPrice12 = new Label(); btnSel12 = new Button();

            // ── Control panel ──
            pnlControlPanel = new Panel();
            pnlMoneyDisplay = new Panel();
            lblMoneyLabel = new Label();
            lblMoneyAmount = new Label();
            lblMoneyTitle = new Label();
            moneyFlow = new FlowLayoutPanel();
            btnMoney20 = new Button();
            btnMoney50 = new Button();
            btnMoney100 = new Button();
            btnMoney200 = new Button();
            btnMoney500 = new Button();
            btnMoney1000 = new Button();
            btnCoinReturn = new Button();

            // ── Recycle ──
            pnlRecycleArea = new Panel();
            lblRecycleTitle = new Label();
            cboRecycleType = new ComboBox();
            nudRecycleQty = new NumericUpDown();
            btnRecycle = new Button();
            lblRecycleStatus = new Label();

            // ── Examine ──
            pnlExamineArea = new Panel();
            lblExamineTitle = new Label();
            cboExamineItem = new ComboBox();
            btnExamine = new Button();

            // ── Buttons ──
            btnBack = new Button();
            btnHelp = new Button();

            // ── Pickup slot ──
            pnlPickupSlot = new Panel();
            lblPickup = new Label();
            picDispense = new PictureBox();
            lblDispenseText = new Label();

            // ── Footer ──
            lblFooter = new Label();

            // Suspends
            pnlTitleBar.SuspendLayout();
            pnlMachineBody.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlCabinet.SuspendLayout();
            pnlCabinetInner.SuspendLayout();
            pnlControlPanel.SuspendLayout();
            pnlMoneyDisplay.SuspendLayout();
            moneyFlow.SuspendLayout();
            pnlRecycleArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRecycleQty).BeginInit();
            pnlExamineArea.SuspendLayout();
            pnlPickupSlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDispense).BeginInit();
            for (int i = 0; i < 12; i++)
            {
                var pics = new[] { picSlot1, picSlot2, picSlot3, picSlot4, picSlot5, picSlot6, picSlot7, picSlot8, picSlot9, picSlot10, picSlot11, picSlot12 };
                ((System.ComponentModel.ISupportInitialize)pics[i]).BeginInit();
            }
            SuspendLayout();

            // ════════════════════════════════════════════════
            // pnlTitleBar — custom borderless title bar
            // ════════════════════════════════════════════════
            pnlTitleBar.BackColor = Color.FromArgb(8, 8, 18);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(660, 32);
            pnlTitleBar.Controls.Add(lblTitleBar);
            pnlTitleBar.Controls.Add(btnHelp);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnClose);
            //
            lblTitleBar.AutoSize = false;
            lblTitleBar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitleBar.ForeColor = Color.FromArgb(100, 120, 140);
            lblTitleBar.Location = new Point(12, 0);
            lblTitleBar.Name = "lblTitleBar";
            lblTitleBar.Size = new Size(400, 32);
            lblTitleBar.Text = "ECO-MATIC  ●  エコマティック  自動販売機";
            lblTitleBar.TextAlign = ContentAlignment.MiddleLeft;
            //
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHelp.ForeColor = Color.FromArgb(100, 120, 160);
            btnHelp.BackColor = Color.Transparent;
            btnHelp.Cursor = Cursors.Hand;
            btnHelp.Location = new Point(540, 0);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(32, 32);
            btnHelp.Text = "?";
            btnHelp.Click += btnHelp_Click;
            //
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Font = new Font("Segoe UI", 12F);
            btnMinimize.ForeColor = Color.FromArgb(140, 150, 170);
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Location = new Point(580, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 32);
            btnMinimize.Text = "─";
            btnMinimize.Click += btnMinimize_Click;
            //
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(192, 57, 43);
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(620, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 32);
            btnClose.Text = "✕";
            btnClose.Click += btnClose_Click;

            // ════════════════════════════════════════════════
            // pnlMachineBody
            // ════════════════════════════════════════════════
            pnlMachineBody.BackColor = Color.FromArgb(18, 18, 36);
            pnlMachineBody.Name = "pnlMachineBody";
            pnlMachineBody.Size = new Size(660, 920);
            pnlMachineBody.Controls.Add(pnlHeader);
            pnlMachineBody.Controls.Add(pnlCabinet);
            pnlMachineBody.Controls.Add(pnlControlPanel);
            pnlMachineBody.Controls.Add(pnlPickupSlot);
            pnlMachineBody.Controls.Add(lblFooter);

            // ════════════════════════════════════════════════
            // pnlHeader
            // ════════════════════════════════════════════════
            pnlHeader.BackColor = Color.FromArgb(10, 40, 80);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Controls.Add(lblJpn);
            pnlHeader.Location = new Point(10, 6);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(640, 50);
            //
            lblBrand.Dock = DockStyle.Top;
            lblBrand.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(0, 210, 255);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(640, 28);
            lblBrand.Text = "🌿  ECO-MATIC";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            //
            lblJpn.Dock = DockStyle.Bottom;
            lblJpn.Font = new Font("Segoe UI", 8.25F);
            lblJpn.ForeColor = Color.FromArgb(232, 67, 147);
            lblJpn.Name = "lblJpn";
            lblJpn.Size = new Size(640, 20);
            lblJpn.Text = "エコマティック 自動販売機  ●  Eco Vending Machine";
            lblJpn.TextAlign = ContentAlignment.MiddleCenter;

            // ════════════════════════════════════════════════
            // pnlCabinet — glass display with cyan glow border
            // ════════════════════════════════════════════════
            pnlCabinet.BackColor = Color.FromArgb(0, 160, 210);
            pnlCabinet.Controls.Add(pnlCabinetInner);
            pnlCabinet.Location = new Point(10, 60);
            pnlCabinet.Name = "pnlCabinet";
            pnlCabinet.Padding = new Padding(2);
            pnlCabinet.Size = new Size(640, 468);
            //
            pnlCabinetInner.BackColor = Color.FromArgb(8, 10, 30);
            pnlCabinetInner.Dock = DockStyle.Fill;
            pnlCabinetInner.Name = "pnlCabinetInner";
            pnlCabinetInner.Padding = new Padding(8, 6, 8, 6);

            // ── Slot layout: 4 columns × 3 rows, each slot = image + name + price + button ──
            int slotW = 150;
            int slotH = 144;
            int gapX = 6;
            int gapY = 6;
            int startX = 10;
            int startY = 8;

            ConfigureSlot(pnlSlot1,  picSlot1,  lblName1,  lblPrice1,  btnSel1,  "pnlSlot1",  startX + 0*(slotW+gapX), startY + 0*(slotH+gapY), slotW, slotH);
            ConfigureSlot(pnlSlot2,  picSlot2,  lblName2,  lblPrice2,  btnSel2,  "pnlSlot2",  startX + 1*(slotW+gapX), startY + 0*(slotH+gapY), slotW, slotH);
            ConfigureSlot(pnlSlot3,  picSlot3,  lblName3,  lblPrice3,  btnSel3,  "pnlSlot3",  startX + 2*(slotW+gapX), startY + 0*(slotH+gapY), slotW, slotH);
            ConfigureSlot(pnlSlot4,  picSlot4,  lblName4,  lblPrice4,  btnSel4,  "pnlSlot4",  startX + 3*(slotW+gapX), startY + 0*(slotH+gapY), slotW, slotH);

            ConfigureSlot(pnlSlot5,  picSlot5,  lblName5,  lblPrice5,  btnSel5,  "pnlSlot5",  startX + 0*(slotW+gapX), startY + 1*(slotH+gapY), slotW, slotH);
            ConfigureSlot(pnlSlot6,  picSlot6,  lblName6,  lblPrice6,  btnSel6,  "pnlSlot6",  startX + 1*(slotW+gapX), startY + 1*(slotH+gapY), slotW, slotH);
            ConfigureSlot(pnlSlot7,  picSlot7,  lblName7,  lblPrice7,  btnSel7,  "pnlSlot7",  startX + 2*(slotW+gapX), startY + 1*(slotH+gapY), slotW, slotH);
            ConfigureSlot(pnlSlot8,  picSlot8,  lblName8,  lblPrice8,  btnSel8,  "pnlSlot8",  startX + 3*(slotW+gapX), startY + 1*(slotH+gapY), slotW, slotH);

            ConfigureSlot(pnlSlot9,  picSlot9,  lblName9,  lblPrice9,  btnSel9,  "pnlSlot9",  startX + 0*(slotW+gapX), startY + 2*(slotH+gapY), slotW, slotH);
            ConfigureSlot(pnlSlot10, picSlot10, lblName10, lblPrice10, btnSel10, "pnlSlot10", startX + 1*(slotW+gapX), startY + 2*(slotH+gapY), slotW, slotH);
            ConfigureSlot(pnlSlot11, picSlot11, lblName11, lblPrice11, btnSel11, "pnlSlot11", startX + 2*(slotW+gapX), startY + 2*(slotH+gapY), slotW, slotH);
            ConfigureSlot(pnlSlot12, picSlot12, lblName12, lblPrice12, btnSel12, "pnlSlot12", startX + 3*(slotW+gapX), startY + 2*(slotH+gapY), slotW, slotH);

            pnlCabinetInner.Controls.AddRange(new Control[] {
                pnlSlot1, pnlSlot2, pnlSlot3, pnlSlot4,
                pnlSlot5, pnlSlot6, pnlSlot7, pnlSlot8,
                pnlSlot9, pnlSlot10, pnlSlot11, pnlSlot12 });

            // ════════════════════════════════════════════════
            // pnlControlPanel
            // ════════════════════════════════════════════════
            pnlControlPanel.BackColor = Color.FromArgb(24, 24, 44);
            pnlControlPanel.Location = new Point(10, 534);
            pnlControlPanel.Name = "pnlControlPanel";
            pnlControlPanel.Size = new Size(640, 218);
            pnlControlPanel.Controls.Add(pnlMoneyDisplay);
            pnlControlPanel.Controls.Add(lblMoneyTitle);
            pnlControlPanel.Controls.Add(moneyFlow);
            pnlControlPanel.Controls.Add(btnCoinReturn);
            pnlControlPanel.Controls.Add(pnlRecycleArea);
            pnlControlPanel.Controls.Add(pnlExamineArea);
            pnlControlPanel.Controls.Add(btnBack);

            // ── Money display (LED panel) ──
            pnlMoneyDisplay.BackColor = Color.FromArgb(2, 2, 8);
            pnlMoneyDisplay.Location = new Point(12, 8);
            pnlMoneyDisplay.Name = "pnlMoneyDisplay";
            pnlMoneyDisplay.Size = new Size(290, 50);
            pnlMoneyDisplay.Controls.Add(lblMoneyLabel);
            pnlMoneyDisplay.Controls.Add(lblMoneyAmount);
            //
            lblMoneyLabel.Font = new Font("Consolas", 8F);
            lblMoneyLabel.ForeColor = Color.FromArgb(60, 80, 60);
            lblMoneyLabel.Location = new Point(8, 4);
            lblMoneyLabel.Name = "lblMoneyLabel";
            lblMoneyLabel.Size = new Size(100, 15);
            lblMoneyLabel.Text = "INSERTED:";
            //
            lblMoneyAmount.Font = new Font("Consolas", 20F, FontStyle.Bold);
            lblMoneyAmount.ForeColor = Color.FromArgb(0, 230, 100);
            lblMoneyAmount.Location = new Point(4, 16);
            lblMoneyAmount.Name = "lblMoneyAmount";
            lblMoneyAmount.Size = new Size(280, 32);
            lblMoneyAmount.Text = "₱ 0.00";
            lblMoneyAmount.TextAlign = ContentAlignment.MiddleRight;

            // ── Money buttons ──
            lblMoneyTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMoneyTitle.ForeColor = Color.FromArgb(241, 196, 15);
            lblMoneyTitle.Location = new Point(12, 64);
            lblMoneyTitle.Name = "lblMoneyTitle";
            lblMoneyTitle.Size = new Size(200, 16);
            lblMoneyTitle.Text = "💰  INSERT BILLS";
            //
            moneyFlow.Location = new Point(12, 82);
            moneyFlow.Name = "moneyFlow";
            moneyFlow.Size = new Size(420, 36);
            moneyFlow.WrapContents = false;
            moneyFlow.Controls.AddRange(new Control[] { btnMoney20, btnMoney50, btnMoney100, btnMoney200, btnMoney500, btnMoney1000 });

            ConfigureMoneyBtn(btnMoney20,  "₱20",   58);
            ConfigureMoneyBtn(btnMoney50,  "₱50",   58);
            ConfigureMoneyBtn(btnMoney100, "₱100",  58);
            ConfigureMoneyBtn(btnMoney200, "₱200",  58);
            ConfigureMoneyBtn(btnMoney500, "₱500",  58);
            ConfigureMoneyBtn(btnMoney1000,"₱1000", 66);

            // ── Coin return ──
            btnCoinReturn.BackColor = Color.FromArgb(52, 73, 94);
            btnCoinReturn.FlatStyle = FlatStyle.Flat;
            btnCoinReturn.FlatAppearance.BorderSize = 0;
            btnCoinReturn.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            btnCoinReturn.ForeColor = Color.White;
            btnCoinReturn.Cursor = Cursors.Hand;
            btnCoinReturn.Location = new Point(440, 80);
            btnCoinReturn.Name = "btnCoinReturn";
            btnCoinReturn.Size = new Size(188, 38);
            btnCoinReturn.Text = "⬇ COIN RETURN";
            btnCoinReturn.Click += btnCoinReturn_Click;

            // ── Money display position (right side alternative) ──
            pnlMoneyDisplay.Location = new Point(340, 8);
            lblMoneyTitle.Location = new Point(12, 62);

            // ── Recycle area ──
            pnlRecycleArea.BackColor = Color.FromArgb(18, 18, 38);
            pnlRecycleArea.Location = new Point(12, 8);
            pnlRecycleArea.Name = "pnlRecycleArea";
            pnlRecycleArea.Size = new Size(316, 50);
            pnlRecycleArea.Controls.Add(lblRecycleTitle);
            pnlRecycleArea.Controls.Add(cboRecycleType);
            pnlRecycleArea.Controls.Add(nudRecycleQty);
            pnlRecycleArea.Controls.Add(btnRecycle);
            pnlRecycleArea.Controls.Add(lblRecycleStatus);
            //
            lblRecycleTitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblRecycleTitle.ForeColor = Color.FromArgb(39, 174, 96);
            lblRecycleTitle.Location = new Point(6, 3);
            lblRecycleTitle.Name = "lblRecycleTitle";
            lblRecycleTitle.Size = new Size(200, 14);
            lblRecycleTitle.Text = "♻ RECYCLE FOR POINTS";
            //
            cboRecycleType.BackColor = Color.FromArgb(14, 14, 32);
            cboRecycleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRecycleType.FlatStyle = FlatStyle.Flat;
            cboRecycleType.Font = new Font("Segoe UI", 8F);
            cboRecycleType.ForeColor = Color.FromArgb(200, 220, 240);
            cboRecycleType.Location = new Point(6, 20);
            cboRecycleType.Name = "cboRecycleType";
            cboRecycleType.Size = new Size(82, 21);
            //
            nudRecycleQty.BackColor = Color.FromArgb(14, 14, 32);
            nudRecycleQty.DecimalPlaces = 0;
            nudRecycleQty.Font = new Font("Segoe UI", 8F);
            nudRecycleQty.ForeColor = Color.FromArgb(200, 220, 240);
            nudRecycleQty.Increment = 1;
            nudRecycleQty.Location = new Point(94, 20);
            nudRecycleQty.Maximum = 500;
            nudRecycleQty.Minimum = 1;
            nudRecycleQty.Name = "nudRecycleQty";
            nudRecycleQty.Size = new Size(50, 22);
            nudRecycleQty.Value = 1;
            //
            btnRecycle.BackColor = Color.FromArgb(39, 174, 96);
            btnRecycle.FlatStyle = FlatStyle.Flat;
            btnRecycle.FlatAppearance.BorderSize = 0;
            btnRecycle.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnRecycle.ForeColor = Color.White;
            btnRecycle.Cursor = Cursors.Hand;
            btnRecycle.Location = new Point(150, 19);
            btnRecycle.Name = "btnRecycle";
            btnRecycle.Size = new Size(70, 24);
            btnRecycle.Text = "ADD";
            btnRecycle.Click += btnRecycle_Click;
            //
            lblRecycleStatus.Font = new Font("Segoe UI", 7F);
            lblRecycleStatus.ForeColor = Color.FromArgb(0, 230, 118);
            lblRecycleStatus.Location = new Point(226, 22);
            lblRecycleStatus.Name = "lblRecycleStatus";
            lblRecycleStatus.Size = new Size(86, 18);

            // ── Examine area ──
            pnlExamineArea.BackColor = Color.FromArgb(18, 18, 38);
            pnlExamineArea.Location = new Point(12, 122);
            pnlExamineArea.Name = "pnlExamineArea";
            pnlExamineArea.Size = new Size(316, 42);
            pnlExamineArea.Controls.Add(lblExamineTitle);
            pnlExamineArea.Controls.Add(cboExamineItem);
            pnlExamineArea.Controls.Add(btnExamine);
            //
            lblExamineTitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblExamineTitle.ForeColor = Color.FromArgb(52, 152, 219);
            lblExamineTitle.Location = new Point(6, 3);
            lblExamineTitle.Name = "lblExamineTitle";
            lblExamineTitle.Size = new Size(130, 14);
            lblExamineTitle.Text = "🔍 EXAMINE ITEM";
            //
            cboExamineItem.BackColor = Color.FromArgb(14, 14, 32);
            cboExamineItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExamineItem.FlatStyle = FlatStyle.Flat;
            cboExamineItem.Font = new Font("Segoe UI", 8F);
            cboExamineItem.ForeColor = Color.FromArgb(200, 220, 240);
            cboExamineItem.Location = new Point(6, 18);
            cboExamineItem.Name = "cboExamineItem";
            cboExamineItem.Size = new Size(140, 21);
            //
            btnExamine.BackColor = Color.FromArgb(52, 152, 219);
            btnExamine.FlatStyle = FlatStyle.Flat;
            btnExamine.FlatAppearance.BorderSize = 0;
            btnExamine.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnExamine.ForeColor = Color.White;
            btnExamine.Cursor = Cursors.Hand;
            btnExamine.Location = new Point(152, 17);
            btnExamine.Name = "btnExamine";
            btnExamine.Size = new Size(72, 24);
            btnExamine.Text = "EXAMINE";
            btnExamine.Click += btnExamine_Click;

            // ── Back button ──
            btnBack.BackColor = Color.FromArgb(42, 42, 62);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(180, 190, 210);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(12, 172);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 34);
            btnBack.Text = "◀  BACK";
            btnBack.Click += btnBack_Click;

            // ════════════════════════════════════════════════
            // pnlPickupSlot
            // ════════════════════════════════════════════════
            pnlPickupSlot.BackColor = Color.FromArgb(4, 4, 12);
            pnlPickupSlot.Controls.Add(lblPickup);
            pnlPickupSlot.Controls.Add(picDispense);
            pnlPickupSlot.Controls.Add(lblDispenseText);
            pnlPickupSlot.Location = new Point(10, 758);
            pnlPickupSlot.Name = "pnlPickupSlot";
            pnlPickupSlot.Size = new Size(640, 90);
            //
            lblPickup.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPickup.ForeColor = Color.FromArgb(50, 60, 80);
            lblPickup.Location = new Point(0, 0);
            lblPickup.Name = "lblPickup";
            lblPickup.Size = new Size(640, 20);
            lblPickup.Text = "▼  TAKE YOUR ITEM  ▼";
            lblPickup.TextAlign = ContentAlignment.MiddleCenter;
            //
            picDispense.BackColor = Color.FromArgb(4, 4, 12);
            picDispense.Location = new Point(270, 22);
            picDispense.Name = "picDispense";
            picDispense.Size = new Size(60, 60);
            picDispense.SizeMode = PictureBoxSizeMode.Zoom;
            picDispense.Visible = false;
            //
            lblDispenseText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDispenseText.ForeColor = Color.FromArgb(0, 230, 118);
            lblDispenseText.Location = new Point(0, 2);
            lblDispenseText.Name = "lblDispenseText";
            lblDispenseText.Size = new Size(640, 20);
            lblDispenseText.Text = "";
            lblDispenseText.TextAlign = ContentAlignment.MiddleCenter;
            lblDispenseText.Visible = false;

            // ── Footer ──
            lblFooter.Font = new Font("Segoe UI", 7F);
            lblFooter.ForeColor = Color.FromArgb(40, 50, 65);
            lblFooter.Location = new Point(10, 855);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(640, 18);
            lblFooter.Text = "ECO-MATIC  ●  エコマティック  ●  Recycle ♻ Reward 🌿";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;

            // ════════════════════════════════════════════════
            // CustomerForm
            // ════════════════════════════════════════════════
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 12);
            ClientSize = new Size(660, 920);
            FormBorderStyle = FormBorderStyle.Sizable;
            Controls.Add(pnlMachineBody);
            Controls.Add(pnlTitleBar);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECO-MATIC";

            // Resumes
            pnlTitleBar.ResumeLayout(false);
            for (int i = 0; i < 12; i++)
            {
                var pics = new PictureBox[] { picSlot1, picSlot2, picSlot3, picSlot4, picSlot5, picSlot6, picSlot7, picSlot8, picSlot9, picSlot10, picSlot11, picSlot12 };
                var pnls = new Panel[] { pnlSlot1, pnlSlot2, pnlSlot3, pnlSlot4, pnlSlot5, pnlSlot6, pnlSlot7, pnlSlot8, pnlSlot9, pnlSlot10, pnlSlot11, pnlSlot12 };
                ((System.ComponentModel.ISupportInitialize)pics[i]).EndInit();
                pnls[i].ResumeLayout(false);
            }
            pnlCabinetInner.ResumeLayout(false);
            pnlCabinet.ResumeLayout(false);
            moneyFlow.ResumeLayout(false);
            pnlMoneyDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudRecycleQty).EndInit();
            pnlRecycleArea.ResumeLayout(false);
            pnlExamineArea.ResumeLayout(false);
            pnlControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDispense).EndInit();
            pnlPickupSlot.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlMachineBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        /// <summary>Configures a product slot panel with image, labels, and select button.</summary>
        private void ConfigureSlot(Panel pnl, PictureBox pic, Label lblN, Label lblP, Button btn, string name, int x, int y, int w, int h)
        {
            int imgH = 72;
            int btnH = 26;
            int btnW = 60;

            pnl.BackColor = Color.FromArgb(18, 18, 42);
            pnl.Location = new Point(x, y);
            pnl.Name = name;
            pnl.Size = new Size(w, h);
            pnl.Controls.Add(pic);
            pnl.Controls.Add(lblN);
            pnl.Controls.Add(lblP);
            pnl.Controls.Add(btn);

            pic.BackColor = Color.White;
            pic.Location = new Point(8, 4);
            pic.Name = "pic" + name.Replace("pnlSlot", "Slot");
            pic.Size = new Size(w - 16, imgH);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabStop = false;

            lblN.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblN.ForeColor = Color.FromArgb(220, 230, 245);
            lblN.Location = new Point(2, imgH + 6);
            lblN.Name = "lblName" + name.Replace("pnlSlot", "");
            lblN.Size = new Size(w - 4, 14);
            lblN.TextAlign = ContentAlignment.MiddleCenter;
            lblN.Text = "EMPTY";

            lblP.Font = new Font("Segoe UI", 7F);
            lblP.ForeColor = Color.FromArgb(0, 210, 255);
            lblP.Location = new Point(2, imgH + 20);
            lblP.Name = "lblPrice" + name.Replace("pnlSlot", "");
            lblP.Size = new Size(w - 4, 14);
            lblP.TextAlign = ContentAlignment.MiddleCenter;

            btn.BackColor = Color.FromArgb(36, 36, 60);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 80);
            btn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btn.ForeColor = Color.FromArgb(140, 150, 170);
            btn.Location = new Point((w - btnW) / 2, h - btnH - 4);
            btn.Name = "btnSel" + name.Replace("pnlSlot", "");
            btn.Size = new Size(btnW, btnH);
            btn.Cursor = Cursors.Hand;
            btn.Text = "SELECT";
        }

        /// <summary>Configures a money denomination button.</summary>
        private void ConfigureMoneyBtn(Button btn, string text, int w)
        {
            btn.BackColor = Color.FromArgb(241, 196, 15);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn.ForeColor = Color.FromArgb(30, 30, 30);
            btn.Cursor = Cursors.Hand;
            btn.Margin = new Padding(2);
            btn.Name = "btn" + text.Replace("₱", "Money");
            btn.Size = new Size(w, 30);
            btn.Text = text;
            btn.Click += btnMoney_Click;
        }

        #endregion

        // ── Title bar ──
        private Panel pnlTitleBar;
        private Label lblTitleBar;
        private Button btnMinimize;
        private Button btnClose;

        // ── Machine ──
        private Panel pnlMachineBody;
        private Panel pnlHeader;
        private Label lblBrand;
        private Label lblJpn;
        private Panel pnlCabinet;
        private Panel pnlCabinetInner;

        // ── 12 slots ──
        private Panel pnlSlot1; private PictureBox picSlot1; private Label lblName1; private Label lblPrice1; private Button btnSel1;
        private Panel pnlSlot2; private PictureBox picSlot2; private Label lblName2; private Label lblPrice2; private Button btnSel2;
        private Panel pnlSlot3; private PictureBox picSlot3; private Label lblName3; private Label lblPrice3; private Button btnSel3;
        private Panel pnlSlot4; private PictureBox picSlot4; private Label lblName4; private Label lblPrice4; private Button btnSel4;
        private Panel pnlSlot5; private PictureBox picSlot5; private Label lblName5; private Label lblPrice5; private Button btnSel5;
        private Panel pnlSlot6; private PictureBox picSlot6; private Label lblName6; private Label lblPrice6; private Button btnSel6;
        private Panel pnlSlot7; private PictureBox picSlot7; private Label lblName7; private Label lblPrice7; private Button btnSel7;
        private Panel pnlSlot8; private PictureBox picSlot8; private Label lblName8; private Label lblPrice8; private Button btnSel8;
        private Panel pnlSlot9; private PictureBox picSlot9; private Label lblName9; private Label lblPrice9; private Button btnSel9;
        private Panel pnlSlot10; private PictureBox picSlot10; private Label lblName10; private Label lblPrice10; private Button btnSel10;
        private Panel pnlSlot11; private PictureBox picSlot11; private Label lblName11; private Label lblPrice11; private Button btnSel11;
        private Panel pnlSlot12; private PictureBox picSlot12; private Label lblName12; private Label lblPrice12; private Button btnSel12;

        // ── Control panel ──
        private Panel pnlControlPanel;
        private Panel pnlMoneyDisplay;
        private Label lblMoneyLabel;
        private Label lblMoneyAmount;
        private Label lblMoneyTitle;
        private FlowLayoutPanel moneyFlow;
        private Button btnMoney20;
        private Button btnMoney50;
        private Button btnMoney100;
        private Button btnMoney200;
        private Button btnMoney500;
        private Button btnMoney1000;
        private Button btnCoinReturn;

        // ── Recycle ──
        private Panel pnlRecycleArea;
        private Label lblRecycleTitle;
        private ComboBox cboRecycleType;
        private NumericUpDown nudRecycleQty;
        private Button btnRecycle;
        private Label lblRecycleStatus;

        // ── Examine ──
        private Panel pnlExamineArea;
        private Label lblExamineTitle;
        private ComboBox cboExamineItem;
        private Button btnExamine;

        // ── Actions ──
        private Button btnBack;
        private Button btnHelp;

        // ── Pickup slot ──
        private Panel pnlPickupSlot;
        private Label lblPickup;
        private PictureBox picDispense;
        private Label lblDispenseText;

        // ── Footer ──
        private Label lblFooter;
    }
}
