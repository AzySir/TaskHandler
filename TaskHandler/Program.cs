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
            u.AddTask("Cook Breakfast", CurrentTimeZoneNow);

            //Start Task
            u.StartTask(CurrentTimeZoneNow);

            //Get TaskStartTime()
            Console.WriteLine("Current Start Time: " + u.GetStartTime().ToString("hh:mm tt"));

            //End Task

            //Calculate Task
        }
    }
}
