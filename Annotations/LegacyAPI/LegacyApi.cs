/*Exercise 2: Use Obsolete Attribute to Mark an Old Method
Problem Statement: Create a class LegacyAPI with an old method OldFeature(), which
should not be used anymore. Instead, introduce a new method NewFeature().
Steps to Follow:
1. Define a class LegacyAPI.
2. Mark OldFeature() as [Obsolete].
3. Call both methods and observe the warning.w*/


namespace LegacyApi
{
    public class LegacyAPI
    {
        [Obsolete("This method is OutDated..")]
        public void OldMethod()
        {
            Console.WriteLine("Old Method");
        }

        public void NewMethod()
        {
            Console.WriteLine("New Method");
        }
    }
}