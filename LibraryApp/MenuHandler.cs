class MenuHandler
{
    // const, private, protected, public

    #region printMenu
    private const string MENU_MAIN = @"
Silahkan Pilih Menu:
1. Buat Message
2. Lihat Message
3. Exit
    ";
    
    private const string MENU_MESSAGE = @"
Menu Message:
1. Message Only
2. Approval with Message
3. Approval Message with Files
4. Back to Main Menu
5. Exit
    ";
    #endregion

    #region olahInput
    private string? getInput(string message)
        {
            Console.Write(message);
            string? input = string.Empty;
            input = Console.ReadLine();
            return input;
        }

    private int parseInput(string? input)
    {
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Input tidak valid, silakan masukkan angka.");
            return -1;
        }
    }
    #endregion

    private void showMainMenu()
    {
        while (true)
        {
            Console.WriteLine(MENU_MAIN);
            int pilihan = parseInput(getInput("Masukan Pilihan: "));

            switch (pilihan)
            {
                case 1:
                    showMessageMenu();
                    break;
                case 2:
                    showMessageList();
                    break;
                case 3:
                    Console.WriteLine("Bye :D");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid, silakan coba lagi.\n");
                    break;
            }
        }
    }

    #region MenuBuatMessage
    
    private void showMessageMenu()
    {
        Console.WriteLine(MENU_MESSAGE);
        bool run = true;
        int pilihan = parseInput(getInput("Masukkan pilihan: "));
        
        while (run)
        {
            switch (pilihan)
            {
                case 1:
                    MenuMessageOnly();
                    run = false;
                    break;
                case 2:
                    MenuApprovalMessage();
                    run = false;
                    break;
                case 3:
                    MenuApprovalFiles();
                    run = false;
                    break;
                case 4:
                    run = false;
                    break;
                case 5:
                    Console.WriteLine("Bye :D");
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
    private void MenuMessageOnly()
    {
        Console.WriteLine("Menu Message Only - Silahkan Isi Data Berikut:");
        string pengirim = getInput("Masukan Nama Pengirim: ");
        string penerima = getInput("Masukan Nama Penerima: ");
        string subject = getInput("Masukan Subject: ");
        string message = getInput("Masukan Message: ");
    }
    private void MenuApprovalMessage()
    {
        Console.WriteLine("Menu Approval with Message - Silahkan Isi Data Berikut:");
        string pengirim = getInput("Masukan Nama Pengirim: ");
        string penerima = getInput("Masukan Nama Penerima: ");
        string subject = getInput("Masukan Subject: ");
        string message = getInput("Masukan Message: ");
        string status = getInput("Approve (Y/N): ");
    }
    private void MenuApprovalFiles()
    {
        Console.WriteLine("Menu Approval with Message - Silahkan Isi Data Berikut:");
        string pengirim = getInput("Masukan Nama Pengirim: ");
        string penerima = getInput("Masukan Nama Penerima: ");
        string subject = getInput("Masukan Subject: ");
        string message = getInput("Masukan Message: ");
        // string status = getInput("Approve (Y/N): ");
        string files = getInput("Upload Files: ");
    }
    #endregion

    #region MenuLihatMessage

    private void showMessageList()
    {
        int messageCount = 10;
        Console.WriteLine("Message List:");

        for (int i = 1; i <= messageCount; i++)
        {
            Console.WriteLine($"{i}. Message From: Pengirim {i} | Subject {i}");
        }
    }
#endregion
    
    public void Run()
    {
        showMainMenu();
    }
}