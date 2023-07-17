namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Regex_Demo regex = new Regex_Demo();
            regex.RegexEx();
            
            
            

            while (true)
            {

                Console.WriteLine("Regex");
                Console.WriteLine("Choose correct  options");
                Console.WriteLine("1:First Name");
                Console.WriteLine("2:Last Name");
                Console.WriteLine("3:Email Validation");
                Console.WriteLine("4:PhoneNumber Validation");
                Console.WriteLine("5:Password Validation");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        regex.CheckPattern("Mahesh");
                        Console.WriteLine("--------------------------");
                        break;
                    case 2:
                        regex.CheckLastName("Kumar");
                        Console.WriteLine("--------------------------");
                        break;
                    case 3:
                        regex.EmailValidation();
                        Console.WriteLine("--------------------------");
                        break;
                    case 4:
                        regex.PhoneNumber("91 9886844497");
                        Console.WriteLine("--------------------------");
                        break;
                    case 5:
                        regex.PasswordValidation();
                        Console.WriteLine("--------------------------");
                        break;


                }
            }
        }
    }
}