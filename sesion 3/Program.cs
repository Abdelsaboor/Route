namespace sesion_5
{
    internal class Program
    {
        enum Genre
        {
            Fiction,
            NonFiction,
            Science
        };
        class Book
        {
            public Genre Genre { get; set; }
        }
        static void Main(string[] args)
        {
            #region Q1
            Book book = new Book();
            //Console.WriteLine(book.password);// This line will cause a compilation error because 'password' is private and cannot be accessed from outside the 'Book' class.
            #endregion

            #region Q2
            //Console.WriteLine(book.copiesinstock);// This line will work because 'copiesinstock' is internal and can be accessed from within the same assembly.

            #endregion

            #region Q3
            //book.title = "Clean Code";
            //Console.WriteLine(book.title);// This line will work because 'title' is public and can be accessed from anywhere.
            #endregion

            #region Q4

            //Book book = new Book();
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);

            #endregion

            #region Q5
            //Explicit Casting
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            #endregion

            #region Q6
            //int genrenumber = 1;
            //Genre genre = (Genre)genrenumber;
            //Console.WriteLine(genre);
            #endregion

            #region Q7
            //Genre genre = Genre.Fiction;

            //string genreText = genre.ToString();

            //Console.WriteLine(genreText);
            #endregion

            #region Q8
            //string genreText = "Science";
            //Genre parsedGenre = Enum.Parse<Genre>(genreText);
            //Console.WriteLine(parsedGenre);

            #endregion

            #region Q9
            string genreText = "Mystery";
            bool success = Enum.TryParse<Genre>(genreText, out Genre genre);
            if (success)
            {
                Console.WriteLine(genre);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion
        }
    }
}
