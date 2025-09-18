using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace TaskManager_ConsoleApp_Jacky
{
    
    public class TaskItem
    {
        public Guid Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }

        //create unique taskid (guid)

        public TaskItem(string title, string description, DateTime dueDate)
        {
            Id = Guid.NewGuid();
            this.Title = title;
            this.Description = description;
            this.DueDate = dueDate;
            Status = null;
            CreatedDate = DateTime.Now;
        }
    }
}
