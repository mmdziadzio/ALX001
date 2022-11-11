using AlxCousrseHomework.MailingService;

namespace AlxCousrseHomework.MailingService
{
    public class EmailService
    {
        public void SendEmail(Email email)
        {
            Console.WriteLine("The email has been sent");
            Console.WriteLine();
            Console.WriteLine($"From:{email.From}");
            Console.WriteLine($"To :{email.To}");
            Console.WriteLine();
            Console.WriteLine($"Subject :{email.Subject}");
            Console.WriteLine("Message : \n");
            Console.WriteLine($"{email.Message}");
            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine();
        }
    }
}
