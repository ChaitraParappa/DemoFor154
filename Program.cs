namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            // Console.WriteLine("Starting of the Program");

            //Username.PrinttheUsername();

            //DemoLoop.PrintForLoop();

            // Console.WriteLine("Ending of the Program");

            //Username.Display();

            Console.WriteLine("Please enter the value for number of flips");
            int number = Convert.ToInt32(Console.ReadLine());

            double HeadPercentage=FlipCoin.FlipTheCoin(number,10);

            Console.WriteLine("Head Percentage : " + HeadPercentage);

        }


    }
}