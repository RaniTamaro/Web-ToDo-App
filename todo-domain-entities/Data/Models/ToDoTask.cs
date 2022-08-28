using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace todo_domain_entities.Data.Models
{
    public class ToDoTask
    {
        [Key]
        public int TaskId { get; set; }

        public Status TaskStatus { get; set; }

        [Required]
        [StringLength(100)]
        public string TaskTitle { get; set; }

        [StringLength(2500)]
        public string? TaskDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime TaskCreationDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? TaskDueDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? TaskRemindDate { get; set; }

        public string? TaskNotes { get; set; }

        [StringLength(50)]
        public string? TaskTag { get; set; }


        public int ListId { get; set; }

        public virtual ToDoList TDList { get; set; }
    }
}
