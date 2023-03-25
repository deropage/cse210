using System;

class ExpenseTracker
{
    //Lists to use along the program, keeps track of movements and accounts
    private List<Movement> _listOfMovements = new List<Movement>();       //List of movements
    private List<Account> _listOfAccounts = new List<Account>();          // List of accounts
    //Variables to use along the program
    private FileManagement _fileManagement = new FileManagement();        // Variable to manager save and load files
    private Profile _userProfile;
    private string _getFromConsole;                                       //Variable to get strings from console
    private int _decisionMenu;                                            //Variable
    //Profile Variables
    private string _username;                                           
    private string _address;
    private string _phoneNumber;
    // Account variables
    

    
    public ExpenseTracker() 
    {
        do
        {
            //Initial Menu
            Console.Clear();
            Console.WriteLine($"Hello Welcome to your expense tracker! \n If you are a new user, please select option 1 to create a new profile.\n If you already have a profile select option 2 to load your profile\nMenu Options:\n 1. New Profile\n 2. Load Profile\n 3. Quit");
            _getFromConsole = Console.ReadLine();
            _decisionMenu = int.Parse(_getFromConsole);
            switch(_decisionMenu)
            {
                case 1:
                CreateNewProfile();
                break;

                case 2:
                LoadProfile();
                break;

                case 3:
                _decisionMenu = 7;
                break;
            }
            if (_decisionMenu != 7)
            {
                // App Menu
                Console.Clear();
                Console.WriteLine($"Hello {_userProfile.GetUsername()}!\nWelcome to your expense tracker!\nMenu Options:\n 1. Create New Account\n 2. List your accounts\n 3. Accounts summary\n 4. Save Data \n 5. Record New Expense\n 6. Record a New Deposit\n 7. Quit\nSelect a choice from the Menu: ");
                _getFromConsole = Console.ReadLine();
                _decisionMenu = int.Parse(_getFromConsole);
                switch(_decisionMenu)
                {
                    case 1:
                    break;

                    case 2:
                    break;

                    case 3:
                    break;

                    case 4:
                    break;

                    case 5:
                    break;

                    case 6:
                    break;
                }
            }

        }while (_decisionMenu != 7);
    }
    private void CreateNewProfile()
    {
        
        Console.WriteLine("Please enter you name: ");
        _username = Console.ReadLine();
        Console.WriteLine("Please enter your address: ");
        _address = Console.ReadLine();
        Console.WriteLine("Please enter your phone number: ");
        _phoneNumber = Console.ReadLine();
        _userProfile = new Profile(_username, _address, _phoneNumber);
    }
    private void LoadProfile()
    {

    }
}