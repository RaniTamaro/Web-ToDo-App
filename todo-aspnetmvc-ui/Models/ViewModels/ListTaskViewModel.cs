using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using todo_domain_entities.Data.Models;

namespace todo_aspnetmvc_ui.Models.ViewModels
{
    public class ListTaskViewModel
    {
        public ToDoList TDList { get; set; }

        public IEnumerable<ToDoTask> Tasks { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TaskDueDate { get; set; }
    }
}
