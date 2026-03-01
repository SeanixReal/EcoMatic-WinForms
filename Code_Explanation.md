# Eco-Matic Vending Machine: Code Logic Explanation

This document explains the logic behind the key components of the Eco-Matic Vending Machine application.

## 1. DataStore.cs (The "Database")
This class acts as the central memory of the application. It is `static`, meaning it stays alive and keeps its data as long as the application is running.
- **Products**: A list that holds all available items, their prices, and current stock. It is initialized in the `static constructor` with 15 default items.
- **Transactions**: A list that records every purchase made.
- **GetReadmePath()**: A helper method that searches for the README file so it can be opened from the menu.

## 2. Product.cs & Transaction.cs (Data Models)
These classes define the structure of the data.
- **Product**: Represents a single item with an ID, Name, Price, and Stock count.
- **Transaction**: Represents a completed purchase, including the total amount, amount paid, change, and a list of bought items (**TransactionItem**).

## 3. CustomerForm.cs (The Buying Interface)
This is the main screen for customers.
- **_cartDictionary**: Tracks what the user wants to buy (Product ID -> Quantity).
- **_insertedMoney**: Tracks how much money the user has "inserted".
- **RefreshProducts()**: Dynamically creates buttons for each product. If stock is 0, it disables the button and shows "SOLD OUT".
- **ProductCard_Click**: Logic for adding items to the cart. It checks if there is enough stock before adding.
- **BtnMoney_Click**: Logic for the money buttons. Adds the face value (e.g., 20, 50, 100) to `_insertedMoney`.
- **btnPurchase_Click**: The core algorithm:
    1. Calculates the total price of items in the cart.
    2. Checks if `_insertedMoney` is greater than or equal to the total.
    3. If valid, it subtracts stock from the `DataStore` for each item.
    4. Creates a new `Transaction` record.
    5. Shows a success message and closes the form.

## 4. AdminForm.cs (Inventory Management)
This screen allows the admin to restock items.
- **OnLoad**: ensures data is loaded only when the form runs (not in the visual designer).
- **RefreshGrid()**: Loads the current inventory from `DataStore` into the table. It highlights items with low stock (<= 2) in red.
- **btnUpdate_Click**: Finds the selected product and adds the specified quantity to its `Stock`.

## 5. MainForm.cs (Authentication & Navigation)
The entry point of the visual application.
- **btnCustomer_Click**: Opens the Customer interface.
- **btnAdmin_Click**: Uses `LoginForm` to securely check the password. If correct (`"admin123"`), it opens the Admin interface.
- **btnExit_Click**: If a purchase was just made, it shows the **ReceiptForm** before closing the application.

## 6. ReceiptForm.cs (Print Output)
Displays the details of the last transaction.
- **PopulateReceipt()**: Loops through the items in the transaction and creates labels to display name, quantity, and price. It also shows the final math (Total, Paid, Change).

## 7. LoginForm.cs (Admin Security)
A dedicated window for entering the admin password.
- **Password Property**: Allows `MainForm` to retrieve what the user typed.
- **DialogResult**: Sets result to `OK` only if the user clicks Login, otherwise `Cancel`.

## 8. ReadmeForm.cs (Help Viewer)
A dedicated window for viewing the README.md content.
- **Constructor**: Takes the text content as a parameter and displays it in a read-only text box.
