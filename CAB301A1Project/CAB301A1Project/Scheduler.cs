namespace CAB301A1Project
{
    public class Scheduler : IScheduler
    {
        private IJob[] sortedJobs;
        public Scheduler(IJobCollection jobs)
        {
            Jobs = jobs;
        }

        public IJobCollection Jobs { get; }

        public IJob[] FirstComeFirstServed()
        {
            Console.WriteLine("Frst-Come, First-Served Sort");
            //To be implemented by students - Done
            //Do commenting
            //Uses Bubble Sort
            sortedJobs = Jobs.ToArray();
            IJob tempJob;
            Console.WriteLine("Before Sort");
            foreach (IJob job in sortedJobs)
            {
                Console.WriteLine(job.ToString());
            }
            for (int i = 0; i < Jobs.Count - 1; i++)
            {
                for (int j = 0; j < Jobs.Count - 1 - i; j++)
                {
                    if (sortedJobs[j].TimeReceived > sortedJobs[j + 1].TimeReceived)
                    {
                        tempJob = sortedJobs[j];
                        sortedJobs[j] = sortedJobs[j + 1];
                        sortedJobs[j + 1] = tempJob;
                    }
                }
            }
            Console.WriteLine("After Sort");
            foreach (IJob job in sortedJobs)
            {
                Console.WriteLine(job.ToString());
            }
            return sortedJobs;
        }

        public IJob[] Priority()
        {
            Console.WriteLine("Priority Sort");
            //To be implemented by students - Done
            //Do commenting
            //Uses Bubble Sort
            sortedJobs = Jobs.ToArray();
            IJob tempJob;
            Console.WriteLine("Before Sort");
            foreach (IJob job in sortedJobs)
            {
                Console.WriteLine(job.ToString());
            }
            for (int i = 0; i < Jobs.Count - 1; i++)
            {
                for (int j = 0; j < Jobs.Count - 1 - i; j++)
                {
                    if (sortedJobs[j].Priority < sortedJobs[j + 1].Priority)
                    {
                        tempJob = sortedJobs[j];
                        sortedJobs[j] = sortedJobs[j + 1];
                        sortedJobs[j + 1] = tempJob;
                    }
                }
            }
            Console.WriteLine("After Sort");
            foreach (IJob job in sortedJobs)
            {
                Console.WriteLine(job.ToString());
            }
            return sortedJobs;

        }

        public IJob[] ShortestJobFirst()
        {
            Console.WriteLine("Shortest First Sort");
            //To be implemented by students - Done
            //Do commenting
            //Uses Bubble Sort
            sortedJobs = Jobs.ToArray();
            IJob tempJob;
            Console.WriteLine("Before Sort");
            foreach (IJob job in sortedJobs)
            {
                Console.WriteLine(job.ToString());
            }
            for (int i = 0; i < Jobs.Count - 1; i++)
            {
                for (int j = 0; j < Jobs.Count - 1 - i; j++)
                {
                    if (sortedJobs[j].ExecutionTime > sortedJobs[j + 1].ExecutionTime)
                    {
                        tempJob = sortedJobs[j];
                        sortedJobs[j] = sortedJobs[j + 1];
                        sortedJobs[j + 1] = tempJob;
                    }
                }
            }
            Console.WriteLine("After Sort");
            foreach (IJob job in sortedJobs)
            {
                Console.WriteLine(job.ToString());
            }
            return sortedJobs;

        }
    }
}