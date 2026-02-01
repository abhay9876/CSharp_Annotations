namespace ToDoAtrribute
{
    public class FeatureModule
    {
        [Todo("Implement validation logic ", "Abhay")]
        [Todo("Handle edge cases for null input", "Abhay", "HIGH")]
        public void CreateUser()
        {
            Console.WriteLine("Creating user...");
        }

        [Todo("Optimize database queries", "Zeno")]
        public void FetchReports()
        {
            Console.WriteLine("Fetching reports...");
        }
    }
}