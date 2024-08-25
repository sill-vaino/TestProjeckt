namespace BusDriverBreaks
{
    class Program
    {
        static void DataFromFile()
        {
            Console.WriteLine("Data From file Acticated!");
        }

        static void DataFromInput()
        {
            Console.WriteLine("Data From Input Activated!");
        }
        static void Main(string[] args) {
            Console.WriteLine("Insertage (i/I) as if you want to insert data by hand or (f/F) if you want data from file");
            string Choice = Console.ReadLine();
            

            while (true)
            {
                if (Choice.ToUpper() == "I")
                {
                    DataFromInput();
                    break;
                }
                else if (Choice.ToUpper() == "F")
                {
                    DataFromFile();
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
