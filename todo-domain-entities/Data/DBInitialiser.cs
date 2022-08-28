using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using todo_domain_entities.Context;
using todo_domain_entities.Data.Models;

namespace todo_domain_entities.Data
{
    public class DBInitialiser
    {
        public static void Seed(ToDoContext context)
        {
            if (!context.Lists.Any())
            {
                context.Lists.Add(new ToDoList { Name = "Homeworks", Tasks = new List<ToDoTask>() });
                context.Lists.Add(new ToDoList { Name = "Work", Tasks = new List<ToDoTask>() });
                context.Lists.Add(new ToDoList { Name = "Home", Tasks = new List<ToDoTask>() });

                context.SaveChanges();
            }

            if (!context.Tasks.Any())
            {
                var homeworkList = context.Lists.Where(x => x.Name.Equals("Homeworks")).FirstOrDefault();
                var workList = context.Lists.Where(x => x.Name.Equals("Work")).FirstOrDefault();

                homeworkList.Tasks = new List<ToDoTask>
                {
                    new ToDoTask { TaskStatus = Status.InProgress, TaskTitle = "English", TaskCreationDate = DateTime.Now, TDList = homeworkList, ListId = homeworkList.ListId },
                    new ToDoTask { TaskStatus = Status.NotStarted, TaskTitle = "Math", TaskCreationDate = DateTime.Now, TaskDueDate = new DateTime(2022, 8, 10), TDList = homeworkList, ListId = homeworkList.ListId },
                    new ToDoTask { TaskStatus = Status.InProgress, TaskTitle = "Art", TaskCreationDate = DateTime.Now, TDList = homeworkList, ListId = homeworkList.ListId },
                    new ToDoTask { TaskStatus = Status.Completed, TaskTitle = "Music", TaskCreationDate = DateTime.Now, TaskDueDate = new DateTime(2022, 7, 28), TDList = homeworkList, ListId = homeworkList.ListId }

                };

                workList.Tasks = new List<ToDoTask> { new ToDoTask { TaskStatus = Status.NotStarted, TaskTitle = "Big project", TaskDueDate = new DateTime(2022, 8, 31), TDList = workList, ListId = workList.ListId } };

                context.Lists.Update(homeworkList);
                context.Lists.Update(workList);
                context.SaveChanges();
            }

        }
    }
}
