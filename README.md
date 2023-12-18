Bank Encapsulation Readme
Overview

This simple console application demonstrates basic bank account functionality using encapsulation in C#. The program allows users to perform actions such as withdrawing money, depositing money, checking their balance, and exiting the program.
Table of Contents

    Usage
    Code Structure
    How to Run
    Contributing
    

Usage <a name="usage"></a>

The program provides a text-based menu for users to interact with their bank account. It utilizes encapsulation by encapsulating the bank account details within the BankAccount class and exposing a limited set of public methods for interacting with the account (Deposit, Withdraw, GetBalance).
Code Structure <a name="code-structure"></a>

The code is divided into two files: Program.cs and BankAccount.cs.
Program.cs

This file contains the main logic of the console application. It includes the menu system, user input handling, and interaction with the BankAccount class.
BankAccount.cs

This file defines the BankAccount class, which encapsulates the user's balance and provides methods for depositing, withdrawing, and retrieving the balance. The balance is kept private, and access is controlled through public methods.
How to Run <a name="how-to-run"></a>

To run the program, follow these steps:

    Ensure you have a C# development environment set up.
    Copy the provided code into two separate files: Program.cs and BankAccount.cs.
    Compile and run the program using your preferred C# compiler or integrated development environment (IDE).

Contributing <a name="contributing"></a>

Contributions to enhance or extend the functionality of this simple bank encapsulation example are welcome. If you find any issues or have ideas for improvement, please open an issue or submit a pull request.
