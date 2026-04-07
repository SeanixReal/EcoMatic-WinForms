# 04 - Class Guide

This file explains each class in simple terms.

## Program

- File: `Program.cs`
- Purpose: app entry point
- Action: starts `MainForm`

## MainForm

- Purpose: home screen and navigation hub
- Main tasks:
1. Open customer screen
2. Open login then admin screen
3. Handle app exit and optional receipt viewing

## LoginForm

- Purpose: get admin password input
- Main tasks:
1. Return `OK` when login button is clicked
2. Return `Cancel` when cancel is clicked

## CustomerForm

- Purpose: buying interface
- Main tasks:
1. Show available products
2. Add/remove items in cart
3. Accept money input
4. Validate payment
5. Create and save transaction

## AdminForm

- Purpose: inventory management
- Main tasks:
1. Show stock in grid
2. Select item and quantity
3. Restock item

## ReceiptForm

- Purpose: show transaction summary
- Main tasks:
1. Show purchased items
2. Show total, paid amount, and change

## ReadmeForm

- Purpose: show built-in help/readme text

## Product

- Purpose: model for item data
- Fields:
1. `Id`
2. `Name`
3. `Price`
4. `Stock`

## TransactionItem

- Purpose: model for one line in a transaction
- Fields:
1. `ProductId`
2. `ProductName`
3. `Quantity`
4. `UnitPrice`
5. `LineTotal` (computed)

## Transaction

- Purpose: model for one purchase record
- Fields:
1. `Id`
2. `Date`
3. `Items`
4. `TotalAmount`
5. `AmountPaid`
6. `Change`

## DataStore

- Purpose: shared in-memory storage for Increment 1
- Holds:
1. `Products`
2. `Transactions`
3. `NextTransactionId`
4. `LastTransaction`