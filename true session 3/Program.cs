using System.Text;

namespace true_session_3
{
    internal class Program
    {  
        static string[] books =
    {
        "Clean Code",
        "The Pragmatic Programmer",
        "Refactoring"
    };

        static StringBuilder sb = new StringBuilder();

        static void Main()
        {
            #region Q1 - String Immutability

            
            //    string title = "clean code";

            //    string upperTitle = title.ToUpper();

            //    Console.WriteLine(title);
            //    Console.WriteLine(upperTitle);
            
            

            #endregion


            #region Q2 - ReferenceEquals

            
                //string first = "Clean Code";
                //string second = "Clean Code";

                //Console.WriteLine(ReferenceEquals(first, second));
            

            #endregion


            #region Q3 - StringBuilder Append

            //sb.Append("Book List");

            //sb.Append(" - Updated");

            //Console.WriteLine(sb);

            #endregion


            #region Q4 - StringBuilder Replace

            //sb.Replace("Book List", "Library");

            //Console.WriteLine(sb);

            #endregion


            #region Q5 - String Concatenation

            
                //string title = "Clean Code";
                //int pages = 464;

                //string result = "Book: " + title + ", Pages: " + pages;

                //Console.WriteLine(result);
            

            #endregion


            #region Q6 - String Interpolation

            
                //string title = "Clean Code";
                //int pages = 464;

                //string result = $"Book: {title}, Pages: {pages}";

                //Console.WriteLine(result);
            

            #endregion


            #region Q7 - String.Format

            
                //string title = "Clean Code";
                //int pages = 464;

                //string result = string.Format(
                //    "Book: {0}, Pages: {1}", title, pages
                //);

                //Console.WriteLine(result);
            

            #endregion


            #region Q8 - If Else

            
                //int pages = 464;

                //if (pages > 300)
                //{
                //    Console.WriteLine("Long Book");
                //}
                //else
                //{
                //    Console.WriteLine("Short Book");
                //}
            

            #endregion


            #region Q9 - Logical AND

            
                //int pages = 464;
                //bool isAvailable = true;

                //if (pages > 300 && isAvailable)
                //{
                //    Console.WriteLine("You can borrow this book");
                //}
            

            #endregion


            #region Q10 - Switch Statement

            
                //string title = "Refactoring";

                //switch (title)
                //{
                //    case "Clean Code":
                //        Console.WriteLine("Great choice!");
                //        break;

                //    case "Refactoring":
                //        Console.WriteLine("Nice pick!");
                //        break;

                //    default:
                //        Console.WriteLine("Never heard of it");
                //        break;
                //}
            

            #endregion


            #region Q11 - Ternary Operator

            
                //int pages = 464;

                //string sizeLabel = pages > 300
                //    ? "Long Book"
                //    : "Short Book";

                //Console.WriteLine(sizeLabel);
            

            #endregion


            #region Q12 - For Loop

            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}

            #endregion


            #region Q13 - While Loop

            
                //int i = 0;

                //while (i < books.Length)
                //{
                //    Console.WriteLine(books[i]);

                //    i++;
                //}
            

            #endregion


            #region Q14 - Do While Loop

            
                //int counter = 0;

                //do
                //{
                //    Console.WriteLine("Checking book...");

                //    counter++;

                //} while (counter < 3);
            

            #endregion


            #region Q15 - Foreach Loop

            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}

            #endregion


            #region Q16 - Break Statement

            //foreach (string book in books)
            //{
            //    if (book == "Refactoring")
            //    {
            //        break;
            //    }

            //    Console.WriteLine(book);
            //}

            #endregion


            #region Q17 - Continue Statement

            //foreach (string book in books)
            //{
            //    if (book == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(book);
            //}

            #endregion


            #region Q18 - Method and Return

            //PrintFirstBook();

            // books = Array.Empty<string>();
            // PrintFirstBook();

            #endregion
        }


        #region Q18 - PrintFirstBook Method

        //static void PrintFirstBook()
        //{
        //    if (books.Length == 0)
        //    {
        //        return;
        //    }

        //    Console.WriteLine(books[0]);
        //}

        #endregion
        }
    }

