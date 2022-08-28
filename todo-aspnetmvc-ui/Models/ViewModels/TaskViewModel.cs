using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using todo_domain_entities;
using todo_domain_entities.Data.Models;

namespace todo_aspnetmvc_ui.Models.ViewModels
{
    public class TaskViewModel
    {
        public List<ToDoList> ToDoLists { get; set; }

        public ToDoTask Task { get; set; }

        public int TaskId { get; set; }

        public Status TaskStatus { get; set; }

        [StringLength(200)]
        public string TaskTitle { get; set; }

        [StringLength(2500)]
        public string TaskDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TaskDueDate { get; set; }

        public string TaskNotes { get; set; }

        public string TaskTag { get; set; }
    }
}
