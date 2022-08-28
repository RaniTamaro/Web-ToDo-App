using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using todo_domain_entities.Data.Models;

namespace todo_domain_entities.Services
{
    public interface IToDoService
    {
        List<ToDoList> GetAllToDoLists();

        List<ToDoTask> GetAllToDoTasks(ToDoList list);

        void AddList(ToDoList list);

        void AddTask(int listId, ToDoTask task);

        ToDoList FindListById(int id);

        ToDoTask FindTaskById(int id);

        void CopyList(int id);

        void ModifyList(int id, string newName);

        void ModifyTask(int id, ToDoTask newTask);

        void UpdateStatus(int id, ToDoTask task);

        void Remind(int id, ToDoTask task);

        public void DeleteList(int listId);

        public void DeleteTask(int taskId);
    }
}
