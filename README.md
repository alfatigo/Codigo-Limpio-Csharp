## Clean Code Practice

In this practice, we applied clean code principles to a simple C# console application for managing tasks. Below is an overview of the improvements and principles applied:

### Overview

The application provides functionality to:
1. Add tasks
2. Remove tasks
3. List all tasks
4. Exit the application

### Key Improvements and Principles Applied

- **Code Structure**: The code is organized into methods that each have a specific responsibility. Each method is named to clearly indicate its purpose.

- **Error Handling**: Exception handling is used to manage errors gracefully, with clear messages to the user when an operation fails.

- **User Interaction**: The console interface is structured with clear prompts and instructions, improving the user experience.

- **Code Readability**: Consistent formatting and naming conventions are used to make the code more readable. Comments are included to explain method purposes and key code blocks.

- **Separation of Concerns**: Logic for adding, removing, and listing tasks is separated into distinct methods, making the code easier to maintain and extend.

### Code Examples

**Displaying the Main Menu:**

```csharp

static int ShowMainMenu()
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Ingrese la opción a realizar: ");
    Console.WriteLine("1. Nueva tarea");
    Console.WriteLine("2. Remover tarea");
    Console.WriteLine("3. Tareas pendientes");
    Console.WriteLine("4. Salir");

    // Read line
    string line = Console.ReadLine();
    return Convert.ToInt32(line);
}
Adding a Task:


```csharp
static void ShowMenuAdd()
{
    try
    {
        Console.WriteLine("Ingrese el nombre de la tarea: ");
        string task = Console.ReadLine();
        TaskList.Add(task);
        Console.WriteLine("Tarea registrada");
    }
    catch (Exception)
    {
        Console.WriteLine("Error: No se pudo registrar la tarea.");
    }
}
```
## Removing a Task:

```csharp
static void ShowMenuRemove()
{
    try
    {
        Console.WriteLine("Ingrese el número de la tarea a remover: ");
        // Show current tasks
        ShowMenuTaskList();

        Console.WriteLine("----------------------------------------");

        string line = Console.ReadLine();
        // Remove one position
        int indexToRemove = Convert.ToInt32(line) - 1;
        if (indexToRemove > -1 && TaskList.Count > 0)
        {
            string task = TaskList[indexToRemove];
            TaskList.RemoveAt(indexToRemove);
            Console.WriteLine($"Tarea {task} eliminada");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Error: No se puede eliminar la tarea, por favor verifique.");
    }
}
```

## Listing Tasks:

```csharp
static void ShowMenuTaskList()
{
    if (TaskList?.Count > 0)
    {
        Console.WriteLine("----------------------------------------");
        var indexTask = 1;
        TaskList.ForEach(p => Console.WriteLine($"{indexTask++}. {p}"));
        Console.WriteLine("----------------------------------------");
    }
    else
    {
        Console.WriteLine("No hay tareas por realizar");
    }
}
```
This practice demonstrates the application of clean code principles in a C# application, focusing on readability, maintainability, and a user-friendly interface.
