using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using todo_aspnetmvc_ui.Models;
using todo_aspnetmvc_ui.Models.ViewModels;
using todo_domain_entities;
using todo_domain_entities.Data.Models;
using todo_domain_entities.Services;

namespace todo_aspnetmvc_ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly IToDoService _toDoService;

        public HomeController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        public IActionResult Index()
        {
            var data = _toDoService.GetAllToDoLists();

            return View(nameof(Index), data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                _toDoService.AddList(new ToDoList { Name = collection["Name"] });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Edit(int id)
        {
            try
            {
                var findList = _toDoService.FindListById(id);
                return View(findList);
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                _toDoService.ModifyList(id, collection["Name"]);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Copy(int id)
        {
            var findList = _toDoService.FindListById(id);
            return View(findList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Copy(int id, IFormCollection collection)
        {
            try
            {
                _toDoService.CopyList(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Details(int id)
        {
            var findList = _toDoService.FindListById(id);

            return View(new ListTaskViewModel 
            { 
                TDList = findList,
                Tasks = _toDoService.GetAllToDoTasks(findList)
            });
        }

        public IActionResult Delete(int id)
        {
            try
            {
                var findList = _toDoService.FindListById(id);
                return View(findList);
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _toDoService.DeleteList(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Settings(int id)
        {
            ToDoList findList;
            if (id == 0)
            {
                findList = null;
            }
            else
            {
                findList = _toDoService.FindListById(id);
            }

            return View(new ListTaskViewModel
            {
                TDList = findList
            });
        }
        

        [HttpPost]
        public IActionResult Settings(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult CreateTask()
        {
            
            try
            {
                var allList = _toDoService.GetAllToDoLists();
                var newModel = new TaskViewModel { ToDoLists = allList };
                return View(newModel);
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTask(IFormCollection collection)
        {
            var listId = int.Parse(collection["ToDoLists"]);
            String date = collection["TaskDueDate"];

            try
            {
                ToDoTask task;
                if (date.Equals(string.Empty))
                {
                    task = new ToDoTask
                    {
                        TaskStatus = (Status)Enum.Parse(typeof(Status), collection["TaskStatus"]),
                        TaskTitle = collection["TaskTitle"],
                        TaskDescription = collection["TaskDescription"],
                        TaskNotes = collection["TaskNotes"],
                        TaskTag = collection["TaskTag"]
                    };
                }
                else
                {
                    task = new ToDoTask
                    {
                        TaskStatus = (Status)Enum.Parse(typeof(Status), collection["TaskStatus"]),
                        TaskTitle = collection["TaskTitle"],
                        TaskDescription = collection["TaskDescription"],
                        TaskNotes = collection["TaskNotes"],
                        TaskTag = collection["TaskTag"],
                        TaskDueDate = DateTime.Parse(date)
                    };
                }

                _toDoService.AddTask(listId, task);
                return RedirectToAction("Details", new { id = listId });
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult DetailsTask(int id)
        {
            try
            {
                var findTask = _toDoService.FindTaskById(id);

                return View(findTask);
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult EditTask(int id)
        {
            try
            {
                var allList = _toDoService.GetAllToDoLists();
                var task = _toDoService.FindTaskById(id);

                return View(new TaskViewModel 
                { 
                    ToDoLists = allList, 
                    Task = task
                });
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTask(int id, IFormCollection collection)
        {
            var listId = int.Parse(collection["ToDoLists"]);
            string date = collection["Task.TaskDueDate"];

            try
            {
                ToDoTask task;
                if (date.Equals(string.Empty))
                {
                    task = new ToDoTask
                    {
                        TaskStatus = (Status)Enum.Parse(typeof(Status), collection["Task.TaskStatus"]),
                        TaskTitle = collection["Task.TaskTitle"],
                        TaskDescription = collection["Task.TaskDescription"],
                        TaskNotes = collection["Task.TaskNotes"],
                        TaskTag = collection["Task.TaskTag"]
                    };
                }
                else
                {
                    task = new ToDoTask
                    {
                        TaskStatus = (Status)Enum.Parse(typeof(Status), collection["Task.TaskStatus"]),
                        TaskTitle = collection["Task.TaskTitle"],
                        TaskDescription = collection["Task.TaskDescription"],
                        TaskNotes = collection["Task.TaskNotes"],
                        TaskTag = collection["Task.TaskTag"],
                        TaskDueDate = DateTime.Parse(date)
                    };
                }

                _toDoService.ModifyTask(id, task);

                return RedirectToAction("Details", new { id = listId });
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult UpdateStatus(int id)
        {
            try
            {
                var task = _toDoService.FindTaskById(id);
                return View(task);
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateStatus(int id, IFormCollection collection)
        {
            var taskForID = _toDoService.FindTaskById(id);
            var listId = taskForID.ListId;

            try
            {
                var task = new ToDoTask
                {
                    TaskStatus = (Status)Enum.Parse(typeof(Status), collection["TaskStatus"]),
                };
                _toDoService.UpdateStatus(id, task);

                return RedirectToAction("Details", new { id = listId });
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult DeleteTask(int id)
        {
            try
            {
                var findTask = _toDoService.FindTaskById(id);
                return View(findTask);
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        public IActionResult DeleteTask(int id, IFormCollection collection)
        {
            try
            {
                _toDoService.DeleteTask(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Remind(int id)
        {
            return View(_toDoService.FindTaskById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remind (int id, IFormCollection collection)
        {
            var taskForID = _toDoService.FindTaskById(id);
            var listId = taskForID.ListId;
            string date = collection["TaskRemindDate"];

            try
            {
                var task = new ToDoTask
                {
                    TaskRemindDate = DateTime.Parse(date)
                };
                _toDoService.Remind(id, task);

                return RedirectToAction("Details", new { id = listId });
            }
            catch
            {
                return RedirectToAction("Error");
            }

        }

        public IActionResult ShowRemind()
        {
            var allLists = _toDoService.GetAllToDoLists();
            List<ToDoTask> tasks = new List<ToDoTask>();
            for (int i = 0; i < allLists.Count; i++)
            {
                tasks.AddRange(_toDoService.GetAllToDoTasks(allLists.ElementAt(i)));    
            }

            var taskToRemind = tasks.Where(x => x.TaskRemindDate.Equals(DateTime.Now.Date));

            return View(new ReminderViewModel
            {
                Tasks = taskToRemind
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
