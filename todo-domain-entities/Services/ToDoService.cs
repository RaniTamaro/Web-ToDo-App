using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_domain_entities.Context;
using todo_domain_entities.Data.Models;

namespace todo_domain_entities.Services
{
    public class ToDoService : IToDoService
    {
        private readonly ToDoContext _context;

        public ToDoService(ToDoContext context)
        {
            _context = context;
        }

        public void AddList(ToDoList list)
        {
            CheckListValidator(list);
            list.Tasks = new List<ToDoTask>();

            _context.Lists.Add(list);
            _context.SaveChanges();
        }

        public void AddTask(int listId, ToDoTask task)
        {
            var findList = FindListById(listId);
            CheckListValidator(findList);
            CheckTaskValidator(task);

            task.TaskCreationDate = DateTime.Now;
            task.TDList = findList;
            task.ListId = findList.ListId;
            findList.Tasks = GetAllToDoTasks(findList);
            findList.Tasks.Add(task);

            _context.Tasks.Add(task);
            _context.Lists.Update(findList);
            _context.SaveChanges();
        }

        public ToDoList FindListById(int id)
        {
            CheckIdValidator(id);

            var list = _context.Lists.Where(x => x.ListId == id).FirstOrDefault();
            if (list is null)
            {
                throw new ArgumentException("List with this id don't exist");
            }

            return list;
        }

        public ToDoTask FindTaskById(int id)
        {
            CheckIdValidator(id);

            var task = _context.Tasks.Where(x => x.TaskId == id).FirstOrDefault();
            if (task is null)
            {
                throw new ArgumentException("Task with this id don't exist");
            }

            return task;
        }

        public List<ToDoList> GetAllToDoLists()
        {
            return _context.Lists.ToList();
        }

        public List<ToDoTask> GetAllToDoTasks(ToDoList list)
        {
            return _context.Tasks.Where(x => x.TDList == list).ToList();
        }

        public void ModifyList(int id, string newName)
        {
            var editList = FindListById(id);

            if (newName is null)
            {
                throw new ArgumentNullException(nameof(newName));
            }

            if (newName.Equals(string.Empty))
            {
                throw new ArgumentNullException(nameof(newName));
            }

            List<ToDoTask> oldTasks = null;
            List<ToDoTask> newTasks = new List<ToDoTask>();
            oldTasks = ReturnTask(editList);
            editList.Name = newName;

            if (oldTasks != null)
            {
                for (int i = 0; i< oldTasks.Count; i++)
                {
                    var modifyTask = new ToDoTask { TaskTitle = oldTasks[i].TaskTitle, TaskStatus = oldTasks[i].TaskStatus, TDList = editList };
                    ModifyTask(oldTasks[i].TaskId, modifyTask);
                    var task = (FindTaskById(oldTasks[i].TaskId));
                    newTasks.Add(task);
                }
            }
            editList.Tasks = newTasks;
            
            _context.Lists.Update(editList);
            _context.SaveChanges();
        }

        public void ModifyTask(int id, ToDoTask newTask)
        {
            var oldTask = FindTaskById(id);
            CheckTaskValidator(newTask);

            if (newTask != null)
            {
                UpdateStatus(id, newTask);

                if (!oldTask.TaskTitle.Equals(newTask.TaskTitle))
                {
                    oldTask.TaskTitle = newTask.TaskTitle;
                }
                
                if ((newTask.TaskDescription != null && !newTask.TaskDescription.Equals(string.Empty)) && !oldTask.TaskDescription.Equals(newTask.TaskDescription))
                {
                    oldTask.TaskDescription = newTask.TaskDescription;
                }

                if (newTask.TaskDueDate != null && oldTask.TaskDueDate != newTask.TaskDueDate)
                {
                    oldTask.TaskDueDate = newTask.TaskDueDate;
                }

                if (newTask.TaskNotes != null && oldTask.TaskNotes != newTask.TaskNotes)
                {
                    oldTask.TaskNotes = newTask.TaskNotes;
                }

                if (newTask.TaskTag != null && oldTask.TaskTag != newTask.TaskTag)
                {
                    oldTask.TaskTag = newTask.TaskTag;
                }

                if (newTask.TDList != null && oldTask.TDList != newTask.TDList)
                {
                    var oldList = FindListById(oldTask.ListId);
                    var newList = FindListById(newTask.TDList.ListId);
                    oldList.Tasks.Remove(oldTask);

                    oldTask.TDList = newTask.TDList;
                    oldTask.ListId = newTask.TDList.ListId;
                    newList.Tasks.Add(oldTask);

                    _context.Lists.Update(oldList);
                    _context.Lists.Update(newList);
                }

                _context.Tasks.Update(oldTask);
                _context.SaveChanges();
            }
        }

        public void UpdateStatus(int id, ToDoTask task)
        {
            CheckIdValidator(id);
            if (task is null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            var oldTask = FindTaskById(id);
            if (oldTask.TaskStatus != task.TaskStatus)
            {
                oldTask.TaskStatus = task.TaskStatus;
            }

            _context.Tasks.Update(oldTask);
            _context.SaveChanges();
        }

        public void Remind(int id, ToDoTask task)
        {
            CheckIdValidator(id);
            if (task is null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            var oldTask = FindTaskById(id);
            if(task.TaskRemindDate != null && oldTask.TaskRemindDate != task.TaskRemindDate)
            {
                oldTask.TaskRemindDate = task.TaskRemindDate;
            }

            _context.Tasks.Update(oldTask);
            _context.SaveChanges();
        }

        public void DeleteList(int listId)
        {
            CheckIdValidator(listId);

            var taskList = FindListById(listId);
            var allTask = ReturnTask(taskList);
            if (allTask != null)
            {
                _context.Tasks.RemoveRange(allTask);
            }

            _context.Lists.Remove(taskList);
            _context.SaveChanges();
        }

        public void DeleteTask(int taskId)
        {
            CheckIdValidator(taskId);
            var task = FindTaskById(taskId);

            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }

        public List<ToDoTask> ReturnTask(ToDoList list)
        {
            return _context.Tasks.Where(x => x.TDList == list).ToList();
        }

        public void CopyList(int id)
        {
            var oldList = FindListById(id);
            var oldTasks = ReturnTask(oldList);
            var list = new ToDoList { Name = oldList.Name };

            var listTask = oldList.Tasks;
            var b = "b";
            var e = "b";

            _context.Lists.Add(list);
            _context.SaveChanges();

            var allListWithSameName = _context.Lists.Where(x => x.Name.Equals(list.Name)).ToList();
            var copiedList = allListWithSameName.ElementAtOrDefault(allListWithSameName.Count - 1);
            var modifyTasks = new List<ToDoTask>();

            for (int i = 0; i < oldTasks.Count; i++)
            {
                var copyTask = new ToDoTask
                {
                    TaskStatus = oldTasks[i].TaskStatus,
                    TaskTitle = oldTasks[i].TaskTitle,
                    TaskCreationDate = oldTasks[i].TaskCreationDate,
                    TaskDueDate = oldTasks[i].TaskDueDate,
                    TaskDescription = oldTasks[i].TaskDescription,
                    ListId = copiedList.ListId,
                    TDList = copiedList
                };
                modifyTasks.Add(copyTask);
            }
            copiedList.Tasks = modifyTasks;

            _context.Lists.Update(copiedList);
            _context.SaveChanges();
        }

        public void CheckIdValidator(int id)
        {
            if (id < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }
        }

        public void CheckListValidator(ToDoList list)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (list.Name is null)
            {
                throw new ArgumentNullException(nameof(list.Name));
            }

            if (list.Name.Equals(string.Empty))
            {
                throw new ArgumentNullException(nameof(list.Name));
            }

            if (list.Name.Length > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(list.Name));
            }
        }

        public void CheckTaskValidator(ToDoTask task)
        {
            if (task is null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            if (task.TaskTitle is null)
            {
                throw new ArgumentNullException(nameof(task.TaskTitle));
            }

            if (task.TaskTitle.Equals(string.Empty))
            {
                throw new ArgumentNullException(nameof(task.TaskTitle));
            }

            if (task.TaskTitle.Length > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(task.TaskTitle));
            }

            if (task.TaskDescription != null && task.TaskDescription.Length > 2500)
            {
                throw new ArgumentOutOfRangeException(nameof(task.TaskDescription));
            }

            if (task.TaskTag != null && task.TaskTag.Length > 50)
            {
                throw new ArgumentOutOfRangeException(nameof(task.TaskTag));
            }
        }
        
    }
}
