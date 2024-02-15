## Single Responsibility Principle (SRP)

The Single Responsibility Principle (SRP) states that a class should have only one reason to change, meaning that a class should have only one responsibility or job. This principle promotes a clear and focused design by ensuring that each class is responsible for a single aspect of the application's functionality.

### How to Apply SRP in C#:

1. **Identify Responsibilities**: Begin by identifying the responsibilities of your classes. Each responsibility should encapsulate a single reason to change.

2. **Separate Concerns**: Ensure that each class is focused on performing one responsibility. If a class has multiple responsibilities, consider refactoring it into smaller, more focused classes.

3. **Encapsulate Behavior**: Encapsulate behavior related to a specific responsibility within the appropriate class. This helps to maintain a clean and understandable codebase.

4. **Follow the Single Responsibility Principle**: Continuously evaluate your classes to ensure they adhere to the SRP. If a class becomes responsible for multiple tasks, refactor it to conform to the principle.

### Example:

```csharp
// Incorrect Example: A class responsible for both logging and performing calculations
public class Calculator
{
    public int Add(int a, int b)
    {
        int result = a + b;
        Logger.Log($"Added {a} and {b} to get {result}");
        return result;
    }
}

// Correct Example: Separate classes for logging and performing calculations
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class Logger
{
    public static void Log(string message)
    {
        Console.WriteLine(message);
    }
}
```

In the correct example, the `Calculator` class is responsible only for performing calculations, while the `Logger` class handles logging. This separation of concerns adheres to the Single Responsibility Principle.
