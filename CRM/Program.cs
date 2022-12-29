using CRM;

internal class Program
{
    private static void Main(string[] args)
    {
                var users = new List<User>();

        Console.WriteLine("Welcome to the C# CRM :) \n");
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();

        bool quitProgram = false;
        while (quitProgram == false)
        {
            var newUser = new User();

            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("Add");
            Console.WriteLine("Remove");
            Console.WriteLine("List");
            Console.WriteLine("Quit");

            var input = Console.ReadLine();
            input = input?.ToLower();

            switch (input)
            {
                case "add":
                    Console.WriteLine("Great, let's begin\n");
                    Console.WriteLine("Please enter your first name: ");

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
                    break;

                case "remove":
                    users.Remove(newUser);
                    break;

                case "list":
                    foreach (var user in users)
                    {
                        Console.WriteLine("\nUser ID: " + user.Id);
                        Console.WriteLine("User's full name: " + user.FirstName + " " + user.LastName);
                        Console.WriteLine("Age: " + user.Age);
                        Console.WriteLine("Date of birth: " + user.DateOfBirth);
                        Console.WriteLine("Email: " + user.Email);
                    }
                    break;

                case "quit":
                    Console.WriteLine("Thank you see you next time ;) ");
                    quitProgram = true;
                    break;
            }
        }

        Console.ReadKey();
    }  
}
