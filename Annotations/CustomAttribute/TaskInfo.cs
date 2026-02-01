using System;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TaskInfoAttribute : Attribute
    {
        public int Priority { get; }
        public string AssignedTo { get; }

        public TaskInfoAttribute(int priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }
}
