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
    private int _counter;
    //Profile Variables
    private string _username;                                           
    private string _address;
    private string _phoneNumber;
    // Account variables
    private double _initialBalanceMain;
    private int _accountNumberMain;
    private string _cutOffDateMain;
    private string _accountOwnerMain;
    private string _descriptionMain;
    private string _bankMain;
    private double _interestRateMain;
    private double _monthlyDepositMain;
    private int _periodsPerYearMain;
    //Temporal Accounts variables
    private DebitAccount _myDebitAccount;
    private CreditAccount _myCreditAccount;
    private SavingAccount _mySavingAccount;
    //Movementes variables
    private double _expenseAmount;
    private double _depositAmount;


    
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
                Console.WriteLine($"Hello {_userProfile.GetUsername()}!\nWelcome to your expense tracker!\nMenu Options:\n 1. Create New Account\n 2. List your accounts\n 3. Accounts summary\n 4. Record New Expense \n 5. Record New Deposit \n 6. Save Data \n 7. Quit\nSelect a choice from the Menu: ");
                _getFromConsole = Console.ReadLine();
                _decisionMenu = int.Parse(_getFromConsole);
                switch(_decisionMenu)
                {
                    case 1:
                    Console.Clear();
                    Console.WriteLine("Account Types\n1.- Debit Account\n2.- Credit Account\n3.- Savings Account\n Please Provide the Type of account you want to register: ");
                    _getFromConsole = Console.ReadLine();
                    _decisionMenu = int.Parse(_getFromConsole);
                    switch(_decisionMenu)
                    {
                        case 1:
                        CreateDebitAccount();
                        break;

                        case 2:
                        CreateCreditAccount();
                        break;

                        case 3:
                        CreateSavingsAccount();
                        break;

                    }
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
                    RecordExpense();
                    break;

                    case 5:
                    RecordDeposit();
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
    private void CreateAccount()//Core method to create accounts
    {
        Console.WriteLine("Enter the name of the Bank: ");
        _bankMain = Console.ReadLine();
        Console.WriteLine("Enter the Account Owner Name: ");
        _accountOwnerMain = Console.ReadLine();
        Console.WriteLine("Enter the Account Number: ");
        _getFromConsole = Console.ReadLine();
        _accountNumberMain = int.Parse(_getFromConsole);
        Console.WriteLine("Enter the CutOff Day: ");
        _cutOffDateMain = Console.ReadLine();
        Console.WriteLine("Enter a description: ");
        _descriptionMain = Console.ReadLine();
        Console.WriteLine("Please enter your initial Balance: ");
        _getFromConsole = Console.ReadLine();
        _initialBalanceMain = double.Parse(_getFromConsole);
    }

    private void CreateDebitAccount()//Create a new Debit Account
    {
        CreateAccount();
        _myDebitAccount = new DebitAccount(_initialBalanceMain,_accountNumberMain,_cutOffDateMain,_accountOwnerMain,_descriptionMain,_bankMain);
        _listOfAccounts.Add(_myDebitAccount);
    }
    private void CreateCreditAccount()//Create a new Credit account
    {
        CreateAccount();
    }
    private void CreateSavingsAccount()//Create a new Savings account
    {
        CreateAccount();
        Console.WriteLine("Please enter your interest rate: ");
        _getFromConsole = Console.ReadLine();
        _interestRateMain = double.Parse(_getFromConsole);
        Console.WriteLine("Please enter your Monthly Payments: ");
        _getFromConsole = Console.ReadLine();
        _monthlyDepositMain = double.Parse(_getFromConsole);
        Console.WriteLine("Please enter your periods per year: ");
        _getFromConsole = Console.ReadLine();
        _periodsPerYearMain = int.Parse(_getFromConsole);
        _mySavingAccount = new SavingAccount(_initialBalanceMain,_accountNumberMain,_cutOffDateMain,_accountOwnerMain,_descriptionMain,_bankMain,_interestRateMain,_monthlyDepositMain,_periodsPerYearMain);
        _listOfAccounts.Add(_mySavingAccount); 
    }
    private void SimpleSummary()
    {
        _counter = 1;
        foreach(Account account in _listOfAccounts)
        {
            Console.WriteLine($"{_counter}.- ");
            account.AccountSummary();
        }
    }
    private void RecordExpense()
    {
        Console.WriteLine("From your accounts: ");
        SimpleSummary();
        Console.WriteLine("Please Select your account to process the expense: ");
        _getFromConsole = Console.ReadLine();
        _decisionMenu = int.Parse(_getFromConsole);
        Console.WriteLine("Please Select your account to process the expense: ");



    }
    private void RecordDeposit()
    {

    }
}