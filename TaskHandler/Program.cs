using System;

namespace TaskHandler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime Now = DateTime.UtcNow;
            DateTime CurrentTimeZoneNow = TimeZone.CurrentTimeZone.ToLocalTime(Now);
            
            //Create User
            User u = new User("Adam Sir", 111);
            //Read User
            Console.WriteLine("User Name: " + u.Name);

            u.AddTask("Cook Breakfast");

            //Create Task
            u.AddTask("Brush Teeth", CurrentTimeZoneNow);

            Console.WriteLine("Number of Tasks in List: " + u.GetTaskList().Count);
            //Start Task
            //u.StartTask(CurrentTimeZoneNow);

            //Get TaskStartTime()
            Console.WriteLine("Current Start Time: " + u.StartTime.ToString("hh:mm tt"));

            //u.PrintAllTasks();
            //u.GetTask("Brush Teeth");
            u.GetTask(0);

            //End Task

            //Calculate Task
        }
    }
}
