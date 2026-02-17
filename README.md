# 🥤 Vending Machine Simulator (C# Console)

A robust console application simulating the workflow of a real-world Vending Machine.
This project was built to demonstrate core **Object-Oriented Programming (OOP)** principles and algorithmic logic using C# and .NET.

## 🚀 Features

The application provides a fully interactive command-line interface (CLI) with the following capabilities:

* **Dynamic Inventory Display:** View real-time stock levels, prices, and product IDs.
* **Balance Management:** Users can insert credits and accumulate a balance.
* **Transaction Logic:**
    * Validates product existence (ID checks).
    * Checks for sufficient funds.
    * Ensures stock availability before processing.
* **State Management:** Automatically updates stock and user balance upon successful transaction.
* **Change System:** Calculates and returns the remaining balance to the user.

## 🛠️ Technical Highlights

This project serves as a practical example of my C# skills, specifically focusing on:

* **Object-Oriented Design (OOP):**
    * **Encapsulation:** All `Product` properties use `private set` to prevent external modification. Stock updates are handled exclusively through `DecrementStock()`, enforcing controlled state changes.
    * **Separation of Concerns:** Logic is separated from the UI (`Program.cs` handles inputs, `VendingMachine.cs` handles logic).
* **C# Language Features:**
    * **LINQ:** Used `Inventory.Find(p => ...)` for efficient product lookup.
    * **Collections:** `List<T>` for dynamic inventory management.
    * **Data Types:** Usage of `decimal` for financial precision (avoiding floating-point errors).
    * **Input Validation:** `TryParse` used for all user inputs to handle invalid entries gracefully without exceptions.
* **Control Flow:**
    * Implementation of `switch` cases for menu navigation.
    * `while` loops for continuous application runtime.
    * Input parsing and validation.

## 📂 Project Structure

* `Program.cs`: The entry point. Handles the **User Interface (UI)** and the main event loop.
* `VendingMachine.cs`: The **Logic Layer**. Manages the inventory state, balance, and transaction rules.
* `Product.cs`: The Data Model. Defines the properties of an item (ID, Name, Price, Stock) with encapsulated state management via `DecrementStock()`.

## 🔧 Getting Started

### Prerequisites
* .NET SDK (6.0, 7.0, or 8.0)
* Visual Studio or VS Code

### Installation

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/QuentinREMOND-IUT/VendingMachine.git](https://github.com/QuentinREMOND-IUT/VendingMachine.git)
    ```
2.  **Open the project:**
    Open the `.sln` file in Visual Studio.
3.  **Run:**
    Press `F5` or run `dotnet run` in the terminal.

---
*Created as part of a technical portfolio for a Work-Study (Alternance) application in Software Development.*
