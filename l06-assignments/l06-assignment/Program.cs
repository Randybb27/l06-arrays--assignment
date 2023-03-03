// See https://aka.ms/new-console-template for more information
//  Console.WriteLine("\nInsert new task\n");


List<string> taskList = new List<string>();
{

    // displayOptions();
    var option = "0";
    while (option != "4")
    {
        Console.WriteLine("Choose your task");
        Console.WriteLine(@"
1. Create a Task
2. View All Task
3. Delete a Task
4. Quit
");

        option = Console.ReadLine();


        // Console.WriteLine("Choose your task");
        // int num1 = 1;

        switch (option)
        {
            case "1":
                createTask();
                break;
            case "2":
                displayTask();
                break;
            case "3":
                deleteTask();
                break;
                case "4":
                    Quit();
                    break;
        }
    }

    void createTask()
    {
        Console.WriteLine("What is the name of the task to create?");
        // string [] tasklist = {""};
        string task = Console.ReadLine();
        // List<string> nameList = new List<string>();
        taskList.Add(task);



    }
    void displayTask()
    {
        for (int i = 0; i < taskList.Count; i++)
        {
            var taskNum = i + 1;
            Console.WriteLine($"{taskNum}. {taskList[i]}");
        }
    }
    void deleteTask()
    {
        Console.WriteLine("Which task would you like to delete?");
        var taskNum = Console.ReadLine();
            taskList.RemoveAt(int.Parse(taskNum)-1);
           

    }
    void Quit()
    {
        Console.WriteLine("Goodbye");
    }
}
