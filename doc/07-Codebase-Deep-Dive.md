# Eco-Matic Codebase Deep Dive: A Student's Guide

This document is designed to help you understand your codebase from top to bottom. Since much of this project was AI-generated, it's crucial that you understand **how the pieces fit together** so you can confidently explain the logic, architecture, and flow to your professor.

---

## 1. Architectural Overview

Your application follows a classic **Layered (Multi-Tier) Architecture** commonly used in desktop applications. It separates the code into three main responsibilities:

1.  **Presentation Layer (The UI):** Everything the user sees. This consists of the WinForms (`MainForm`, `CustomerForm`, `AdminForm`, etc.).
2.  **Service/Business Logic Layer:** The "brains" of the operation. This is handled by `DataStore` (which manages the current state of products and users) and `ArduinoService` (which listens to the hardware).
3.  **Data Access/Persistence Layer:** The part that talks to storage. `MySqlStore` handles communication with your MySQL database, while `CsvStorage` handles saving/loading local files (like images or backup data).

---

## 2. Key Files & Classes Explained

Here is a breakdown of the most important files in your project and what they actually do.

### `Program.cs`
- **What it does:** The absolute starting point of your application.
- **Under the hood:** When you hit "Start", Windows runs `Main()`. This method initializes your `DataStore` (setting up the database connection and loading initial inventory) and then opens `MainForm`.

### `MainForm.cs`
- **What it does:** The central hub or "Idle Screen" of the vending machine.
- **Under the hood:** It waits for a user to do something. It also initializes the `ArduinoService` to listen for RFID card scans. When an RFID is scanned, an event fires, and `MainForm` tells the app to open either the `CustomerDashboardForm` (if the user exists) or the `CustomerRegistrationForm` (if it's a new card). It also has a secret way to access the `AdminForm`.

### `DataStore.cs`
- **What it does:** The central manager for all your data.
- **Under the hood:** This uses a **Singleton** or **Facade** pattern. Instead of every form talking to the database directly (which gets messy), forms ask `DataStore` for information. `DataStore` keeps a local list of `Products` and `Transactions` in memory so the app feels fast, and it syncs those lists with the database in the background via `MySqlStore`.

### `Data/MySqlStore.cs` & `Data/MySqlStore_Customers.cs`
- **What it does:** The translator between your C# code and the MySQL database.
- **Under the hood:** It executes raw SQL queries (`SELECT`, `INSERT`, `UPDATE`). 
  - `EnsureDatabaseReady()` creates the tables if they don't exist.
  - `LoadInventory()` and `SaveInventory()` move data between your `DataStore` and the `inventory_items` table.
  - The customers partial class handles reading/writing user accounts, balances, and eco-points.

### `Data/ArduinoService.cs`
- **What it does:** Talks to the physical Arduino hardware.
- **Under the hood:** It uses `System.IO.Ports.SerialPort` to listen to the USB port the Arduino is plugged into. When the Arduino reads an RFID card, it sends a string like `RFID:1234ABCD` over the serial cable. `ArduinoService` reads this string, strips out the extra text, and triggers an `OnCardScanned` event in C#.

### The Forms (`CustomerForm`, `AdminForm`, etc.)
- **`CustomerForm`:** Simulates the actual vending process. Handles the logic for selecting an item, checking if the user has enough money/credits, dispensing the item, and telling `DataStore` to record the sale.
- **`AdminForm`:** A CRUD (Create, Read, Update, Delete) interface that lets the machine owner add stock, change prices, or view logs without touching the database directly.

---

## 3. The Data Flow (How things actually happen)

If your professor asks you to trace a specific action, here is exactly what happens step-by-step:

### Scenario A: The App Starts Up
1. `Program.cs` runs `DataStore.Initialize()`.
2. `DataStore` calls `MySqlStore.EnsureDatabaseReady()` to verify the MySQL server is running and tables exist.
3. `DataStore` fetches the current inventory from MySQL and stores it in memory.
4. `Program.cs` launches `MainForm`.
5. `MainForm` connects to the `ArduinoService` so it can start listening to the Serial Port.

### Scenario B: A User Scans an RFID Card
1. The physical Arduino reads the card and sends `RFID:A1B2C3D4` over the USB cable.
2. `ArduinoService.cs` hears this on the `SerialPort`, extracts `A1B2C3D4`, and fires the `OnCardScanned` event.
3. `MainForm` catches this event and asks `DataStore`: *"Do we have a customer with ID A1B2C3D4?"*
4. `DataStore` checks `MySqlStore`.
   - If **Yes**: It opens `CustomerDashboardForm`.
   - If **No**: It opens `CustomerRegistrationForm`.

### Scenario C: A User Buys a Drink
1. On `CustomerForm`, the user clicks the "Pepsi" button.
2. The form checks the current loaded cash or the user's digital wallet balance.
3. If funds are sufficient, `CustomerForm` tells `DataStore.TrySpendCustomerCredits()` or records a cash sale.
4. `DataStore` reduces the stock of Pepsi by 1.
5. `DataStore` calls `MySqlStore` to `UPDATE` the inventory table and `INSERT` a record into the sales transaction table.
6. The UI updates to show the new stock and prompts a successful purchase message.

---

## 4. Defense Q&A Prep (Anticipating Your Professor's Questions)

Here are common questions professors ask when defending this type of system, and how you should answer them:

**Q: How does your application communicate with the MySQL database?**
> **A:** "It uses the ADO.NET architecture via the `MySql.Data` library (MySQL Connector/NET). We abstracted the database logic into a class called `MySqlStore`. The rest of the application doesn't write SQL queries directly; instead, it calls C# methods on `DataStore`, which in turn uses standard ADO.NET objects like `MySqlConnection` and `MySqlCommand` to execute parameterized SQL commands. This prevents SQL injection and keeps the code clean."

**Q: Why did you separate `DataStore` from `MySqlStore`?**
> **A:** "Separation of Concerns. `MySqlStore` is strictly for database communication. `DataStore` acts as a middleman (a centralized state manager). This means if we ever wanted to switch from MySQL to a different database (like SQLite or just local files), we only have to rewrite `MySqlStore`. The rest of the app (`MainForm`, `CustomerForm`) wouldn't need to change at all because they only talk to `DataStore`."

**Q: How does the software know when an RFID card is tapped?**
> **A:** "We use the `System.IO.Ports.SerialPort` class in `ArduinoService.cs`. The Arduino is programmed to print data to the serial monitor when a card is tapped. Our C# application constantly listens to that specific COM port. When it receives data, it triggers a custom C# Event (`OnCardScanned`), which the UI forms are subscribed to."

**Q: What happens if the database goes down or the connection is lost?**
> **A:** "Currently, `MySqlStore` wraps database calls in `try-catch` blocks. If the connection fails, it catches the `MySqlException`. (You can mention that `CsvStorage` acts as a fallback or that error logs are generated so the app doesn't just crash abruptly)."

**Q: What is the purpose of the `CsvStorage` class if you have a database?**
> **A:** "While MySQL is the primary database for transactions and live inventory, `CsvStorage` handles local file-system tasks. It's used for loading the product images and can serve as a local fallback/seed file to populate the database if we're setting up the machine for the very first time."

**Q: How is the state (like 'who is currently logged in') managed across different forms?**
> **A:** "When a user logs in or scans their card, their data (like their `Customer` object) is either passed directly into the constructor of the next form (e.g., passing the customer ID to `CustomerDashboardForm`), or stored temporarily in `DataStore` as the 'Current User'. This allows the next screen to know exactly who is operating the machine."
