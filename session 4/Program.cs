namespace session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - One Dimensional Array

            
            //    double[] prices = { 25.5, 40.0, 33.75 };

            //    Console.WriteLine(prices[1]);
            

            #endregion


            #region Q2 - Two Dimensional Array

            
            //    int[,] shelfCopies =
            //    {
            //    { 3, 5 },
            //    { 1, 4 }
            //};

            //    Console.WriteLine(shelfCopies[1, 0]);
            

            #endregion


            #region Q3 - Method Without Parameters

            
                //void PrintWelcomeMessage()
                //{
                //    Console.WriteLine("Welcome to the Library!");
                //}

                //PrintWelcomeMessage();
            

            #endregion


            #region Q4 - Method With Parameters

            
                //void PrintBookTitle(string title)
                //{
                //    Console.WriteLine("Book title: " + title);
                //}

                //PrintBookTitle("Clean Code");
            

            #endregion


            #region Q5 - Passing Value Type

            
                //void AddBonusPages(int pages)
                //{
                //    pages += 50;
                //}

                //int pages = 400;

                //AddBonusPages(pages);

                //Console.WriteLine(pages);
            

            #endregion


            #region Q6 - Passing Array to Method

            
                //void ApplyDiscount(double[] prices)
                //{
                //    prices[0] -= 5;
                //}

                //double[] prices = { 25.5, 40.0 };

                //ApplyDiscount(prices);

                //Console.WriteLine(prices[0]);
            

            #endregion


            #region Q7 - Passing by Reference (ref)

            
                //void AddBonusPagesByRef(ref int pages)
                //{
                //    pages += 50;
                //}

                //int pages = 400;

                //AddBonusPagesByRef(ref pages);

                //Console.WriteLine(pages);
            

            #endregion


            #region Q8 - Replace Array Using ref

            
               // void ReplaceArray(ref double[] prices)
               // {
               //     prices = new double[] { 10.0, 12.5, 15.0 };
               // }

               // double[] prices = { 25.5, 40.0 };

               // ReplaceArray(ref prices);

               //Console.WriteLine(prices.Length);
            

            #endregion


            #region Q9 - Out Parameter

            
                //bool TryGetPrice(string title, out double price)
                //{
                //    if (title == "Clean Code")
                //    {
                //        price = 25.5;
                //        return true;
                //    }

                //    price = 0;
                //    return false;
                //}

                //if (TryGetPrice("Clean Code", out double price))
                //{
                //    Console.WriteLine(price);
                //}
                //else
                //{
                //    Console.WriteLine("Book not found");
                //}
            

            #endregion


            #region Q10 - Optional Parameters

            
                //void PrintBookInfo(string title, int pages = 300)
                //{
                //    Console.WriteLine($"Book: {title}, Pages: {pages}");
                //}

                //PrintBookInfo("Clean Code");

                //PrintBookInfo("Refactoring", 450);
            

            #endregion


            #region Q11 - Named Arguments

            
                //void PrintBookInfo(string title, int pages = 300)
                //{
                //    Console.WriteLine($"Book: {title}, Pages: {pages}");
                //}

                //PrintBookInfo(pages: 450, title: "Refactoring");
            

            #endregion


            #region Q12 - Params Parameter

            
                //void PrintAllTitles(params string[] titles)
                //{
                //    foreach (string title in titles)
                //    {
                //        Console.WriteLine(title);
                //    }
                //}

                //PrintAllTitles(
                //    "Clean Code",
                //    "The Pragmatic Programmer",
                //    "Refactoring"
                //);
            

            #endregion
        }
    }
}
