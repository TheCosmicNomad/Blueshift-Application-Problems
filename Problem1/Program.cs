namespace Blueshift_Problem1
{
    public class Program
    {
        public static void Main()
        {
            Calculator c = new Calculator();
            // This dictionary/hash table is to give calculation functions a unique string identifier to enhance expandability
            

            while (true)
            {
                // Display a list of the modes from the Dictionary/HashTable
                Console.WriteLine(@"Please enter an calculation mode from the following list: ");
                foreach (var item in c.GetAllModes())
                {
                    Console.WriteLine(item);
                }

                // Get the mode from the user
                Console.Write("Calculation Mode: ");
                string mode = Console.ReadLine();

                // Check if the application is in the halting state
                if (mode.ToLower() == "exit")
                {
                    Environment.Exit(0); ;
                }

                // Check if the function is a valid mode
                if (c.IsMode(mode))
                {
                    string numberInput;
                    // this assignment of 0 will not be used unless the user inputs 0
                    // it is present because the compiler thinks 'number' is unassigned when the function is invoked
                    int number = 0;

                    // repeat until the number is valid or is the exit state
                    do
                    {
                        Console.Write("Please enter a number: ");
                        numberInput = Console.ReadLine();
                    }
                    while (numberInput != "exit" && !int.TryParse(numberInput, out number));

                    // enter the exit state
                    if (numberInput.ToLower() == "exit")
                    {
                        Environment.Exit(0);
                    }

                    // execute the function and output result
                    else
                    {
                        string result = c.Calculate(mode, number);
                        Console.WriteLine(result);

                        Console.WriteLine();
                    }
                }
                
                // error handling for mode
                else
                {
                    Console.WriteLine("This is not a valid calculation mode");
                }
            }

        }
    }
}