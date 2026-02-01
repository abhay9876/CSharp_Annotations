using System;
using MethodOverride;
using LegacyApi;
using SupressWarning;
using CustomAttribute;
using RepeatableAttributes;
using MarkImportant;
using ToDoAtrribute;
using LoggingMethod;
using FieldValidation;

namespace Annotations
{
    public class Program
    {
        public static void Main()
        {
            // // Method Overriding Concept
            // Dog g = new Dog();
            // g.MakeSound();


            // // Use Obselete 
            // LegacyAPI la = new LegacyAPI();
            // la.OldMethod();// ( warning CS0618: 'LegacyAPI.OldMethod()' is obsolete: 'This method is OutDated..')
            // la.NewMethod();

            // SupressWarn sw = new SupressWarn();
            // sw.SuppressArrayListWarning();

            // CreateCustom cc = new CreateCustom();
            // cc.Create();

            // DisplayBugs db = new DisplayB ugs();
            // db.Display();

            // MarkImportantMethods imp = new MarkImportantMethods();
            // imp.Mark();

            // PrintPendingTasks pt = new PrintPendingTasks();
            // pt.Print();

            // TaskRunner tr = new TaskRunner();
            // tr.RunTasks();

            // try
            // {
            //     User user1 = new User("Abhay");
            //     User user2 = new User("Abhay12345");
            // }
            // catch (ArgumentException ex)
            // {
            //     System.Console.WriteLine(ex.Message);
            // }






        }
    }
}