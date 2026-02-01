namespace MarkImportant
{
    public class BusinessService
    {
        [ImportantMethod]
        public void ProcessPayment()
        {
            Console.WriteLine("Processing payment...");
        }

        [ImportantMethod("MEDIUM")]
        public void GenerateReport()
        {
            Console.WriteLine("Generating report...");
        }

        public void HelperMethod()
        {
            Console.WriteLine("Helper logic...");
        }
    }

}