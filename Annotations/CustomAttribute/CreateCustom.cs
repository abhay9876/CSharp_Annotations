/*Exercise 4: Create a Custom Attribute and Use It
Problem Statement: Create a custom attribute TaskInfo to mark tasks with priority and
assigned person.
Steps to Follow:
1. Define an attribute TaskInfo with fields Priority and AssignedTo.
2. Apply this attribute to a method in TaskManager class.
3. Retrieve the attribute details using Reflection.*/
using System;
using System.Reflection;
namespace CustomAttribute
{
    public class CreateCustom
    {
        public void Create()
        {
            Type type = typeof(TaskManager);
            MethodInfo method = type.GetMethod("DeployApplication");

            TaskInfoAttribute attribute =
                method.GetCustomAttribute<TaskInfoAttribute>();

            if (attribute != null)
            {
                Console.WriteLine($"Priority: {attribute.Priority}");
                Console.WriteLine($"Assigned To: {attribute.AssignedTo}");
            }
        }
    }
}