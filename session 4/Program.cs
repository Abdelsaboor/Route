namespace session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3 };
            int[] b = a;
            b[1] = 20;
            int c = a[1];
            c = 500;
            string s1 = "hi";
            string s2 = s1;
            s2 = "bye";

            Console.WriteLine(a[1]);
            Console.WriteLine(c);
            Console.WriteLine(s1);

        }
    }
}
