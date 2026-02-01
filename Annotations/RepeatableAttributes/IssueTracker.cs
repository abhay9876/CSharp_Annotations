namespace RepeatableAttributes
{
    public class IssueTracker
    {
        [BugReport("NullReferenceException, when input is empty")]
        [BugReport("Performance issue....")]
        public void ProcessData()
        {
            Console.WriteLine("Processing data...");
        }
    }

}