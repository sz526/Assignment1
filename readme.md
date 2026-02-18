Et program som sjekker hvor mange produkter en butikk har av en vare, og skriver ut hvor mye rabatt varen skal få basert på beholdningen.
# Assignment 1: Inventory Discount System

## 1. Planning (Pseudocode)
1. Display a welcome message to the user.
2. Prompt the user to enter the stock quantity of a product.
3. Read the user input and attempt to convert it to an integer.
4. **IF** the input is not a number:
    - Display an error message.
5. **ELSE IF** stock >= 100:
    - Set discount to 50%.
6. **ELSE IF** stock >= 50:
    - Set discount to 30%.
7. **ELSE IF** stock >= 10:
    - Set discount to 10%.
8. **ELSE** (stock < 10):
    - Set discount to 0%.
9. Output the stock status and the calculated discount percentage to the terminal.

## 2. Test Values and Results
To ensure the program logic works correctly, I tested the following scenarios:

| Test Input | Expected Outcome | Logic Path Tested |
| :--- | :--- | :--- |
| `150` | 50% Discount | `if (stock >= 100)` |
| `75` | 30% Discount | `else if (stock >= 50)` |
| `25` | 10% Discount | `else if (stock >= 10)` |
| `5` | No Discount | `else if (stock >= 0)` |
| `-10` | Error Message | `else` (Negative check) |
| `abc` | Invalid Input | `int.TryParse` Failure |

## 3. How to Run (Local)
Since I am working in a restricted IT environment, I use the following commands:
1. `dotnet build`
2. `dotnet exec bin/Debug/net8.0/Assignment_1.dll`