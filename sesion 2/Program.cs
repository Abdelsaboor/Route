namespace sesion_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region َQ1 - Object Type
            //Book book = new Book();

            //book.Title = "C# Basics";
            //book.Pages = 300;

            //object obj = book;

            //Console.WriteLine(obj);
            #endregion

            #region Q2 - Object Methods

            //Console.WriteLine(book.ToString());

            //Console.WriteLine(book.Equals(book));

            //Console.WriteLine(book.GetHashCode());

            //Console.WriteLine(book.GetType());

            #endregion


            #region Q3 - Fix Compile-Time Error

            // int pages = "464"; // Compile-Time Error

            //int pages = int.Parse("464");

            //Console.WriteLine(pages);

            #endregion


            #region Q4 - Try Catch Finally

            //try
            //{
            //    int x = 10;
            //    int y = 0;

            //    int result = x / y;

            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion


            #region Q5 - Implicit Casting

            //int pages1 = 300;

            //double pagesDouble = pages1;

            //Console.WriteLine(pagesDouble);

            #endregion


            #region Q6 - Explicit Casting

            //double price = 49.99;

            //int priceInt = (int)price;

            //Console.WriteLine(priceInt);

            #endregion


            #region Q7 - Convert Class

            //string pagesText = "464";

            //int pages2 = Convert.ToInt32(pagesText);

            //Console.WriteLine(pages2);

            #endregion


            #region Q8 - Parse and TryParse

            //string yearText = "2023";

            //int year = int.Parse(yearText);

            //Console.WriteLine(year);

            //string badText = "abc";

            //bool success = int.TryParse(badText, out int number);

            //if (success)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion


            #region Q9 - ToString and GetType

            //int pages3 = 464;

            //string convertedPages = pages3.ToString();

            //Console.WriteLine(convertedPages);

            //Console.WriteLine(convertedPages.GetType());

            #endregion

            #region Q10 - Boxing and Unboxing

            //int copies = 100;

            //object boxedCopies = copies;

            //int newCopies = (int)boxedCopies;

            //Console.WriteLine(copies);
            //Console.WriteLine(newCopies);

            #endregion


            #region Q11 - Nullable Value Types

            //int? year = null;

            //Console.WriteLine(year.HasValue);

            //year = 2023;

            //Console.WriteLine(year.HasValue);
            //Console.WriteLine(year.Value);

            #endregion


            #region Q12 - Nullable Reference Types

            //string? reviewer = null;

            //Console.WriteLine(reviewer == null);

            #endregion


            #region Q13 - Null Conditional Operator

            //Book? book = null;

            //string? title = book?.Title;

            //Console.WriteLine(title);

            #endregion


            #region Q14 - Null Coalescing Operators

            //Console.WriteLine(title ?? "Untitled");

            //title ??= "Untitled";

            //Console.WriteLine(title);

            #endregion


            #region Q15 - Null Forgiving Operator

            //string? name = "Ahmed";

            //string confirmedName = name!;

            //Console.WriteLine(confirmedName);

            #endregion
        }
    }
}
