string folderPath = @"C:\Users\Lenovo\source\repos\Week9-Lists";
string filename = "shoppingList.txt";
string filePath = Path.Combine(folderPath, filename);
List<string> myShoppingList = new List<string>();

if (File.Exists(filePath))
{
    myShoppingList = getItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {filename} has been created");
    myShoppingList = getItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}

static List<string> getItemsFromUser()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Ad an item (add) / Exit (exit)");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Sisesta toode:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Tsau!");
            break;
        }
    }
    return userList;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"Teie ostukorvis on {listLength} toodet.");

    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}