
namespace CustomAttribute
{
    public class TaskManager
    {
        [TaskInfo(priority: 1, assignedTo: "Abhay")]
        public void DeployApplication()
        {
            Console.WriteLine("Deploying application...");
        }
    }
}
