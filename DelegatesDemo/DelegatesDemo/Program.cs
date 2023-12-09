using DelegatesDemo;


// Create delegate instance
// .NET 1.0
TaskDelegate taskDel1 = new TaskDelegate(CreateBackupFile);

// .NET 2.0
TaskDelegate taskDel2 = CreateBackupFile;

// .NET 3.0
TaskDelegate taskDel3 = () =>
{
    //do something useful here...
    return true;
};

// Call method and pass delegate
RunTask(taskDel1);



var svc = new PersonService();

IEnumerable<Person> result;

StringPredicate stringPredicate = (Person p, string term) =>
{
    return p.FirstName.Contains(term);
};

result = svc.FilterPersonsWithStringPredicate(stringPredicate, "a");

// with generic delegate, can be applied on all properteis of class Person, not just FirstName
svc.FilterPersons(p => p.FirstName.Contains("a"));


// with extension method, similar to .Where in LINQ
// https://github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Where.cs
result = svc.GetAllPersons().MyWhere(p=> p.FirstName.Contains("a"));
PrintResult(result);


Console.ReadLine();

static void PrintResult(IEnumerable<Person> persons)
{
    foreach (var person in persons)
    {
        Console.WriteLine(person.ToString());
    }
}

static bool CreateBackupFile()
{
    Console.WriteLine("Creating backup...");
    Console.WriteLine("Done!");
    return true;
}


static bool RestartService()
{
    Console.WriteLine("Stopping service...");
    Console.WriteLine("Service stopped.");
    Console.WriteLine("Starting service...");
    Console.WriteLine("Service started.");
    return true;
}


static void RunTask(TaskDelegate del)// (string taskType)
{
    var result = false;

    // bad practice if endless if-else

    //if (taskType == "backup")
    //{
    //    result = CreateBackupFile();
    //}
    //else if (taskType == "restartSvc")
    //{
    //    result = RestartService();
    //}

    result = del(); // or del.Invoke();
   
    if (result)
    {
        Console.WriteLine("Success!");
    }
    else
    {
        Console.WriteLine("Failed!");
    }
}

// Demo delegate
delegate bool TaskDelegate();



