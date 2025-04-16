string validUsername = "admin";
string validPassword = "password";

int tries = 3;
while(true)
{
    Console.Write("Enter username: ");
    string userid = Console.ReadLine();
    Console.Write("Enter password: ");
    string password = Console.ReadLine();

    if(validPassword ==  password && validUsername == userid)
    {
        Console.WriteLine("Successful login!");
        break;
    }
    else
    {
        tries--;
        Console.WriteLine("Invalid userid or password");
        Console.WriteLine($"{tries} tries remaining");
        if(tries == 0)
        {
            break;
        }
    }
}
