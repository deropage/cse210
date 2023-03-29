using System;

class ExpenseTracker
{
    //Lists to use along the program, keeps track of accounts
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
            if(String.IsNullOrEmpty(_username))
            {
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
            }

            if (_decisionMenu != 7)
            {
                // App Menu
                Console.Clear();
                Console.WriteLine($"Hello {_userProfile.GetUsername()}!\nWelcome to your expense tracker!\nMenu Options:\n 1. Create New Account\n 2. List your accounts\n 3. Accounts summary\n 4. Record New Expense \n 5. Record a New Deposit \n 6. Save Data \n 7. Quit\nSelect a choice from the Menu: ");
                _getFromConsole = Console.ReadLine();
                _decisionMenu = int.Parse(_getFromConsole);
                switch(_decisionMenu)
                {
                    case 1:
                    Console.Clear();
                    Console.WriteLine("Account Types\n1.- Debit Account\n2.- Credit Account\n3.- Savings Account\n Please Provide the Type of account you want to register: ");
                    
                    break;

                    case 2:
                    foreach (Account account in _listOfAccounts){account.AccountSummary();}
                    Console.WriteLine("Press Enter to continue...");
                    _getFromConsole = Console.ReadLine();
                    break;

                    case 3:
                    Console.WriteLine("1. Detailed Summary\n2. Simple Summary");
                    _getFromConsole = Console.ReadLine();
                    _decisionMenu = int.Parse(_getFromConsole);
                    switch (_decisionMenu)
                    {
                        case 1:
                        foreach (Account account in _listOfAccounts)
                        {
                            account.AccountSummary();
                            account.GetBalanceSummary();
                            account.GetMovementsSummary();
                        }
                        break;
                        case 2:
                        foreach (Account account in _listOfAccounts)
                        {
                            account.AccountSummary();
                            account.GetBalanceSummary();
                        }

                        break;
                    }
                    Console.WriteLine("Press Enter to continue...");
                    _getFromConsole = Console.ReadLine();
                    _decisionMenu = 0;
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

    private void CreateAccount()
    {
        
    }
}