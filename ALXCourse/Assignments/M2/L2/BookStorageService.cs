using ALXCourse.Assignments.M2.L1;
using System.Diagnostics;

namespace ALXCourse.Assignments.M2.L2
{
    public class BookStorageService
    {

        public List<Book> BookSF;
        public List<Book> BookDramat;
        public List<Book> BookKomiks;
        public List<Book> BookPodrecznik;
        public List<Book> BookInne;

        public BookStorageService()
        {
            BookSF = new List<Book>();
            BookDramat = new List<Book>();
            BookKomiks = new List<Book>();
            BookPodrecznik = new List<Book>();
            BookInne = new List<Book>();
        }

        //      Listy odpowieadające półką      shelves   5 półek

        public void ClassifyBooksByGenere(Book books)
        {
            switch (books.Genre)
            {
                case "SF":
                    BookSF.Add(books);
                    break;
                case "DRAMATH":
                    BookDramat.Add(books);
                    break;
                case "KOMIKS":
                    BookKomiks.Add(books);
                    break;
                case "PODRĘCZNIK":
                    BookPodrecznik.Add(books);
                    break;
                default:
                    BookInne.Add(books);
                    break;
            }
        }
    }

    public enum Shelves
    {
        PIERWSZA,
        TRZECIA
    }
}
