using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TaskHandler
{
    public class Task
    {
        public String TaskName { get; set; }
        public int TaskId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public String TaskStatus { get; set; }
        private List<Task> TaskList = new List<Task>();

        public Task() { }

        public Task(String TaskName, DateTime StartTime, String TaskStatus)
        {
            this.TaskName = TaskName; //Add Task Name
            this.StartTime = StartTime; //Add StartTime
            this.TaskStatus = TaskStatus; //Add Task Status
        }
        public Task(String TaskName, DateTime StartTime)
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
        public Task(String TaskName)
        {
            //Auto Generate the ID
            this.TaskName = TaskName; //Add Task Name
            Console.WriteLine("TASK CONSTRUCTOR: " + TaskList.Count);
            //StartTime is Null
            //EndTime is Null
            //Task Status
        }
        public Task(String name, int id)
        {
            this.TaskName = name;
            this.TaskId = id;
        }
        public void AddTask(String TaskName, DateTime StartTime, String TaskStatus) {
            TaskList.Add(new Task(TaskName, StartTime, TaskStatus));
        }

        public void AddTask(String TaskName, DateTime StartTime)
        {
            TaskList.Add(new Task(TaskName, StartTime));
        }

        public void AddTask(String TaskName)
        {
            TaskList.Add(new Task(TaskName));
        }

        public List<Task> GetTaskList()
        {
            return this.TaskList;
        }

        [Route("api/tasks")]    
        [HttpGet]
        public void PrintAllTasks()
        {
            foreach (var i in TaskList)
            {
                string myjson = JsonConvert.SerializeObject(i, Formatting.Indented);
                Console.WriteLine(myjson);
            }
        }
        
        public void GetTask(String name)
        {
            List<Task> FilterTaskList = TaskList.Where(i => i.TaskName == name).ToList();
            string myjson = JsonConvert.SerializeObject(FilterTaskList, Formatting.Indented);
            Console.WriteLine(myjson);
        }

        public void GetTask(int Id)
        {
            List<Task> FilterTaskList = TaskList.Where(i => i.TaskId == Id).ToList();
            string myjson = JsonConvert.SerializeObject(FilterTaskList, Formatting.Indented);
            Console.WriteLine(myjson);
        }

        #region ----------Task Handlers---------
        public void StartTask(DateTime StartTime)
        {
            this.StartTime = StartTime;
        }

        public void EndTask(DateTime EndTime)
        {
            this.EndTime = EndTime;
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
