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
            //To be implemented by students
            /// <summary>
            /// Add a job to this collection
            /// </summary>
            /// <param><c>job</c> is a valid Job object.</param>
            /// <returns>True if job has been added to this collection,
            /// False if job is present in this collection</returns>
            if (count >= this.Capacity) throw new ArgumentException();
            if (this.Contains(job.Id))
            {
                return false;
            }
            jobs[count++] = job;
            return true;
            Console.WriteLine();
        }

        public bool Contains(uint id)
        {
            //To be implemented by students
            /// <summary>
            /// Determines if this collection contains a job with a given id
            /// </summary>
            /// <param><c>id</c> is an integer between 001 and 999 inclusive.</param>
            /// <returns>True if this collection contains a job with given id, False otherwise</returns>
            for (int i = 0; i < count; i++)
            {
                if (jobs[i].Id == id)
                {
                    return true;
                }
            }
            return false;

        }

        public IJob? Find(uint id)
        {
            //To be implemented by students
            /// <summary>
            /// Returns a reference of the job in this collection with the given id. If no such job exists, returns null.
            /// </summary>
            /// <param><c>id</c> is an integer between 001 and 999 inclusive.</param>
            /// <returns>Reference to the job with given id if it exists,
            /// Null if no job with this id exists in this collection</returns>
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
            //To be implemented by students
            /// <summary>
            /// Removes a job from this collection, if present.
            /// </summary>
            /// <param><c>id</c> is an integer between 001 and 999 inclusive.</param>
            /// <returns>True if the job was present and has been removed, False otherwise</returns>
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
            //To be implemented by students
            /// <summary>
            /// Returns an array with the same elements as this collection
            /// </summary>
            /// <returns>Array containing all the Job objects currently in this collection</returns>
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
