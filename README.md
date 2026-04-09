# ECO-MATIC VENDING MACHINE

## About
Eco-Matic is a Windows Forms vending machine simulator built with C# and .NET.
It features a customer purchase interface, admin inventory management, and receipt generation.

## Current Scope

This version now includes:

1. Designer-first WinForms UI (no runtime-generated customer/admin controls)
2. Customer purchase flow with cart and payment validation
3. Examine Item feature with flavor/details text
4. Recycle for Credit feature (Plastic, Glass, Aluminum)
5. Admin inventory tools (restock-to-max, add item, remove item)
6. Event log tools (view and clear log)
7. CSV persistence for inventory and logs

MySQL is still planned for a future increment.

## How to Use

### Customer Mode
1. Click **CUSTOMER** on the home page
2. Click product buttons to add items to your cart
3. Right-click the cart to remove items
4. Insert money using the bill buttons (₱20 – ₱1000)
5. (Optional) Use **EXAMINE** to read item details
6. (Optional) Add balance using **Recycle for Credit**
7. Click **PURCHASE** when your payment covers the total
8. Get your receipt from the home page after purchase

### Admin Mode
1. Click **ADMIN** on the home page
2. Enter password: `admin123`
3. View inventory in the data grid
4. Restock an item directly to max stock
5. Add a new item with type/price/stock/description
6. Remove an existing item
7. View event logs
8. Clear event logs with confirmation

## Product Rules
1. The machine starts with 15 items.
2. Maximum item slots: 30
3. Maximum stock per item: 15
4. All prices are in Philippine Peso (₱).

## Recycle Rates
1. Plastic: ₱1.00 each
2. Glass: ₱2.00 each
3. Aluminum: ₱3.00 each

## Technical Details
- **Framework**: .NET with Windows Forms
- **Language**: C#
- **Data Storage**: CSV files in `bin/Debug/net10.0-windows/data`
- **Architecture**: Multi-form with shared static DataStore class
- **Toolbox Controls**: MenuStrip, ContextMenuStrip, Panel, GroupBox, DataGridView

### CSV Files
1. `inventory.csv` stores current inventory and item metadata
2. `eventLog.csv` stores customer/admin events with UTC timestamps

## Documentation

Complete Increment 1 documents and Mermaid diagrams are in:

- `doc/`

That folder includes:

1. Project overview
2. Architecture and class guide
3. User flow
4. MySQL plan for Increment 2
5. Flowchart, class diagram, and ERD

## Author
© 2026 Seanix
