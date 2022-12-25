using CRM;

internal class Program
{
    private static void Main(string[] args)
    {
        var users = new List<User>();

        Console.WriteLine("Hello, would you like to create a user? Yes/No\n");
        var yesOrNo = Console.ReadLine();

        if (yesOrNo.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Great, let's begin\n");
            Console.WriteLine("Please enter your first name: ");
            var newUser = new User();
            newUser.Id = Guid.NewGuid();
            newUser.FirstName = Console.ReadLine();
            
            Console.WriteLine("Your last name? ");
            newUser.LastName = Console.ReadLine();

            Console.WriteLine("What is a good email adress? ");
            newUser.Email = Console.ReadLine();

            Console.WriteLine("Age? ");
            newUser.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DOB? ");
            newUser.DateOfBirth = Console.ReadLine();
            users.Add(newUser);

            Console.WriteLine("Would you like to keep the user you created? yes/no");
            var keepOrNot = Console.ReadLine();


            if (keepOrNot.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                users.Add(newUser);
            }
            else
            {
                users.Remove(newUser);
            }

            Console.WriteLine("Would you like to see all users? yes/no");
            var showUsers = Console.ReadLine();

            if (showUsers.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                foreach (var user in users)
                {
                    Console.WriteLine("\nUser ID: " + user.Id);
                    Console.WriteLine("User's full name: " + user.FirstName + " " + user.LastName);
                    Console.WriteLine("Age: " + user.Age);
                    Console.WriteLine("Date of birth: " + user.DateOfBirth);
                    Console.WriteLine("Email: " + user.Email);
                }
            }


        }


        Console.ReadKey();
    }
}