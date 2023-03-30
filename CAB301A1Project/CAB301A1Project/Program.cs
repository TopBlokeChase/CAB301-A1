using System;

namespace CAB301A1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-------------------+\n" +
                              "| Main Method Start |\n" +
                              "+-------------------+");
            Console.WriteLine("---Test Starting---");
            TestSortFCFS();
            Console.WriteLine("---Test Finished---");
        }

        static void TestSortFCFS()
        {
            Job job1 = new Job(1, 1, 5, 9);
            Job job2 = new Job(2, 9, 1, 5);
            Job job3 = new Job(3, 5, 9, 1);
            JobCollection jobCol1 = new JobCollection(3);
            jobCol1.Add(job1);
            jobCol1.Add(job2);
            jobCol1.Add(job3);
            Scheduler jobSch = new Scheduler(jobCol1);
            IJob[] sortedCol1 = jobSch.FirstComeFirstServed();
        }
    }
}