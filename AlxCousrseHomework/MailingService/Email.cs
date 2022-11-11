namespace AlxCousrseHomework.MailingService
{
    public class Email
    {
        public string From;
        public string To;
        public string Subject;
        public string Message;

        public Email() { }

        public Email(string form, string to, string subject)
        {
            From = form;
            To = to;
            Subject = subject;
        }
    }
}
