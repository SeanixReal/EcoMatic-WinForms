# Eco-Matic Vending Machine: Code Logic Explanation

This file explains the current code in simple words.

## 1. Program.cs

`Program.cs` is the app entry point.
It starts the WinForms app and opens `MainForm`.

## 2. Data Models

### Product.cs

`Product` stores item information:

1. `Id`
2. `Name`
3. `Price`
4. `Stock`

### Transaction.cs

`TransactionItem` is one item line in a purchase.
`Transaction` is the full purchase record.

`Transaction` contains:

1. Transaction ID and date
2. Purchased item list
3. Total, paid amount, and change

## 3. DataStore.cs

`DataStore` is a static class used as in-memory storage for Increment 1.

It stores:

1. `Products`
2. `Transactions`
3. `NextTransactionId`
4. `LastTransaction`

Important: data resets when the app closes.

## 4. MainForm.cs

`MainForm` is the home screen.

Main actions:

1. Open customer screen
2. Open admin login and admin screen
3. Exit app
4. Show receipt before exit when a transaction exists

## 5. LoginForm.cs

`LoginForm` collects admin password input.
It returns `OK` or `Cancel` using `DialogResult`.

## 6. CustomerForm.cs

`CustomerForm` handles buying flow.

Main logic:

1. Load products as clickable buttons
2. Add selected products to cart
3. Add money using denomination buttons
4. Compute total and change
5. Validate cart and payment
6. Create transaction and reduce stock on successful purchase

## 7. AdminForm.cs

`AdminForm` handles restocking.

Main logic:

1. Show inventory in grid
2. Highlight low stock (<= 2) in red
3. Select item and quantity
4. Update stock and refresh the grid

## 8. ReceiptForm.cs

`ReceiptForm` shows summary of the last purchase.

It displays:

1. Purchased item lines
2. Total amount
3. Paid amount
4. Change

## 9. ReadmeForm.cs

`ReadmeForm` shows built-in usage/help text inside the app.

## 10. Increment 2 Note

For Increment 1, storage is in-memory only.
For Increment 2, MySQL database integration will be implemented.
