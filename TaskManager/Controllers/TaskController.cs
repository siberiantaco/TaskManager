using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        public ActionResult Index()
        {
            return View();     
        }
        public PartialViewResult SubTasks(int? id = null)
        {
            TaskRepository taskRepository = new TaskRepository();
            IEnumerable<Task> tasks = taskRepository.SubTasks(id);
            return PartialView(tasks);
        }
        public ActionResult Details(int id)
        {
            TaskRepository taskRepository = new TaskRepository();
            Task task = taskRepository.Get(id);
            if (task == null)
                return PartialView("NotFound");     
            IEnumerable<Task> subTasks = taskRepository.SubTasks(id);
            ViewBag.subTasks = subTasks;
            if (subTasks.Any())
            {
                Info info = taskRepository.GetInfo(id);
                ViewBag.info = info;
                ViewBag.subTasksAny = true;
            }
            else
                ViewBag.subTasksAny = false;
            return PartialView("Details", task);      
        }
        public ActionResult Delete(int id)
        {
            TaskRepository taskRepository = new TaskRepository();
            Task task = taskRepository.Get(id);
            if (task == null)
                return PartialView("NotFound");  
            taskRepository.Delete(task);
            taskRepository.Save();
            return PartialView(task);
        }
        public ActionResult Edit(int id)
        {
            
            TaskRepository taskRepository = new TaskRepository();
            Task task = taskRepository.Get(id);
            if (task == null)
                return PartialView("NotFound");
            return PartialView(task);
        }

        [HttpPost]
        public ActionResult Edit(Task task_new)
        {
            TaskRepository taskRepository = new TaskRepository();
            Task task = taskRepository.Get(task_new.Id);
            if (task == null)
                return PartialView("NotFound");
            if (taskRepository.Update(task, task_new))
            {
                if (ModelState.IsValid)
                {
                    taskRepository.Save();
                    return Details(task.Id);
                }
            }
            else
                ModelState.AddModelError("Status", Resources.Resource.StatusErr);
            return PartialView(task_new);
        }
        public ActionResult Create(int? id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(int? id, Task task)
        {
            TaskRepository taskRepository = new TaskRepository();
            task.Parent = id;
            taskRepository.Add(task);
            if (ModelState.IsValid)
            {
                taskRepository.Save();
                return Details(task.Id);
            }
            return View(task);
                    
        }  
    }
}
