# 03 - User Flow

## Customer Flow

1. Open app
2. Click `CUSTOMER`
3. Click product buttons to add items to cart
4. Insert money using bill buttons
5. Optional: use `EXAMINE` to inspect item details
6. Optional: use `Recycle for Credit` to increase balance
7. Click `PURCHASE`
8. System validates payment and stock
9. System saves transaction and updates stock
10. User returns to main menu
11. User can click `EXIT` to view receipt first

## Admin Flow

1. Open app
2. Click `ADMIN`
3. Enter password in `LoginForm`
4. If correct, `AdminForm` opens
5. Admin can restock selected item to max stock
6. Admin can add a new item
7. Admin can remove an existing item
8. Admin can view event logs
9. Admin can clear event logs with confirmation

## Validation and Feedback

1. If cart is empty, user gets `Cart Empty` message
2. If inserted money is not enough, user gets `Insufficient payment`
3. If admin violates stock/slot rules, a warning appears
4. Successful purchase/admin actions show confirmation dialogs

## Navigation Notes

1. Customer and Admin forms return to MainForm
2. Help and ReadMe are available through menu items
3. Receipt appears after purchase when exiting from main menu
4. Inventory and logs persist through CSV files