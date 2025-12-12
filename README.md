# 🧮 C# Recursive Factorial Calculator

A simple C# console application that receives 6 numbers from the user and prints the factorial of each one using a **recursive method**.

## ✨ Features
- Takes 6 integer inputs
- Calculates factorial using a **recursive function**
- Displays clean output in console
- Beginner-friendly and easy to understand

## 📌 How It Works
The program uses a recursive method:

```csharp
static long Factorial(int n)
{
    if (n == 0 || n == 1)
        return 1;

    return n * Factorial(n - 1);
}
```

## 🚀 Run the Project
1. Clone the repository:
```bash
git clone https://github.com/YourUserName/CSharp-Recursive-Factorial-Calculator
```
2. Open the project in Visual Studio or VS Code
3. Build & run
