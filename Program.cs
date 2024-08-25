using System.IO;

namespace BusDriverBreaks
{
    class Program
    {
        static void DataFromFile()
        {
            
        }

        static void DataFromInput()
        {
            List<string> breakTimes = new List<string>();
            Console.WriteLine("Add new line as format HH:mmHH:mm");
            string breakTime = Console.ReadLine();
            while (true)
            {
                if (breakTime == "q")
                {
                    break;
                }
                else
                {
                    breakTimes.Add(breakTime);
                    Console.WriteLine("Add another line as format HH:mmHH:mm or quit the proccess by entering 'q'");
                    breakTime = Console.ReadLine();
                }
            }
                foreach (string time in breakTimes)
                {
                    Console.WriteLine(time);
                }
        }
        static void Main(string[] args) {
            Console.WriteLine("Insert (i/I) as if you want to insert data by hand or (f/F) if you want data from file");
            string Choice = Console.ReadLine();

            

            while (true)
            {
                if (Choice.ToUpper() == "I")
                {
                    DataFromInput();
                    break;
                }
                else if (Choice.ToUpper() == "F")
                { DataFromFile();
                    break;
                }
                else
                {
                    Console.WriteLine("Type (i/I) as input or (f/F) as file!");
                    Choice = Console.ReadLine();
                }

            }
        }


        
    }
}
