using System;

class Profile
{
    //Main variables for profile
    private string _username;
    private string _address;
    private string _phoneNumber;
    private string _memberSince;
    //Constructors for profile
    public Profile(){}
    public Profile(string name, string address, string phone)
    {
        _username = name;
        _address = address;
        _phoneNumber = phone;
        _memberSince = DateTime.Now.ToString();
    }
    //Getters and Setters
    public string GetUsername(){return _username;}
    public string GetAddress(){return _address;}
    public string GetPhone(){return _phoneNumber;}
    public void SetUsername(string name){_username=name;}
    public void SetAddress(string address){_address=address;}
    public void SetPhone(string phone){_phoneNumber=phone;}
}