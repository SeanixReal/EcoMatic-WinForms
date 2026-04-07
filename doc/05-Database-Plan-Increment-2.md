# 05 - Database Plan (Increment 2)

## Current State (Increment 1)

The app currently uses in-memory lists in `DataStore`.
No CSV and no MySQL are used in this increment.

## Why Database Is Not Yet Implemented

Increment 1 is focused on:

1. Project setup
2. UI design
3. Basic logic demonstration

Adding MySQL now will add setup complexity while we are still validating UI and flow.

## Plan for Next Weeks (Increment 2)

We will implement MySQL for persistence and CRUD operations.

## Planned Changes

1. Create MySQL tables for Product, Transaction, and TransactionItem
2. Replace in-memory list operations with database operations
3. Keep form behavior mostly the same so UI changes are minimal
4. Save transactions permanently
5. Keep inventory state after app close

## AI Note for Future Work

When continuing this project for Increment 2:

1. Keep current UI forms and controls
2. Replace only data access part first
3. Keep method names simple and beginner-friendly
4. Do not over-engineer architecture
5. Prioritize clear code over advanced patterns

## Expected Benefit

1. Real data persistence
2. Better CRUD support
3. Better readiness for Increment 2 checking rubric