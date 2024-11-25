# WinForms reservation program
A basic CRUD program for managing reservations and customers. Uses EF Core for all database operations.

## Features
- Add, edit, view and delete customers and reservations.
- Export data to csv or Excel file
- Show graph with room usage

## Usage
Needs '.env' file in root of solution or next to binary.

.env needs to be in format:

```env
DB_CONNECTION_STRING="[connection string of MySql database]"
```

In the future, the program will have the option of selecting database in runtime (custom login screen with choice of MySql or SQLite db)
