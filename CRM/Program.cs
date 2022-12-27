using CRM;

internal class Program
{
    private static void Main(string[] args)
    {
        var users = new List<User>();


        Console.WriteLine("Welcome to the C# CRM :) \n");

        Console.WriteLine("Please choose one of the following options: ");
        Console.WriteLine("Add");
        Console.WriteLine("Remove");
        Console.WriteLine("List Users");
      
        

        var newUser = new User();
        
     while(true)
        {

            switch (Console.ReadLine())
            {

                case "Add":
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

                case "Remove":
                    users.Remove(newUser);
                    break;

                case "List Users":
                    foreach (var user in users)
                    {
                        Console.WriteLine("\nUser ID: " + user.Id);
                        Console.WriteLine("User's full name: " + user.FirstName + " " + user.LastName);
                        Console.WriteLine("Age: " + user.Age);
                        Console.WriteLine("Date of birth: " + user.DateOfBirth);
                        Console.WriteLine("Email: " + user.Email);
                    }
                    break;
            }

            Console.WriteLine("Would you like to do any other action? yes/no");
            string yseNo = Console.ReadLine();

            if (yseNo.Equals("yes"))
            {

                Console.WriteLine("Add");
                Console.WriteLine("Remove");
                Console.WriteLine("List Users");
            }
            else
            {
                Console.WriteLine("Thank you see you next time ;) ");
            }
        }
            

        
        
        Console.ReadKey();

    }  
}