/*Exercise 5: Create and Use a Repeatable Attribute
Problem Statement: Define an attribute BugReport that can be applied multiple times on a
method.
Steps to Follow:
1. Define BugReport with a Description field.
2. Use AllowMultiple = true to allow multiple bug reports.
3. Apply it twice on a method.
4. Retrieve and print all bug reports.*/
using System;
using System.Reflection;
namespace RepeatableAttributes
{
    public class DisplayBugs
    {
        public void Display()
        {
            Type type = typeof(IssueTracker);
            MethodInfo method = type.GetMethod("ProcessData");

            var bugReports = method.GetCustomAttributes<BugReportAttribute>();

            foreach (var bug in bugReports)
            {
                Console.WriteLine($"Bug: {bug.Description}");
            }
        }
    }
}