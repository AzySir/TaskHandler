using System;
using System.Collections.Generic;

namespace TaskHandler
{
    public class Task
    {
        private String TaskName;
        private int TaskId;
        private DateTime StartTime;
        private DateTime EndTime;
        private String TaskStatus;
        //private Dictionary<String, int> dic = new Dictionary<String, int>();
        private List<Task> MyTasks = new List<Task>();

        public void AddTask(String TaskName)
        {
            //Auto Generate the ID
            this.TaskName = TaskName; //Add Task Name
            //StartTime is Null
            //EndTime is Null
            //Task Status
        }
        public void AddTask(String TaskName, DateTime StartTime, String TaskStatus) { 
            //Auto Generate the ID
            this.TaskName = TaskName; //Add Task Name
            this.StartTime = StartTime; //Add StartTime
            this.TaskStatus = TaskStatus; //Add Task Status
        }
        public void AddTask(String TaskName, DateTime StartTime)
        {
            this.TaskName = TaskName;
            this.StartTime = StartTime;

            if (StartTime < DateTime.Now)
            {
                this.TaskStatus = "Not Started";
            }
            else
            {
                this.TaskStatus = "Started";
            }
        }

        #region ----------Extra Tasks---------

        public String GetTask()
        {
            return this.TaskName;
        }

        public void DeleteTask()
        {

        }

        public void StartTask(DateTime StartTime)
        {
            this.StartTime = StartTime;
        }

        public void EndTask(DateTime EndTime)
        {
            this.EndTime = EndTime;
        }

        public DateTime GetStartTime()
        {
            return this.StartTime;
        }

        public DateTime GetEndTime()
        {
            return this.EndTime;
        }

        public void SetResumeType()
        {
            //Options
                //a) Manual - User Entry to Begin Task
                //b) Automatic Start - Depending on Time
        }

        #endregion
    }
}
