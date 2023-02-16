namespace GitCheckpoint1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Git checkpoint task 1.1");

            CheckTest check = new CheckTest();
            check.testMessage("Task 2 checked");

            int result = Calculate.Add(2, 3);
            Console.WriteLine(result);
        }
    }
}