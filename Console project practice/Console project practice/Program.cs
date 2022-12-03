

using Console_project_practice.Controllers;
using Service.Helpers;


LibraryController libraryController = new();

while (true)
{
    ConsoleColor.Yellow.WriteConsole("Select one option:");

    ConsoleColor.Yellow.WriteConsole("Library options: 1-create, 2-get by id, 3- Delete");

    SelectedOption: string option =Console.ReadLine();

    int selectedOption;

    bool isParseOption = int.TryParse(option, out selectedOption);

    if (isParseOption)
    {
        switch (selectedOption)
        {
            case 1:
                libraryController.Create();
                break;
            case 2:
                libraryController.GetById();
                break;
            case 3:
                Console.WriteLine("Delete");
                break;
            default:
                Console.WriteLine("Select again true option");
                goto SelectedOption;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Select again true option:");
        goto SelectedOption;
    }

}