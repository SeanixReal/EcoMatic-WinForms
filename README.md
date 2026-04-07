# ECO-MATIC VENDING MACHINE

## About
Eco-Matic is a Windows Forms vending machine simulator built with C# and .NET.
It features a customer purchase interface, admin inventory management, and receipt generation.

## Increment 1 Scope

This increment focuses on:

1. Project setup
2. UI design
3. Running program demo
4. Basic logic for customer purchase and admin restock

Database integration is not part of Increment 1 yet.
MySQL will be implemented in Increment 2.

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
- **Data Storage**: In-memory using `DataStore` (resets on app close)
- **Architecture**: Multi-form with shared static DataStore class
- **Toolbox Controls**: MenuStrip, ContextMenuStrip, Panel, GroupBox, DataGridView

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
