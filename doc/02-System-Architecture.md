# 02 - System Architecture

## Architecture Style

The project uses a simple multi-form WinForms architecture.
All forms share data through one static class: `DataStore`.

## Main Parts

1. `MainForm`
2. `LoginForm`
3. `CustomerForm`
4. `AdminForm`
5. `ReceiptForm`
6. `ReadmeForm`
7. `DataStore`
8. Model classes: `Product`, `Transaction`, `TransactionItem`

## How Data Moves

1. `DataStore.Products` holds product stock and prices
2. Customer adds items to cart in `CustomerForm`
3. On purchase, a `Transaction` object is created
4. Transaction is saved to `DataStore.Transactions`
5. Latest transaction is saved to `DataStore.LastTransaction`
6. `MainForm` checks `LastTransaction` and can open `ReceiptForm`
7. `AdminForm` updates stock directly in `DataStore.Products`

## Why This Is Good for Increment 1

1. Easy to understand
2. Easy to demo in class
3. No external setup needed (no DB server yet)
4. Fast for UI-first development

## Why This Will Change in Increment 2

Static in-memory data is not permanent.
For Increment 2, `DataStore` operations will move to MySQL-backed operations.