namespace Eco_Matic_Winforms
{
    public partial class CustomerForm : Form
    {
        private readonly List<RecycleEntry> _recycleEntries = new();
        private decimal _insertedMoney = 0;
        private readonly string? _activeRfid;
        private int _cardPointsBalance;

        // Slot lookup
        private readonly record struct SlotControls(Panel Panel, PictureBox PictureBox, Label NameLabel, Label PriceLabel, Button SelectButton);
        private readonly Dictionary<int, SlotControls> _slots = new();

        // Colors
        private static readonly Color SlotDefault  = Color.FromArgb(248, 250, 252);
        private static readonly Color SlotEmpty    = Color.FromArgb(237, 242, 247);
        private static readonly Color BtnReady     = Color.FromArgb(34, 139, 94);
        private static readonly Color BtnDim       = Color.FromArgb(226, 232, 240);
        private static readonly Color CyanGlow     = Color.FromArgb(21, 101, 192);
        private static readonly Color TextWhite    = Color.FromArgb(30, 41, 59);
        private static readonly Color TextDim      = Color.FromArgb(100, 116, 139);
        private static readonly Color BlinkRed     = Color.FromArgb(239, 68, 68);

        // Blink animation state
        private System.Windows.Forms.Timer? _tmrBlink;
        private int _blinkSlotId;
        private int _blinkCount;

        // Dispense animation state
        private System.Windows.Forms.Timer? _tmrDispense;
        private int _dispenseStep;
        private bool _isDispensing;

        private sealed class ProductOption
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public override string ToString() => Name;
        }

        public CustomerForm(string? activeRfid = null)
        {
            InitializeComponent();
            _activeRfid = string.IsNullOrWhiteSpace(activeRfid) ? null : activeRfid;
            LoadCardBalance();
            ApplyLightTheme();
            InitializeSlots();
            InitializeSelectors();
            RefreshProducts();
            UpdateMoneyDisplay();

            this.Size = new Size(1080, 940);
            this.MinimumSize = new Size(900, 860);
            this.WindowState = FormWindowState.Normal;

            // Use native title bar and a normal, centered window.
            pnlTitleBar.Visible = false;

            // Center machine body when form loads
            this.Load += (s, e) => CenterMachineBody();
            this.Resize += (s, e) => CenterMachineBody();
        }

        #region ── Initialization ──

        private void InitializeSlots()
        {
            _slots[1]  = new SlotControls(pnlSlot1,  picSlot1,  lblName1,  lblPrice1,  btnSel1);
            _slots[2]  = new SlotControls(pnlSlot2,  picSlot2,  lblName2,  lblPrice2,  btnSel2);
            _slots[3]  = new SlotControls(pnlSlot3,  picSlot3,  lblName3,  lblPrice3,  btnSel3);
            _slots[4]  = new SlotControls(pnlSlot4,  picSlot4,  lblName4,  lblPrice4,  btnSel4);
            _slots[5]  = new SlotControls(pnlSlot5,  picSlot5,  lblName5,  lblPrice5,  btnSel5);
            _slots[6]  = new SlotControls(pnlSlot6,  picSlot6,  lblName6,  lblPrice6,  btnSel6);
            _slots[7]  = new SlotControls(pnlSlot7,  picSlot7,  lblName7,  lblPrice7,  btnSel7);
            _slots[8]  = new SlotControls(pnlSlot8,  picSlot8,  lblName8,  lblPrice8,  btnSel8);
            _slots[9]  = new SlotControls(pnlSlot9,  picSlot9,  lblName9,  lblPrice9,  btnSel9);
            _slots[10] = new SlotControls(pnlSlot10, picSlot10, lblName10, lblPrice10, btnSel10);
            _slots[11] = new SlotControls(pnlSlot11, picSlot11, lblName11, lblPrice11, btnSel11);
            _slots[12] = new SlotControls(pnlSlot12, picSlot12, lblName12, lblPrice12, btnSel12);

            foreach (var kvp in _slots)
            {
                int slotId = kvp.Key;
                var slot = kvp.Value;
                slot.Panel.Tag = slotId;
                slot.SelectButton.Tag = slotId;
                slot.SelectButton.Click += SelectButton_Click;
            }

            // Tag money buttons
            btnMoney20.Tag = 20;
            btnMoney50.Tag = 50;
            btnMoney100.Tag = 100;
            btnMoney200.Tag = 200;
            btnMoney500.Tag = 500;
            btnMoney1000.Tag = 1000;
        }

        private void InitializeSelectors()
        {
            cboRecycleType.Items.Clear();
            foreach (var material in Enum.GetValues<RecycleMaterial>())
                cboRecycleType.Items.Add(material);
            if (cboRecycleType.Items.Count > 0) cboRecycleType.SelectedIndex = 0;
            nudRecycleQty.Value = 1;
            RefreshExamineOptions();
        }

        private void RefreshExamineOptions()
        {
            var selectedId = (cboExamineItem.SelectedItem as ProductOption)?.Id;
            cboExamineItem.Items.Clear();
            foreach (var p in DataStore.Products.OrderBy(p => p.Id))
                cboExamineItem.Items.Add(new ProductOption { Id = p.Id, Name = p.Name });

            if (selectedId.HasValue)
            {
                var same = cboExamineItem.Items.OfType<ProductOption>().FirstOrDefault(x => x.Id == selectedId.Value);
                if (same != null) { cboExamineItem.SelectedItem = same; return; }
            }
            if (cboExamineItem.Items.Count > 0) cboExamineItem.SelectedIndex = 0;
        }

        private void LoadCardBalance()
        {
            if (string.IsNullOrWhiteSpace(_activeRfid))
            {
                _cardPointsBalance = 0;
                return;
            }

            var info = DataStore.GetCustomerInfo(_activeRfid);
            _cardPointsBalance = Math.Max(0, info.EcoCredits);
        }

        private void CenterMachineBody()
        {
            int x = Math.Max(0, (this.ClientSize.Width - pnlMachineBody.Width) / 2);
            int y = Math.Max(8, (this.ClientSize.Height - pnlMachineBody.Height) / 2);
            pnlMachineBody.Location = new Point(x, y);
        }

        private void ApplyLightTheme()
        {
            BackColor = Color.FromArgb(245, 247, 250);
            pnlMachineBody.BackColor = Color.FromArgb(244, 247, 251);
            pnlHeader.BackColor = Color.FromArgb(226, 232, 240);
            lblBrand.ForeColor = Color.FromArgb(30, 64, 175);
            lblJpn.ForeColor = Color.FromArgb(71, 85, 105);

            pnlCabinet.BackColor = Color.FromArgb(148, 163, 184);
            pnlCabinetInner.BackColor = Color.FromArgb(248, 250, 252);

            pnlControlPanel.BackColor = Color.FromArgb(241, 245, 249);
            pnlMoneyDisplay.BackColor = Color.FromArgb(255, 255, 255);
            lblMoneyLabel.ForeColor = Color.FromArgb(100, 116, 139);
            lblMoneyAmount.ForeColor = Color.FromArgb(21, 128, 61);
            lblMoneyAmount.Font = new Font("Consolas", 16F, FontStyle.Bold);
            lblMoneyTitle.ForeColor = Color.FromArgb(180, 83, 9);

            pnlRecycleArea.BackColor = Color.FromArgb(255, 255, 255);
            pnlExamineArea.BackColor = Color.FromArgb(255, 255, 255);
            cboRecycleType.BackColor = Color.FromArgb(255, 255, 255);
            nudRecycleQty.BackColor = Color.FromArgb(255, 255, 255);
            cboExamineItem.BackColor = Color.FromArgb(255, 255, 255);

            lblRecycleTitle.ForeColor = Color.FromArgb(21, 128, 61);
            lblExamineTitle.ForeColor = Color.FromArgb(30, 64, 175);
            lblRecycleStatus.ForeColor = Color.FromArgb(21, 128, 61);

            btnBack.BackColor = Color.FromArgb(226, 232, 240);
            btnBack.ForeColor = Color.FromArgb(30, 41, 59);
            btnCoinReturn.BackColor = Color.FromArgb(71, 85, 105);

            pnlPickupSlot.BackColor = Color.FromArgb(255, 255, 255);
            picDispense.BackColor = Color.FromArgb(255, 255, 255);
            lblPickup.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooter.ForeColor = Color.FromArgb(100, 116, 139);
        }

        #endregion

        #region ── Product Display ──

        private void RefreshProducts()
        {
            foreach (var kvp in _slots)
            {
                int slotId = kvp.Key;
                var slot = kvp.Value;
                var product = DataStore.Products.FirstOrDefault(p => p.Id == slotId);

                if (product == null)
                {
                    slot.NameLabel.Text = "EMPTY";
                    slot.NameLabel.ForeColor = TextDim;
                    slot.PriceLabel.Text = "";
                    slot.Panel.BackColor = SlotEmpty;
                    slot.SelectButton.Enabled = false;
                    slot.SelectButton.BackColor = BtnDim;
                    slot.SelectButton.ForeColor = Color.FromArgb(60, 60, 80);
                    slot.SelectButton.Text = "—";
                    ClearSlotImage(slot);
                    continue;
                }

                LoadSlotImage(slot, product);

                if (product.Stock > 0)
                {
                    slot.NameLabel.Text = product.Name;
                    slot.NameLabel.ForeColor = TextWhite;
                    slot.PriceLabel.Text = $"₱{product.Price:F2}  ×{product.Stock}";
                    slot.PriceLabel.ForeColor = CyanGlow;
                    slot.Panel.BackColor = SlotDefault;
                    slot.SelectButton.Enabled = true;
                    slot.SelectButton.Text = "SELECT";
                    UpdateButtonBuyability(slot, product);
                }
                else
                {
                    slot.NameLabel.Text = product.Name;
                    slot.NameLabel.ForeColor = TextDim;
                    slot.PriceLabel.Text = "SOLD OUT";
                    slot.PriceLabel.ForeColor = Color.FromArgb(192, 57, 43);
                    slot.Panel.BackColor = SlotEmpty;
                    slot.SelectButton.Enabled = false;
                    slot.SelectButton.BackColor = Color.FromArgb(80, 30, 30);
                    slot.SelectButton.ForeColor = Color.FromArgb(180, 80, 80);
                    slot.SelectButton.Text = "SOLD";
                }
            }
            RefreshExamineOptions();
        }

        private void UpdateAllButtonStates()
        {
            foreach (var kvp in _slots)
            {
                var product = DataStore.Products.FirstOrDefault(p => p.Id == kvp.Key);
                if (product != null && product.Stock > 0)
                    UpdateButtonBuyability(kvp.Value, product);
            }
        }

        private void UpdateButtonBuyability(SlotControls slot, Product product)
        {
            if (GetTotalPurchasingPower() >= product.Price)
            {
                slot.SelectButton.BackColor = BtnReady;
                slot.SelectButton.ForeColor = Color.White;
                slot.SelectButton.FlatAppearance.BorderColor = Color.FromArgb(0, 200, 100);
            }
            else
            {
                slot.SelectButton.BackColor = BtnDim;
                slot.SelectButton.ForeColor = Color.FromArgb(140, 150, 170);
                slot.SelectButton.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 80);
            }
        }

        private decimal GetSpendableCardPeso(decimal price)
        {
            if (_cardPointsBalance <= 0)
            {
                return 0m;
            }

            // Card points are whole-peso units and can only cover whole-peso portions of a price.
            decimal usableCardPeso = Math.Min(Math.Floor(price), _cardPointsBalance);
            decimal cashNeeded = price - usableCardPeso;
            return _insertedMoney >= cashNeeded ? usableCardPeso : 0m;
        }

        private decimal GetTotalPurchasingPower()
        {
            return _insertedMoney + _cardPointsBalance;
        }

        private static void LoadSlotImage(SlotControls slot, Product product)
        {
            ClearSlotImage(slot);
            string fullPath = CsvStorage.GetImageFullPath(product.ImagePath, product.Name);
            if (!File.Exists(fullPath)) return;
            try
            {
                using var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                slot.PictureBox.Image = Image.FromStream(stream);
            }
            catch { /* ignore bad images */ }
        }

        private static void ClearSlotImage(SlotControls slot)
        {
            if (slot.PictureBox.Image != null)
            {
                slot.PictureBox.Image.Dispose();
                slot.PictureBox.Image = null;
            }
        }

        #endregion

        #region ── Select Button (Dispense) ──

        private void SelectButton_Click(object? sender, EventArgs e)
        {
            if (_isDispensing) return;
            if (sender is not Button btn || btn.Tag is not int slotId) return;

            var product = DataStore.Products.FirstOrDefault(p => p.Id == slotId);
            if (product == null || product.Stock <= 0) return;

            decimal cardUsed = GetSpendableCardPeso(product.Price);
            decimal cashNeeded = product.Price - cardUsed;

            if (_insertedMoney < cashNeeded)
            {
                StartBlink(slotId);
                return;
            }

            if (cardUsed > 0m)
            {
                int pointsToSpend = (int)cardUsed;
                if (string.IsNullOrWhiteSpace(_activeRfid) || !DataStore.TrySpendCustomerCredits(_activeRfid, pointsToSpend))
                {
                    LoadCardBalance();
                    UpdateMoneyDisplay();
                    UpdateAllButtonStates();
                    MessageBox.Show("Card points were updated elsewhere. Please try again.",
                        "RFID Balance Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _cardPointsBalance -= pointsToSpend;
                DataStore.LogEvent("RFID_POINTS_SPENT", $"{pointsToSpend} points used for {product.Name} ({_activeRfid})", pointsToSpend);
            }

            // == Dispense the item ==
            _insertedMoney -= cashNeeded;
            product.Stock--;
            DataStore.SaveInventory();

            // Log transaction
            var transaction = new Transaction
            {
                Id = DataStore.NextTransactionId++,
                Date = DateTime.Now,
                TotalAmount = product.Price,
                AmountPaid = product.Price,
                Change = 0
            };
            transaction.Items.Add(new TransactionItem
            {
                ProductId = product.Id,
                ProductName = product.Name,
                Quantity = 1,
                UnitPrice = product.Price
            });
            foreach (var re in _recycleEntries)
                transaction.RecycledItems.Add(new RecycleEntry { Material = re.Material, Pieces = re.Pieces, PointsPerPiece = re.PointsPerPiece });

            DataStore.Transactions.Add(transaction);
            DataStore.LastTransaction = transaction;
            DataStore.LogEvent("PURCHASE", $"1x {product.Name} (cash ₱{cashNeeded:F2}, card {cardUsed:F0} pts)", product.Price);
            DataStore.RecordSale(product);

            // Start dispense animation
            StartDispense(product);
            UpdateMoneyDisplay();
            RefreshProducts();
        }

        #endregion

        #region ── Red Blink Animation ──

        private void StartBlink(int slotId)
        {
            if (_tmrBlink != null) { _tmrBlink.Stop(); _tmrBlink.Dispose(); }
            _blinkSlotId = slotId;
            _blinkCount = 0;

            // Flash the money display too
            _tmrBlink = new System.Windows.Forms.Timer { Interval = 120 };
            _tmrBlink.Tick += TmrBlink_Tick;
            _tmrBlink.Start();
        }

        private void TmrBlink_Tick(object? sender, EventArgs e)
        {
            _blinkCount++;
            if (_blinkCount > 6)
            {
                // Stop blinking — restore normal state
                _tmrBlink?.Stop();
                _tmrBlink?.Dispose();
                _tmrBlink = null;

                if (_slots.TryGetValue(_blinkSlotId, out var s))
                    s.Panel.BackColor = SlotDefault;

                    pnlMoneyDisplay.BackColor = Color.FromArgb(255, 255, 255);
                    lblMoneyAmount.ForeColor = Color.FromArgb(21, 128, 61);
                return;
            }

            bool isRed = _blinkCount % 2 == 1;

            if (_slots.TryGetValue(_blinkSlotId, out var slot))
                slot.Panel.BackColor = isRed ? BlinkRed : SlotDefault;

            pnlMoneyDisplay.BackColor = isRed ? Color.FromArgb(254, 226, 226) : Color.FromArgb(255, 255, 255);
            lblMoneyAmount.ForeColor = isRed ? Color.FromArgb(185, 28, 28) : Color.FromArgb(21, 128, 61);
        }

        #endregion

        #region ── Dispense Animation ──

        private void StartDispense(Product product)
        {
            _isDispensing = true;
            _dispenseStep = 0;

            // Load product image into dispense area
            if (picDispense.Image != null) { picDispense.Image.Dispose(); picDispense.Image = null; }

            string fullPath = CsvStorage.GetImageFullPath(product.ImagePath, product.Name);
            if (File.Exists(fullPath))
            {
                try
                {
                    using var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                    picDispense.Image = Image.FromStream(stream);
                }
                catch { }
            }

            lblDispenseText.Text = $"DISPENSING...";
            lblDispenseText.ForeColor = Color.FromArgb(241, 196, 15);
            lblDispenseText.Visible = true;
            picDispense.Visible = true;

            // Initial position — top of pickup area
            picDispense.Location = new Point((pnlPickupSlot.Width - picDispense.Width) / 2, -picDispense.Height);

            if (_tmrDispense != null) { _tmrDispense.Stop(); _tmrDispense.Dispose(); }
            _tmrDispense = new System.Windows.Forms.Timer { Interval = 30 };
            _tmrDispense.Tick += TmrDispense_Tick;
            _tmrDispense.Start();
        }

        private void TmrDispense_Tick(object? sender, EventArgs e)
        {
            _dispenseStep++;

            // Phase 1: slide image down (steps 1–20)
            if (_dispenseStep <= 20)
            {
                int targetY = 28;
                int currentY = picDispense.Location.Y;
                int newY = currentY + (targetY - currentY + 10) / 5 + 2;
                if (newY > targetY) newY = targetY;
                picDispense.Location = new Point(picDispense.Location.X, newY);
                return;
            }

            // Phase 2: show "done" text (step 21)
            if (_dispenseStep == 21)
            {
                lblDispenseText.Text = "Take your item!";
                lblDispenseText.ForeColor = Color.FromArgb(0, 230, 118);
                // Ka-chunk: brief background flash
                pnlPickupSlot.BackColor = Color.FromArgb(220, 252, 231);
                return;
            }

            // Phase 3: hold for 2 seconds (steps 22–88)
            if (_dispenseStep < 88)
            {
                if (_dispenseStep == 25)
                    pnlPickupSlot.BackColor = Color.FromArgb(255, 255, 255); // reset flash
                return;
            }

            // Phase 4: cleanup
            _tmrDispense?.Stop();
            _tmrDispense?.Dispose();
            _tmrDispense = null;

            picDispense.Visible = false;
            lblDispenseText.Visible = false;
            if (picDispense.Image != null) { picDispense.Image.Dispose(); picDispense.Image = null; }
            pnlPickupSlot.BackColor = Color.FromArgb(255, 255, 255);

            _isDispensing = false;
        }

        #endregion

        #region ── Money ──

        private void btnMoney_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && int.TryParse(btn.Tag?.ToString(), out int amount))
            {
                _insertedMoney += amount;
                UpdateMoneyDisplay();
                UpdateAllButtonStates();
            }
        }

        private void btnCoinReturn_Click(object sender, EventArgs e)
        {
            if (_insertedMoney <= 0) return;
            decimal returned = _insertedMoney;
            _insertedMoney = 0;
            _recycleEntries.Clear();
            UpdateMoneyDisplay();
            UpdateAllButtonStates();

            string note = _cardPointsBalance > 0 ? "\nRFID points stay in your card." : string.Empty;
            MessageBox.Show($"₱{returned:F2} returned.\nPlease collect your money.{note}",
                "Coin Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateMoneyDisplay()
        {
            lblMoneyLabel.Text = "CASH / POINTS:";

            if (!string.IsNullOrWhiteSpace(_activeRfid))
            {
                lblMoneyAmount.Text = $"₱{_insertedMoney:F2} | C:{_cardPointsBalance} S:{DataStore.PendingPoints}";
            }
            else
            {
                lblMoneyAmount.Text = $"₱{_insertedMoney:F2} | S:{DataStore.PendingPoints}";
            }
        }

        #endregion

        #region ── Recycle ──

        private void btnRecycle_Click(object sender, EventArgs e)
        {
            if (cboRecycleType.SelectedItem is not RecycleMaterial material) return;
            int pieces = (int)nudRecycleQty.Value;
            if (pieces <= 0) return;

            int rate = DataStore.RecycleRates[material];
            int points = rate * pieces;
            DataStore.PendingPoints += points;

            var existing = _recycleEntries.FirstOrDefault(x => x.Material == material);
            if (existing == null)
                _recycleEntries.Add(new RecycleEntry { Material = material, Pieces = pieces, PointsPerPiece = rate });
            else
                existing.Pieces += pieces;

            DataStore.LogEvent("RECYCLE", $"{pieces} pc(s) {material}", points);
            lblRecycleStatus.Text = $"+{points} PTS";
            UpdateMoneyDisplay();
            UpdateAllButtonStates();
        }

        #endregion

        #region ── Examine ──

        private void btnExamine_Click(object sender, EventArgs e)
        {
            if (cboExamineItem.SelectedItem is not ProductOption option) return;
            var product = DataStore.Products.FirstOrDefault(p => p.Id == option.Id);
            if (product == null) { RefreshProducts(); return; }

            MessageBox.Show(
                $"{product.Name}\nType: {product.Type}\nPrice: ₱{product.Price:F2}\nStock: {product.Stock}\n\n{product.Examine()}",
                "Item Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region ── Title Bar & Navigation ──

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
        private void btnMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void btnBack_Click(object sender, EventArgs e) => this.Close();

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "HOW TO USE:\n\n" +
                "1. Insert money using the bill buttons\n" +
                "2. Green SELECT buttons = you can afford it\n" +
                "3. Press SELECT to dispense the item\n" +
                "4. Red flash = not enough money\n" +
                "5. RFID points can pay items (1 point = 1 peso)\n" +
                "6. Recycle materials for eco-points (optional)\n" +
                "7. Save points by scanning your RFID card on the main screen\n" +
                "8. Press COIN RETURN to get your cash back\n\n" +
                "Items are dispensed one at a time, just like\na real vending machine!",
                "Help — ECO-MATIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // For dragging the title bar (if not maximized)
        private void TitleBar_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState != FormWindowState.Maximized)
            {
                this.Capture = false;
                var msg = Message.Create(this.Handle, 0xA1, (IntPtr)0x2, IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        #endregion
    }
}
