# 01 - Project Overview

## Project Title

Eco-Matic Vending Machine (WinForms)

## Short Description

Eco-Matic is a Windows Forms vending machine simulator made in C#.
It has two main sides:

1. Customer side for buying items
2. Admin side for checking and restocking inventory

## Scope for Current Build

The current build focuses on:

1. Designer-based WinForms interface for customer and admin flows
2. Customer purchase + examine + recycle credit features
3. Admin restock-to-max, add item, remove item, and log tools
4. CSV persistence and event logging
5. Validation constraints for slots and stock

## Features Implemented

1. Main menu with Customer, Admin, and Exit options
2. Customer screen with product list, cart, and static money controls
3. Examine Item and Recycle for Credit actions
4. Money insertion and purchase computation with validation
5. Receipt display after successful transaction
5. Admin login gate
6. Admin inventory view and restock-to-max update
7. Add item and remove item admin actions
8. View and clear event log admin actions
9. ReadMe/help access from menu

## Out of Scope for Current Build

1. MySQL database
2. Advanced reports and analytics

## Tech Stack

1. C#
2. .NET 10.0 Windows Forms
3. CSV persistence through `DataStore` + `CsvStorage`

## Current Limitation

Data is persisted in CSV, not in a relational database.
MySQL migration remains a future increment.