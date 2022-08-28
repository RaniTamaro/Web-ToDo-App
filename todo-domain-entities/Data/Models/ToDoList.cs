using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace todo_domain_entities.Data.Models
{
    public class ToDoList
    {
        [Key]
        public int ListId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public virtual List<ToDoTask> Tasks { get; set; }
    }
}
