using System;
using System.Diagnostics;

namespace CAB301A1Project
{
    public class JobCollection : IJobCollection
    {
        private IJob[] jobs;
        private uint count;

        public JobCollection(uint capacity)
        {
            if (!(capacity >= 1)) throw new ArgumentException();
            jobs = new IJob[capacity];
            count = 0;
        }

        public uint Capacity
        {
            get { return (uint)jobs.Length; }
        }

        public uint Count
        {
            get { return count; }
        }

        public bool Add(IJob job)
        {
            //To be implemented by students - Done
            //Do commenting
            if (this.Count >= this.Capacity) throw new ArgumentException();
            if (this.Contains(job.Id))
            {
                return false;
            }
            jobs[count++] = job;
            return true;
        }

        public bool Contains(uint id)
        {
            //To be implemented by students - Done
            //Do commenting
            for (int i = 0; i < this.Count; i++)
            {
                if (jobs[i].Id == id)
                {
                    return false;
                }
            }
            return true;

        }

        public IJob? Find(uint id)
        {
            //To be implemented by students
            //Do commenting
            for (int i = 0; i < this.Count; i++)
            {
                if (jobs[i].Id == id)
                {
                    return jobs[i];
                }
            }
            return null;

        }

        public bool Remove(uint id)
        {
            //To be implemented by students - Done
            //Do commenting
            IJob? tempJob = this.Find(id);
            if (tempJob == null)
            {
                return false;
            }
            bool foundJob = false;
            for (int i = 0; i < this.Count; i++)
            {
                if (tempJob.Id == jobs[i].Id)
                {
                    foundJob = true;
                }
                if (foundJob)
                {
                    jobs[i] = jobs[i+1];
                }
            }
            this.count--;
            return true;
        }

        public IJob[] ToArray()
        {
            //To be implemented by students - Done
            //Do commenting
            IJob[] newJobs;
            newJobs = new Job[this.Capacity];
            for (int i = 0; i < this.Count; i++)
            {
                newJobs[i] = jobs[i];
            }
            return newJobs;
        }
    }
}
