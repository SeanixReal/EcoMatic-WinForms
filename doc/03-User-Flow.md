# 03 - User Flow

## Customer Flow

1. Open app
2. Click `CUSTOMER`
3. Click product buttons to add items to cart
4. Insert money using bill buttons
5. Click `PURCHASE`
6. System validates payment and stock
7. System saves transaction and updates stock
8. User returns to main menu
9. User can click `EXIT` to view receipt first

## Admin Flow

1. Open app
2. Click `ADMIN`
3. Enter password in `LoginForm`
4. If correct, `AdminForm` opens
5. Admin selects item and quantity
6. Admin clicks `UPDATE STOCK`
7. Stock is updated and grid refreshes

## Validation and Feedback

1. If cart is empty, user gets `Cart Empty` message
2. If inserted money is not enough, user gets `Insufficient payment`
3. If admin does not select an item, a warning message appears
4. Successful purchase and restock show confirmation dialogs

## Navigation Notes

1. Customer and Admin forms return to MainForm
2. Help and ReadMe are available through menu items
3. Receipt appears after purchase when exiting from main menu