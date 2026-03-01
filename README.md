# ECO-MATIC VENDING MACHINE

## About
Eco-Matic is a Windows Forms vending machine simulator built with C# and .NET.
It features a customer purchase interface, admin inventory management, and receipt generation.

## How to Use

### Customer Mode
1. Click **CUSTOMER** on the home page
2. Click product buttons to add items to your cart
3. Right-click the cart to remove items
4. Insert money using the bill buttons (₱20 – ₱1000)
5. Click **PURCHASE** when your payment covers the total
6. Get your receipt from the home page after purchase

### Admin Mode
1. Click **ADMIN** on the home page
2. Enter password: `admin123`
3. View current inventory in the data grid
4. Select an item, enter quantity, and click **UPDATE STOCK** to restock

## Products
The machine is stocked with 15 items including snacks, drinks, and essentials.
All prices are in Philippine Peso (₱).

## Technical Details
- **Framework**: .NET with Windows Forms
- **Language**: C#
- **Data Storage**: In-memory (resets on app close)
- **Architecture**: Multi-form with shared static DataStore class
- **Toolbox Controls**: MenuStrip, ContextMenuStrip, Panel, GroupBox, DataGridView

## Author
© 2026 Seanix
