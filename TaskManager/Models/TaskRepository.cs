using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskManager.Models
{
    public class Info
    {
        public int Laboriousness { get; set; }
        public TimeSpan TaskTime { get; set; }
        public static Info operator +(Info obj1, Info obj2)
        {
            Info res = new Info();
            res.Laboriousness = obj1.Laboriousness + obj2.Laboriousness;
            res.TaskTime = obj1.TaskTime + obj2.TaskTime;
            return res;
        }
    }
    public class Status
    {
        public int StatusId { get; set; }
        public string Name { get; set; }
    }
    
    public class TaskRepository
    {
          public static IEnumerable<Status> Statuses = new List<Status> { 
            new Status {
                StatusId = 1,
                Name = Resources.Resource.Appointed
            },
            new Status {
                StatusId = 2,
                Name = Resources.Resource.In_progress
            },
            new Status {
                StatusId = 3,
                Name = Resources.Resource.Suspended
            },
            new Status {
                StatusId = 4,
                Name = Resources.Resource.Сompleted
            }
        };
        private TaskManDbDataContext db = new TaskManDbDataContext();
        public void Delete(Task task)
        {
            IEnumerable<Task> tasks = db.Tasks.Where(t => t.Parent == task.Id);
            foreach (Task t in tasks)
                this.Delete(t);
            db.Tasks.DeleteOnSubmit(task);
        }
        public void Add(Task task)
        {
            db.Tasks.InsertOnSubmit(task);
        }
        public bool Update(Task task, Task task_new)
        {
            if (task_new.Status == 4)
                if (this.CompleteTask(task_new))
                    return false;
            task.Executives = task_new.Executives;
            task.Description = task_new.Description;
            task.EndDate = task_new.EndDate;
            task.Laboriousness = task_new.Laboriousness;
            task.Name = task_new.Name;
            task.RegDate = task_new.RegDate;
            task.Status = task_new.Status;
            task.TaskTime = task_new.TaskTime;

            return true;
        }
        public Task Get(int id)
        {
            Task task = db.Tasks.SingleOrDefault(t => id == t.Id);
            return task;
        }
        public IEnumerable<Task> SubTasks(int? id)
        {
            IEnumerable<Task> tasks = db.Tasks.Where(t => id == null ? t.Parent == null : t.Parent == id);
            return tasks;
        }
        public void Save()
        {
           db.SubmitChanges();
        }
        public Info GetInfo(int id)
        {
            IEnumerable<Task> tasks = db.Tasks.Where(t => t.Parent == id);
            Info taskInfo =  new Info();
            Info subTasksInfo = new Info();
            foreach (Task t in tasks)
                subTasksInfo += this.GetInfo(t.Id);
            Task task = db.Tasks.SingleOrDefault(t => t.Id == id);
            taskInfo.Laboriousness = task.Laboriousness;
            taskInfo.TaskTime = task.TaskTime;
            return taskInfo + subTasksInfo;
        }
        public bool CompleteTask(Task task)
        {
            IEnumerable<Task> tasks = db.Tasks.Where(t => t.Parent == task.Id);
            foreach (Task t in tasks)
            {
                if (this.CompleteTask(t))
                    return true;
                if (t.Status != 1)
                    t.Status = 4;
                else
                    return true;
            }
            return false;           
        }
    }
}