CREATE DATABASE IF NOT EXISTS ecomatic_winforms_db;
USE ecomatic_winforms_db;

CREATE TABLE IF NOT EXISTS schema_migrations (
    migration_id VARCHAR(100) PRIMARY KEY,
    applied_utc DATETIME(6) NOT NULL DEFAULT UTC_TIMESTAMP(6)
);

CREATE TABLE IF NOT EXISTS inventory_items (
    inventory_id INT AUTO_INCREMENT PRIMARY KEY,
    slot_id INT NOT NULL UNIQUE,
    type VARCHAR(20) NOT NULL,
    name VARCHAR(100) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    stock INT NOT NULL DEFAULT 0,
    flavor_text TEXT NOT NULL,
    calories INT NOT NULL DEFAULT 0,
    volume_ml INT NOT NULL DEFAULT 0,
    image_path VARCHAR(255) NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS sales_transactions (
    transaction_id INT AUTO_INCREMENT PRIMARY KEY,
    inventory_id INT NULL,
    slot_id INT NOT NULL,
    item_name VARCHAR(100) NOT NULL,
    quantity INT NOT NULL DEFAULT 1,
    amount_paid DECIMAL(10, 2) NOT NULL,
    transaction_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (inventory_id) REFERENCES inventory_items(inventory_id) ON DELETE SET NULL
);

CREATE TABLE IF NOT EXISTS event_logs (
    log_id INT AUTO_INCREMENT PRIMARY KEY,
    timestamp_utc DATETIME(6) NOT NULL,
    event_type VARCHAR(50) NOT NULL,
    details TEXT NOT NULL,
    amount DECIMAL(10, 2) NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS customers (
    rfid_tag VARCHAR(64) PRIMARY KEY,
    email VARCHAR(120) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    eco_credits INT NOT NULL DEFAULT 0,
    registered_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

INSERT IGNORE INTO schema_migrations (migration_id) VALUES ('001_initial_schema');
