using System;
namespace TaskHandler
{
    public class User:Task
    {
        public String Name { get; set; }
        private int Id;
        public Task _Task { get; set; }

        public User()
        {

        }
        public User(String name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public User(String Name, int Id, Task _Task)
        {
            this.Name = Name;
            this.Id = Id;
            this._Task = _Task;
        }
    }
}
