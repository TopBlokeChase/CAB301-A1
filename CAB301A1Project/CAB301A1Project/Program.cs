using System;

namespace CAB301A1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine("+-------------------+\n" +
                                  "| Main Method Start |\n" +
                                  "+-------------------+");
                Menu();
                Console.WriteLine("\n" +
                                  "---Start again or Exit?---");
                Console.WriteLine("1: Start again\n" +
                                  "2: Exit");
                string input = Console.ReadLine();
                if (input == "2")
                {
                    runProgram = false;
                }
            }          
        }
        static void Menu()
        {
            Console.WriteLine("Select an option");
            Console.WriteLine("1: Test Job Methods\n" +
                              "2: Test JobCollection Methods\n" +
                              "3: Test Scheculer Methods (Sorting Methods)");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("---Job Method Tests Starting---");
                    // Replace this with code
                    Console.WriteLine("---Job Method Tests Finished---");
                    break;
                case "2":
                    Console.WriteLine("---JobCollection Method Tests Starting---");
                    // Replace this with code
                    Console.WriteLine("---JobCollection Method Tests Finished---");
                    break;
                case "3":
                    Console.WriteLine("---JobCollection Method Tests Starting---");
                    Console.WriteLine("How many entries? (0-999)");
                    uint amount = uint.Parse(Console.ReadLine());
                    Console.WriteLine("What sorting type?\n" +
                                      "1: First-Come, First-Served\n" +
                                      "2: Priority\n" +
                                      "3: Shortest Job First");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            TestSortingMethods(amount, "FCFS");
                            break;
                        case "2":
                            TestSortingMethods(amount, "Priority");
                            break;
                        case "3":
                            TestSortingMethods(amount, "SJF");
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                    Console.WriteLine("---JobCollection Method Tests Finished---");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
        static void TestSortingMethods(uint amount, string type)
        {
            if (amount < 0 || amount > 999)
            {
                Console.WriteLine("Out of range: 0-999");
                return;
            }
            JobCollection jobCol = new JobCollection(amount);
            Random random = new Random();
            for (int i = 0; i < amount; i++)
            {
                jobCol.Add(new Job((uint)i + 1, (uint)random.Next(1, 1000), (uint)random.Next(1, 1000), (uint)random.Next(1, 10)));
            }
            Scheduler jobSch = new Scheduler(jobCol);
            switch (type)
            {
                case "FCFS":
                    jobSch.FirstComeFirstServed();
                    break;
                case "Priority":
                    jobSch.Priority();
                    break;
                case "SJF":
                    jobSch.ShortestJobFirst();
                    break;
                default:
                    Console.WriteLine("Invalid sorting type");
                    break;
            }
        }
    }
}