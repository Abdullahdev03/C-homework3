public class User
    {
    public string Lastname = "Sheralizoda"; 
    public string Firstname = "Abdulloh" ;   
    public string Username1 = "Best";    
    public string Password1 = "best003";   
    public bool IsLoggedOn;
    public  void Login(string username, string password) 
    {
    if(Username1 == username && Password1 == password)
    {
      IsLoggedOn = true;
      System.Console.WriteLine("____________");
      Console.WriteLine(" User logged successfully ");  
    }
    else
    {
      IsLoggedOn = false;
      System.Console.WriteLine("----------");
      Console.WriteLine ( " Your password or username is incorrect ");
    }

    }
    public void FullInfo()
    {
     System.Console.WriteLine($"{Firstname} {Lastname} - {IsLoggedOn}"); 
    }

    }