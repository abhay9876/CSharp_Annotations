namespace MarkImportant
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ImportantMethodAttribute : Attribute
    {
        public string Level { get; }
        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }
}