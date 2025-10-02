using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }  

        public TaskItem(string title, string description, DateTime dueDate, string status)
        {
            Id= Guid.NewGuid();
            this.Title = title;
            this.Description = description;
            this.DueDate = dueDate;
            this.Status = status;
            CreatedDate = DateTime.Now;
        }
    }
}
