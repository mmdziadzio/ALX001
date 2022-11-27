namespace CourseFormApp.Exceptions
{
    public class OuerOwnException : Exception
    {
        public OuerOwnException()
        {
        }
        public OuerOwnException(string? message) : base(message)
        {

        }
        public OuerOwnException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}


