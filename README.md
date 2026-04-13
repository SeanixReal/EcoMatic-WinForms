# ECO-MATIC VENDING MACHINE

## About
Eco-Matic is a Windows Forms vending machine simulator built with C# and .NET.
It features a customer purchase interface, admin inventory management, and receipt generation.

## Current Scope

This version now includes:

1. Designer-first WinForms UI (no runtime-generated customer/admin controls)
2. Customer purchase flow with money + RFID card points (1 point = 1 peso)
3. RFID registration/dashboard flow and points save/spend behavior
4. Recycle for points (Plastic, Glass, Aluminum)
5. Admin inventory tools (restock-to-max, add item, remove item)
6. Event log tools (view and clear log)
7. MySQL persistence for inventory, sales, logs, and customers

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
- **Data Storage**: MySQL
- **Architecture**: Multi-form with shared static DataStore class
- **Toolbox Controls**: MenuStrip, ContextMenuStrip, Panel, GroupBox, DataGridView

## Laptop Setup And Migration

1. Install MySQL and start the server.
2. Open a terminal in this project folder.
3. Set database variables for your laptop.

PowerShell example:

```powershell
$env:ECOMATIC_DB_HOST = "127.0.0.1"
$env:ECOMATIC_DB_PORT = "3306"
$env:ECOMATIC_DB_NAME = "ecomatic_winforms_db"
$env:ECOMATIC_DB_USER = "root"
$env:ECOMATIC_DB_PASSWORD = "your_password"
```

4. Run migration-only startup:

```powershell
dotnet run -- --migrate
```

5. Start the app normally:

```powershell
dotnet run
```

Optional SQL migration file (manual apply):

`migrations/001_initial_schema.sql`

If you prefer one variable instead of five, set:

`ECOMATIC_DB_CONNECTION_STRING`

Example value:

`Server=127.0.0.1;Port=3306;Database=ecomatic_winforms_db;User ID=root;Password=your_password;SslMode=None;`

## Lint/Build/Push Checklist

1. `dotnet format --verify-no-changes`
2. `dotnet build`
3. `git status`
4. `git push --dry-run`

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
