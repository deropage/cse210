using System;

class ExpenseTracker
{
    //Lists to use along the program, keeps track of accounts
    private List<Account> _listOfAccounts = new List<Account>();          // List of accounts
    //Variables to use along the program
    private FileManagement _fileManagement = new FileManagement();        // Variable to manager save and load files
    private List<string>_loadedList = new List<string>();
    private List<string> _divideString = new List<string>();
    private List<string> _conversionList = new List<string>();
    private Profile _userProfile;
    private string _getFromConsole;                                       //Variable to get strings from console
    private int _decisionMenu;                                            //Variable
    private int _counter;
    //Profile Variables
    private string _username;                                           
    private string _address;
    private string _phoneNumber;
    // Account variables adding the suffix "Main" to change from the original variables
    private double _initialBalanceMain;
    private string _accountNumberMain;
    private string _cutOffDateMain;
    private string _accountOwnerMain;
    private string _descriptionMain;
    private string _bankMain;
    private double _interestRateMain;
    private double _monthlyDepositMain;
    private int _periodsPerYearMain;
    private double _totalCreditAmountMain;
    //Temporal Accounts variables, this account types variables helps to create and keep track of new accounts.
    private DebitAccount _myDebitAccount;
    private CreditAccount _myCreditAccount;
    private SavingAccount _mySavingAccount;
    //Movements variables adding the suffix "Main" to change from the original variables
    private double _movementAmountMain;
    private string _movementDateMain;
    private string _movementNameMain;
    private string _movementDescription;
    private string _movementCompanyMain;
    private string _movementOriginMain;
    private int _listIndex;
    //Variables to manage import and export of files
    private string _tempStringToSave;
    private List<string> _tempListString = new List<string>();

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
                    Console.WriteLine("What is the filename, please include .txt at the end");
                    _fileManagement.LoadFile(Console.ReadLine());
                    _loadedList = _fileManagement.GetLoaded();
                    LoadProfile(_loadedList);
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
                    foreach (Account account in _listOfAccounts)
                    {
                        Console.WriteLine("*******************************************");
                        account.AccountSummary();
                        }
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
                            Console.WriteLine("*******************************************");
                            account.AccountSummary();
                            account.GetBalanceSummary();
                            account.GetMovementsSummary();
                        }
                        break;
                        case 2:
                        foreach (Account account in _listOfAccounts)
                        {
                            Console.WriteLine("*******************************************");
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
                    RecordExpense(Get_listOfAccounts());
                    break;

                    case 5:
                    RecordDeposit();
                    break;

                    case 6:
                    SaveFile();
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

    private void LoadProfile(List<string> loadlist)
    {
        _divideString = loadlist[0].Split("*").ToList();
        _userProfile = new Profile(_divideString[0],_divideString[1],_divideString[2]);
        _username = _divideString[0];
        foreach(string line in loadlist)
        {
            _divideString = line.Split("*").ToList();
            if(_divideString[0] == "DebitAccount" || _divideString[0] == "CreditAccount" || _divideString[0] == "SavingAccount")
            {
                switch(_divideString[0])
                {
                    case "DebitAccount":
                    _myDebitAccount = new DebitAccount(double.Parse(_divideString[6]),_divideString[1],_divideString[3],_divideString[5],_divideString[4],_divideString[2]);
                    _myDebitAccount.SetStatus(bool.Parse(_divideString[7]));
                    _listOfAccounts.Add(_myDebitAccount);
                    break;

                    case "CreditAccount":
                    _myCreditAccount = new CreditAccount(double.Parse(_divideString[6]),_divideString[1],_divideString[3],_divideString[5],_divideString[4],_divideString[2],double.Parse(_divideString[8]),double.Parse(_divideString[9]));
                    _myCreditAccount.SetStatus(bool.Parse(_divideString[7]));
                    _listOfAccounts.Add(_myCreditAccount);
                    break;

                    case "SavingAccount":
                    _mySavingAccount = new SavingAccount(double.Parse(_divideString[6]),_divideString[1],_divideString[3],_divideString[5],_divideString[4],_divideString[2],double.Parse(_divideString[8]),double.Parse(_divideString[9]),int.Parse(_divideString[10]));
                    _mySavingAccount.SetStatus(bool.Parse(_divideString[7]));
                    _listOfAccounts.Add(_mySavingAccount);
                    break;
                }
            }
            else if(_divideString[0]== "Expense" || _divideString[0] == "Deposit")
            {
                switch(_divideString[0])
                {
                    case "Expense":
                    _listOfAccounts[int.Parse(_divideString[6])].AddExpense(double.Parse(_divideString[1]),_divideString[2],_divideString[3],_divideString[4],int.Parse(_divideString[6]),_divideString[5]);
                    break;
                    case "Deposit":
                    _listOfAccounts[int.Parse(_divideString[6])].AddDeposit(double.Parse(_divideString[1]),_divideString[2],_divideString[3],_divideString[4],int.Parse(_divideString[6]),_divideString[5]);
                    break;
                }
                
            }
        }
    }

    private void CreateAccount()//Core method to create accounts
    {
        Console.WriteLine("Enter the name of the Bank: ");
        _bankMain = Console.ReadLine();
        Console.WriteLine("Enter the Account Owner Name: ");
        _accountOwnerMain = Console.ReadLine();
        Console.WriteLine("Enter the Account Number: ");
        _accountNumberMain = Console.ReadLine();
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
        Console.WriteLine("Please enter your interest rate: ");
        _getFromConsole = Console.ReadLine();
        _interestRateMain = double.Parse(_getFromConsole);
        Console.WriteLine("Please enter your Total Credit: ");
        _getFromConsole = Console.ReadLine();
        _totalCreditAmountMain = double.Parse(_getFromConsole);
        _myCreditAccount = new CreditAccount(_initialBalanceMain,_accountNumberMain,_cutOffDateMain,_accountOwnerMain,_descriptionMain,_bankMain,_interestRateMain,_totalCreditAmountMain);
        _listOfAccounts.Add(_myCreditAccount);
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
            Console.WriteLine("*******************************************");
            Console.WriteLine($"{_counter}.- ");
            _counter++;
            account.AccountSummary();
        }
    }

    private List<Account> Get_listOfAccounts()
    {
        return _listOfAccounts;
    }

    private void RecordExpense(List<Account> _listOfAccounts)
    {
        Console.WriteLine("From your accounts: ");
        SimpleSummary();
        Console.WriteLine("Please Select your account to process the expense: ");
        _getFromConsole = Console.ReadLine();
        _listIndex = int.Parse(_getFromConsole)-1;
        Console.WriteLine("Enter the information of you Expense");

        Console.WriteLine("Enter the amount of your expense: ");
        _getFromConsole=Console.ReadLine();
        _movementAmountMain = double.Parse(_getFromConsole);
        Console.WriteLine("Enter the date of you expense (MM/DD/YYYY): ");
        _movementDateMain = Console.ReadLine();
        Console.WriteLine("Enter the name of your expense: ");
        _movementNameMain = Console.ReadLine();
        Console.WriteLine("Enter a description of your expense: ");
        _movementDescription = Console.ReadLine();
        Console.WriteLine("Enter where you did the expense: ");
        _movementCompanyMain = Console.ReadLine();
        _listOfAccounts[_listIndex].AddExpense(_movementAmountMain,_movementDateMain,_movementNameMain,_movementDescription,_listIndex,_movementCompanyMain);
    }
    private void RecordDeposit()
    {
        Console.WriteLine("From your accounts: ");
        SimpleSummary();
        Console.WriteLine("Please Select your account to process the deposit: ");
        _getFromConsole = Console.ReadLine();
        _listIndex = int.Parse(_getFromConsole)-1;
        Console.WriteLine("Enter the information of you Deposit");

        Console.WriteLine("Enter the amount of your deposit: ");
        _getFromConsole=Console.ReadLine();
        _movementAmountMain = double.Parse(_getFromConsole);
        Console.WriteLine("Enter the date of you Deposit (MM/DD/YYYY): ");
        _movementDateMain = Console.ReadLine();
        Console.WriteLine("Enter the name of your deposit: ");
        _movementNameMain = Console.ReadLine();
        Console.WriteLine("Enter a description of your deposit: ");
        _movementDescription = Console.ReadLine();
        Console.WriteLine("Enter the origin of your deposit: ");
        _movementOriginMain = Console.ReadLine();
        _listOfAccounts[_listIndex].AddDeposit(_movementAmountMain,_movementDateMain,_movementNameMain,_movementDescription,_listIndex,_movementOriginMain);
    }
    public void SaveFile()
    {
        _conversionList.Clear();
        ConvertData();
        Console.Write("What is the filename for the goal file, include the .txt extension at the end ");
        _fileManagement.SetFileName(Console.ReadLine());
        _fileManagement.SaveFile(_conversionList);
    }
    public void ConvertData()
    {
        _tempStringToSave = _userProfile.GetUsername() + "*" + _userProfile.GetAddress() + "*" + _userProfile.GetPhone();
        _conversionList.Add(_tempStringToSave);
        foreach(Account account in _listOfAccounts)
        {
            _tempListString.Clear();
            account.GenerateSaveString();
            _conversionList.Add(account.GetSaveString());
            _tempListString = account.GetOutputMovements();
            foreach(string movement in _tempListString){_conversionList.Add(movement);}
        }
    }
}