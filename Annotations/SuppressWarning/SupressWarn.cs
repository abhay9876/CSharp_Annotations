/*Exercise 3: Suppress Warnings for Unchecked Operations
Problem Statement: Create an ArrayList without generics and use #pragma warning disables
to hide compilation warnings.*/

using System.Collections;
namespace SupressWarning
{
    public class SupressWarn
    {
        public void SuppressArrayListWarning()
        {
#pragma warning disable CS0168
#pragma warning disable IDE0028

            ArrayList list = new ArrayList();
            list.Add("Data");
            list.Add(10);
            list.Add("C#");

            foreach (var v in list)
            {
                Console.WriteLine(v);
            }

#pragma warning restore CS0168
#pragma warning restore IDE0028
        }
    }
}