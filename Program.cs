
List<string> TaskList = new List<string>();


int SelectMenu = 0;
do
{
    SelectMenu = ShowMainMenu();
    if ((Menu)SelectMenu == Menu.Add)
    {
        ShowMenuAdd();
    }
    else if ((Menu)SelectMenu == Menu.Remove)
    {
        ShowMenuRemove();
    }
    else if ((Menu)SelectMenu == Menu.List)
    {
        ShowMenuTaskList();
    }
} while ((Menu)SelectMenu != Menu.Exit);

/// <summary>
/// Show the main menu 
/// </summary>
/// <returns>Returns option indicated by user</returns>
int ShowMainMenu()
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

void ShowMenuRemove()
{
    try
    {
        Console.WriteLine("Ingrese el número de la tarea a remover: ");
        // Show current taks
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
        Console.WriteLine($"Error: Can't delete the Task, please verify!");
    }
}

void ShowMenuAdd()
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
    }
}

void ShowMenuTaskList()
{
    if (TaskList?.Count > 0)
    {

        Console.WriteLine("----------------------------------------");
        var indexTask = 1;
        TaskList.ForEach(p => Console.WriteLine($"{indexTask++}.{p}"));
        Console.WriteLine("----------------------------------------");
    }
    else
    {

        Console.WriteLine("No hay tareas por realizar");

    }
}


enum Menu
{
    Add = 1,
    Remove = 2,
    List = 3,
    Exit = 4
}

