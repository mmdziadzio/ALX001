namespace ALXCourse.Assignments.M2.L2
{
    public class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public string Description;
        public int Year;
        //  5 prpoerty

        public Book() { }

        public Book(string title, string author, string genre, int year)
        {
            Title = title; 
            Author = author;
            Genre = genre;
            Year = year;
        }
    }
}
