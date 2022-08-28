using NUnit.Framework;
using System;
using System.Linq;
using todo_domain_entities;
using todo_domain_entities.Context;
using todo_domain_entities.Data.Models;
using todo_domain_entities.Services;

namespace todo_app_tests
{
    public class Tests
    {
        private ToDoContext context;
        private ToDoService toDoService;

        private static object[] testLists =
        {
            new ToDoList() { Name = "TestList1" },
            new ToDoList() { Name = "TestList2" }
        };
        private static ToDoList testTaskList = new ToDoList { Name = "Homeworks" };
        private static object[] testTasks =
        {
            new object[]{ 1, new ToDoTask { TaskStatus = Status.NotStarted, TaskTitle = "TestTask6" } }
        };
        private static object[] testModifyTask =
        {
            new object[] { 1, new ToDoTask { TaskStatus = Status.NotStarted, TaskTitle = "TestTask1" } },
            new object[] { 2, new ToDoTask { TaskStatus = Status.InProgress, TaskTitle = "TestTask2", TaskDueDate = new DateTime(2022, 8, 10) } },
            new object[] { 3, new ToDoTask { TaskStatus = Status.InProgress, TaskTitle = "TestTask3" } }
        };

        [SetUp]
        public void Setup()
        {
            context = new ToDoContext();
            toDoService = new ToDoService(context);
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void FindListByIdTest(int id)
        {
            var listFromMethod = toDoService.FindListById(id);
            var listLinq = context.Lists.Where(x => x.ListId == id).Select(x => x.Name).FirstOrDefault();

            Assert.That(listFromMethod.Name, Is.EqualTo(listLinq));
        }
        
        [Test]
        [TestCase(999999)]
        [TestCase(int.MaxValue)]
        public void FindListByIdDontExistTest(int id)
        {
            Assert.Throws<ArgumentException>(
                () => toDoService.FindListById(id),
                message: "Method throws ArgumentNullException in case an list with this id don't exist");
        }

        [Test]
        [TestCase(-10)]
        [TestCase(-1)]
        [TestCase(0)]
        public void FindListByIdLessOneTest(int id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => toDoService.FindListById(id),
                message: "Method throws ArgumentNullException in case an id is less than one");
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void FindTaskByIdTest(int id)
        {
            var taskFromMethod = toDoService.FindTaskById(id);
            var taskLinq = context.Tasks.Where(x => x.TaskId == id).Select(x => x.TaskTitle).FirstOrDefault();

            Assert.That(taskFromMethod.TaskTitle, Is.EqualTo(taskLinq));
        }

        [Test]
        [TestCase(int.MaxValue)]
        public void FindTaskByIdDontExistTest(int id)
        {
            Assert.Throws<ArgumentException>(
                () => toDoService.FindTaskById(id),
                message: "Method throws ArgumentNullException in case an list with this id don't exist");
        }

        [Test]
        [TestCase(-10)]
        [TestCase(-1)]
        [TestCase(0)]
        public void FindTaskByIdLessOneTest(int id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => toDoService.FindTaskById(id),
                message: "Method throws ArgumentNullException in case an id is less than one");
        }

        [Test]
        [TestCaseSource(nameof(testLists))]
        public void AddListTest(ToDoList list)
        {
            toDoService.AddList(list);

            Assert.IsTrue(CheckListExist(list.ListId));
        }

        [Test]
        public void AddListNullTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.AddList(null),
                message: "Method throws ArgumentNullException in case an ToDoList is null");
        }

        [Test]
        public void AddListNullNameTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.AddList(new ToDoList { Name = null }),
                message: "Method throws ArgumentNullException in case an ToDoList Name is null");
        }

        [Test]
        public void AddListEmptyNameTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.AddList(new ToDoList { Name = string.Empty }),
                message: "Method throws ArgumentNullException in case an ToDoList Name is null");
        }

        [Test]
        public void AddListToLongNameTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => toDoService.AddList(new ToDoList { Name = new string('a', 101) }),
                message: "Method throws ArgumentOutOfRageException in case an ToDoList Name is too long");
        }

        [Test]
        [TestCaseSource(nameof(testTasks))]
        public void AddTaskTest(int listId, ToDoTask task)
        {
            toDoService.AddTask(listId, task);

            Assert.IsTrue(CheckTaskExist(task.TaskId));
        }

        [Test]
        public void AddTaskEmptyNameListTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.AddTask(1, new ToDoTask()),
                message: "Method throws ArgumentNullException in case an ToDoList Name is null");
        }

        [Test]
        public void AddTaskNullTaskTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.AddTask(1, null),
                message: "Method throws ArgumentNullException in case an ToDoTask is null");
        }

        [Test]
        public void AddTaskNullTaskTittleTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.AddTask(1, new ToDoTask { TaskTitle = null }),
                message: "Method throws ArgumentNullException in case an ToDoTask Title is null");
        }

        [Test]
        public void AddTaskEmptyTaskTitleTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.AddTask(1, new ToDoTask { TaskTitle = String.Empty }),
                message: "Method throws ArgumentNullException in case an ToDoList Name is null");
        }

        [Test]
        public void AddTaskToLongTaskTitleTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => toDoService.AddTask(1, new ToDoTask { TaskTitle = new string('*', 101) }),
                message: "Method throws ArgumentOutOfRageException in case an ToDoTask Title is too long");
        }

        [Test]
        public void AddTaskToLongTaskDescriptionTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => toDoService.AddTask(1, new ToDoTask { TaskTitle = "New Task", TaskDescription = new string('*', 2501) }),
                message: "Method throws ArgumentOutOfRageException in case an ToDoTask Description is too long");
        }

        [Test]
        public void AddTaskToLongTaskTagTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => toDoService.AddTask(1, new ToDoTask { TaskTitle = "New Task", TaskTag = new string('*', 51) }),
                message: "Method throws ArgumentOutOfRageException in case an ToDoTask Tag is too long");
        }

        [Test]
        public void GetAllToDoListsTest()
        {
            var listsFromMethod = toDoService.GetAllToDoLists();
            var listsLinq = context.Lists.Select(x => x).ToList();

            Assert.That(listsFromMethod, Is.EqualTo(listsLinq));
        }

        [Test]
        [TestCaseSource(nameof(testLists))]
        public void GetAllToDoTasksTest(ToDoList list)
        {
            var tasksFromMethod = toDoService.GetAllToDoTasks(list);
            var tasksLinq = context.Tasks.Where(x => x.TDList == list).ToList();

            Assert.That(tasksFromMethod, Is.EqualTo(tasksLinq));
        }

        [Test]
        [TestCase(1, "HomeWork1")]
        [TestCase(2, "Work2")]
        public void ModifyListTest(int id, string newName)
        {
            toDoService.ModifyList(id, newName);

            Assert.IsTrue(CheckListExist(id));
        }

        [Test]
        [TestCase(int.MinValue, "HomeWork1")]
        [TestCase(0, "HomeWork1")]
        [TestCase(-2, "HomeWork1")]
        public void ModifyListLessOneIdTest(int id, string newName)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => toDoService.ModifyList(id, newName),
                message: "Method throws ArgumentNullException in case an id is less than one");
        }

        [Test]
        [TestCase(999999, "Homework1")]
        [TestCase(int.MaxValue, "Homework1")]
        public void ModifyListDontExistTest(int id, string newName)
        {
            Assert.Throws<ArgumentException>(
                () => toDoService.ModifyList(id, newName),
                message: "Method throws ArgumentNullException in case an list with this id don't exist");
        }

        [Test]
        public void ModifyListNullNameTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.ModifyList(1, null),
                message: "Method throws ArgumentNullException in case an new name is null");
        }

        [Test]
        public void ModifyListEmptyNameTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.ModifyList(1, string.Empty),
                message: "Method throws ArgumentNullException in case an new name is empty");
        }

        [Test]
        [TestCaseSource(nameof(testModifyTask))]
        public void ModifyTaskTest(int id, ToDoTask newTask)
        {
            toDoService.ModifyTask(id, newTask);

            Assert.IsTrue(CheckTaskExist(id));
        }

        [Test]
        public void ModifyTaskLessOneIdTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => toDoService.ModifyTask(0, new ToDoTask()),
                message: "Method throws ArgumentNullException in case an id is less than one");
        }

        [Test]
        public void ModifyTaskNullTaskTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.ModifyTask(1, null),
                message: "Method throws ArgumentNullException in case an ToDoTask is null");
        }

        [Test]
        public void ModifyTaskNullTaskTitleTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.ModifyTask(1, new ToDoTask { TaskTitle = null }),
                message: "Method throws ArgumentNullException in case an ToDoTask Title is null");
        }

        [Test]
        public void ModifyTaskEmptyTaskTitleTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.ModifyTask(1, new ToDoTask { TaskTitle = String.Empty }),
                message: "Method throws ArgumentNullException in case an ToDoList Name is null");
        }

        [Test]
        [TestCaseSource(nameof(testModifyTask))]
        public void UpdateStatusTest(int id, ToDoTask task)
        {
            toDoService.UpdateStatus(id, task);
            var newStatus = task.TaskStatus;
            var statusFromTask = toDoService.FindTaskById(id).TaskStatus;

            Assert.That(statusFromTask, Is.EqualTo(newStatus));
        }

        [Test]
        public void UpdateStatusLessOneIdTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => toDoService.UpdateStatus(0, new ToDoTask()),
                message: "Method throws ArgumentNullException in case an id is less than one");
        }

        [Test]
        public void UpdateStatusNullTaskTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => toDoService.UpdateStatus(1, null),
                message: "Method throws ArgumentNullException in case an ToDoTask is null");
        }

        public bool CheckListExist(int id)
        {
            var findList = context.Lists.Where(x => x.ListId == id).FirstOrDefault();
            if (findList is null)
            {
                return false;
            }

            return true;
        }

        public bool CheckTaskExist(int taskId)
        {
            var findTask = context.Tasks.Where(x => x.TaskId == taskId);
            if (findTask is null)
            {
                return false;
            }

            return true;
        }
    }
}