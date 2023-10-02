class Test
{
    public static void Main()
    {

        //Get access to a directory

        string currentDate = "2.10.2023";
        string lastName = "Georgieva";
        string initial = "V";
        string firstName = "Elitza";
        string folderName = $"{lastName}{initial}{firstName}_{currentDate}";
        string path = $@"D:\Programming guysss\{folderName}";

        DirectoryInfo currDir = new DirectoryInfo(path);

        //Create a new directory 

        currDir.Create();
        if (Directory.Exists(path))
        {
            Console.WriteLine("Directory exists!");
            Console.WriteLine($"Folder with name {folderName} is created.");

        }
        else
        {
            Console.WriteLine("It does not exist.");
            Environment.Exit(0);
        }

        //Short If statement for if the directory exists 
        var file = @$"{path}\file.txt";
        if (File.Exists(file))
        {
            Console.WriteLine("Exists");
            
        }
        else
        {
            File.Create(file);
        }

        Console.WriteLine("Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Last Name: ");
        string last = Console.ReadLine();

        Console.WriteLine("Age: ");
        string age = Console.ReadLine();

        Console.WriteLine("Hobbies: ");
        string hobbies = Console.ReadLine();

        Console.WriteLine("Desired Uni: ");
        string uni = Console.ReadLine();

        string[] info = { name, last, age, hobbies, uni };

        File.WriteAllLines(file, info);

    }
}



