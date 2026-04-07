# 01 - Project Overview

## Project Title

Eco-Matic Vending Machine (WinForms)

## Short Description

Eco-Matic is a Windows Forms vending machine simulator made in C#.
It has two main sides:

1. Customer side for buying items
2. Admin side for checking and restocking inventory

## Scope for Increment 1

For Increment 1, the focus is:

1. Project setup
2. UI design
3. Running system demo
4. Basic working logic for buying and restocking
5. Basic documentation and diagrams

## Features Implemented

1. Main menu with Customer, Admin, and Exit options
2. Customer screen with product list and cart
3. Money insertion buttons and purchase computation
4. Receipt display after successful transaction
5. Admin login gate
6. Admin inventory view and restock update
7. ReadMe/help access from menu

## Out of Scope for Increment 1

1. MySQL database
2. Persistent transaction history after closing app
3. Advanced reports and analytics

## Tech Stack

1. C#
2. .NET 10.0 Windows Forms
3. In-memory storage using lists (`DataStore`)

## Current Limitation

Data is only in memory.
When the app closes, all current data resets.
This is acceptable for Increment 1 because database work starts in Increment 2.