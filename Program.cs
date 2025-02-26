namespace Topic_6b___Conditional_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            answer = "";
            int i = 10;
            while (i >= 2)
            {
                Console.WriteLine(i);
                i = i - 2;
            }

            while (answer != "batman")
            {
                Console.WriteLine("What is Bruce Wayne’s alter ego? ");
                answer = Console.ReadLine().ToLower();
            }

            string selection;
            do
            {
                Console.WriteLine("Who is the better captain?");
                Console.WriteLine("a - Captain Picard");
                Console.WriteLine("b - Captain Kirk");
                selection = Console.ReadLine();
            } while (selection != "a");
            Console.WriteLine("Correct");
        }
    }
}
