using System;

namespace CAB301A1Project
{
    public class Job : IJob
    {
        public Job(uint jobId, uint timeReceived, uint executionTime, uint priority)
        {
            Id = jobId;
            TimeReceived = timeReceived;
            ExecutionTime = executionTime;
            Priority = priority;
        }

        private uint id;
        private uint timeReceived;
        private uint executionTime;
        private uint priority;

        public uint Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (!IsValidId(value))
                    throw new ArgumentOutOfRangeException(nameof(Id));
                id = value;
            }
        }

        public uint TimeReceived
        {
            get
            {
                return timeReceived;
            }
            private set
            {
                if (!IsTimeReceived(value))
                    throw new ArgumentOutOfRangeException(nameof(Id));
                timeReceived = value;
            }
        }

        public uint ExecutionTime
        {
            get
            {
                return executionTime;
            }
            private set
            {
                if (!IsValidExecutionTime(value))
                    throw new ArgumentOutOfRangeException(nameof(ExecutionTime));
                executionTime = value;
            }
        }

        public uint Priority
        {
            get
            {
                return priority;
            }
            private set
            {
                if (!IsValidPriority(value))
                    throw new ArgumentException(nameof(Priority));
                priority = value;
            }
        }

        public static bool IsValidId(uint id)
        {
            //To be implemented by students
            /// <summary>
            /// Determines whether a supplied jog id is valid.
            /// </summary>
            /// <param><c>id</c> is an integer between 001 and 999 inclusive.</param>
            /// <returns>True if id is valid, False otherwise</returns>
            if (id >= 1 && id <= 999)
            {
                return true;
            }
            return false;
        }

        public static bool IsValidExecutionTime(uint executiontime)
        {
            //To be implemented by students
            /// <summary>
            /// Determines whether a supplied execution time is valid.
            /// </summary>
            /// <param><c>executionTime</c> is an integer greater than 0.</param>
            /// <returns>True if execution time is valid, False otherwise</returns>
            if (executiontime <= 0)
            {
                return false;
            }
            return true;
        }

        public static bool IsValidPriority(uint priority)
        {
            //To be implemented by students
            /// <summary>
            /// Determines whether a supplied priotiry is valid.
            /// </summary>
            /// <param><c>priority</c> is an integer between 1 and 9 inclusive.</param>
            /// <returns>True if priority is valid, False otherwise</returns>
            if (priority >= 1 && priority <= 9)
            {
                return true;
            }
            return false;
        }

        public static bool IsTimeReceived(uint time)
        {
            //To be implemented by students
            /// <summary>
            /// Determines whether a supplied time received is valid.
            /// </summary>
            /// <param><c>time</c> is an integer greater than 0.</param>
            /// <returns>True if time received is valid, False otherwise</returns>
            if (time > 0)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Job(jobId: {id}, timeReceived: {timeReceived}, executionTime: {executionTime}, priority: {priority})";
        }
    }
}