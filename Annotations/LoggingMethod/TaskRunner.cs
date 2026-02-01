/*3️⃣Create an Attribute for Logging Method Execution Time
Problem Statement: Define an attribute LogExecutionTime to measure method execution
time.
Requirements:
● Apply LogExecutionTime to a method.
● Use Stopwatch before and after execution.
● Print execution time.
● Apply it to different methods and compare the time taken.*/

using System;
using System.Diagnostics;
using System.Reflection;
namespace LoggingMethod
{
    public class TaskRunner
    {
        public void RunTasks()
        {
            MyTasks tasks = new MyTasks();
            Type type = typeof(MyTasks);

            foreach (MethodInfo method in type.GetMethods(
                         BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                var attr = method.GetCustomAttribute<TimeLogAttribute>();

                if (attr != null)
                {
                    Stopwatch watch = Stopwatch.StartNew();

                    method.Invoke(tasks, null);

                    watch.Stop();

                    Console.WriteLine(
                        $"{method.Name} | {attr.Message} : {watch.ElapsedMilliseconds} ms");
                }
            }
        }
    }

}