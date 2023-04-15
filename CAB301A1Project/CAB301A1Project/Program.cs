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
            Console.WriteLine("+-------------------+\n" +
                              "| Main Method Start |\n" +
                              "+-------------------+");
            Console.WriteLine("Select an option");
            Console.WriteLine("1: Basic Test\n" +
                              "2: Randomised Test");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("---Basic Test Starting---");
                    TestSorter();
                    Console.WriteLine("---Basic Test Finished---");
                    break;
                case "2":
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
                            TestSorterRandomised(amount, "FCFS");
                            break;
                        case "2":
                            TestSorterRandomised(amount, "Priority");
                            break;
                        case "3":
                            TestSorterRandomised(amount, "SJF");
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
        static void TestSorter()
        {
            Job job1 = new Job(1, 1, 5, 9);
            Job job2 = new Job(2, 9, 1, 5);
            Job job3 = new Job(3, 5, 9, 1);
            JobCollection jobCol = new JobCollection(3);
            jobCol.Add(job1);
            jobCol.Add(job2);
            jobCol.Add(job3);
            Scheduler jobSch = new Scheduler(jobCol);
            jobSch.FirstComeFirstServed();
            jobSch.Priority();
            jobSch.ShortestJobFirst();
        }
        static void TestSorterRandomised(uint amount, string type)
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