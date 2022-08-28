using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using todo_domain_entities;
using todo_domain_entities.Data.Models;

namespace todo_aspnetmvc_ui.Models.ViewModels
{
    public class TaskDetailsViewModel
    {
        public List<ToDoList> ToDoLists { get; set; }

        public ToDoTask Task { get; set; }

        public int TaskId { get; set; }

        public Status TaskStatus { get; set; }

        public string TaskTitle { get; set; }

        public string? TaskDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TaskDueDate { get; set; }
    }
}