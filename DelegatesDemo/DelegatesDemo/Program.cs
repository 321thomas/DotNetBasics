using DelegatesDemo;



Console.ReadLine();


static bool CreateBackupFile()
{
    Console.WriteLine("Createing backup...");
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


static void RunTask(string taskType)
{
    var result = false;
    if (taskType == "backup")
    {
        result = CreateBackupFile();
    }
    else if (taskType == "restartSvc")
    {
        result = RestartService();
    }
   
    if (result)
    {
        Console.WriteLine("Success!");
    }
    else
    {
        Console.WriteLine("Failed!");
    }
}



