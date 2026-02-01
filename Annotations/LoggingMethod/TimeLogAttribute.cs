namespace LoggingMethod
{

    [AttributeUsage(AttributeTargets.Method)]
    public class TimeLogAttribute : Attribute
    {
        public string Message { get; }

        public TimeLogAttribute(string message = "Execution Time")
        {
            Message = message;
        }
    }

}