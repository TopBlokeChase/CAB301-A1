﻿namespace CAB301_A1_Solution
{
    public class Scheduler : IScheduler
    {
        public Scheduler(IJobCollection jobs)
        {
            Jobs = jobs;
        }

        public IJobCollection Jobs { get; }

        public IJob[] FirstComeFirstServed()
        {

            //To be implemented by students
            throw new System.NotImplementedException();

        }

        public IJob[] Priority()
        {

            //To be implemented by students
            throw new System.NotImplementedException();

        }

        public IJob[] ShortestJobFirst()
        {

            //To be implemented by students
            throw new System.NotImplementedException();

        }
    }
}