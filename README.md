# WinForms reservation program
A basic CRUD program for managing reservations and customers. Uses EF Core for all database operations.
Right now, only the management of customers is implemented. That will be changed in the following weeks.


## Usage
Needs '.env' file in root of solution or next to binary.

.env needs to be in format:

```env
DB_CONNECTION_STRING="[connection string of MySql database]"
```

In the future, the program will have the option of selecting database in runtime (custom login screen with choice of MySql or SQLite db)
