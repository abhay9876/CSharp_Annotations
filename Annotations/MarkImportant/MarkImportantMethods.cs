/*1️Create an Attribute to Mark Important Methods
Problem Statement: Define a custom attribute ImportantMethod that can be applied to
methods to indicate their importance.
Requirements:
1. Define ImportantMethod with an optional Level parameter (default: "HIGH").
2. Apply it to at least two methods.
3. Retrieve and print annotated methods using Reflection.*/

using System.Reflection;
namespace MarkImportant
{
    public class MarkImportantMethods
    {
        public void Mark()
        {
            Type type = typeof(BusinessService);

            foreach (MethodInfo method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
            {
                var attribute = method.GetCustomAttribute<ImportantMethodAttribute>();

                if (attribute != null)
                {
                    Console.WriteLine(
                        $"Method: {method.Name}, Importance Level: {attribute.Level}");
                }
            }
        }
    }
}
