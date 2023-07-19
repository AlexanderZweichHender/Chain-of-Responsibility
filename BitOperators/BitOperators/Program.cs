namespace BitOperators
{
    internal class Program
    {
        private static void Main()
        {
            int read = 0b_001;
            int write = 0b_010;
            int delete = 0b_100;

            //read, write = 011
            //read write delete = 111

            int allRights = read | write | delete;
            //Console.WriteLine(Convert.ToString(allRights, 2));

            int userRights = read | write;
            //Console.WriteLine(userRights & write);

            //Console.WriteLine(Convert.ToString(userRights & allRights, 2));

            Console.WriteLine((allRights & userRights) == allRights);
        }
    }
}