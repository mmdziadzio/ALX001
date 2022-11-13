namespace ALXCourse.Assignments.M2.L2
{
    public class BookStorageApp
    {
        public static void Run()
        {
            var book001 = new Book("C# Kurs", "Adam Kowalski", "PODRĘCZNIK", 2022);
            var book002 = new Book("Saturn", "Paweł Nowak", "SF", 2022);
            var book003 = new Book("Film", "Tomasz Adamowicz", "FANTASY", 2022);
            var book004 = new Book("Na skraju lasu", "Joahim Pelc", "HORROR", 2022);
            var book005 = new Book("Lektor", "Sebastian Tyszko", "DRAMAT", 2022);
            var book006 = new Book("Powieść o Batmanie", "John Brown", "KOMIKS", 2022);
            var book007 = new Book("Eden", "Stanisław LEM", "SF", 2022);
            var book008 = new Book("Niezwyciężony", "Stanisław Lem Kowalski", "SF", 2022);
            var bookStorageService = new BookStorageService();

            /// create book 9BSS)
            /// clasysify  book (BSSS)
            /// Present Shelves
            /// genre
            /// 

            bookStorageService.ClassifyBooksByGenere(book001);
            bookStorageService.ClassifyBooksByGenere(book002);
            bookStorageService.ClassifyBooksByGenere(book003);
            bookStorageService.ClassifyBooksByGenere(book004);
            bookStorageService.ClassifyBooksByGenere(book005);
            bookStorageService.ClassifyBooksByGenere(book006);
            bookStorageService.ClassifyBooksByGenere(book007);
            bookStorageService.ClassifyBooksByGenere(book008);

            Console.WriteLine("Books SF");
            PresentBook(bookStorageService.BookSF);
            Console.WriteLine();    
            Console.WriteLine("Books Dramat");
            PresentBook(bookStorageService.BookDramat);
            Console.WriteLine();
            Console.WriteLine("Books Podręczniki");
            PresentBook(bookStorageService.BookPodrecznik);
            Console.WriteLine();
            Console.WriteLine("Books komiksy");
            PresentBook(bookStorageService.BookKomiks);
            Console.WriteLine();
            Console.WriteLine("Books Inne");
            PresentBook(bookStorageService.BookInne);
            Console.WriteLine();
        }
        public static void PresentBook(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Book: {book.Title} Author: {book.Author}, Year: {book.Year}, Genre: {book.Genre}, Description: {book.Description}");
            }
        }
    }
}
