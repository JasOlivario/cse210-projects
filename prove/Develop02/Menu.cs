public class Menu
{
    public string _menuItems = " 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit";

    public void DisplayMenuItems()
    {
        Console.WriteLine(_menuItems);
    }

    public void AskUser()
    {
        Console.Write("What would you like to do?");
    }
}