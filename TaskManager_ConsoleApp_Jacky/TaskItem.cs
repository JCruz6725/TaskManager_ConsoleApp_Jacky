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
        public DateTime DueDate { get; init; }
        public string Description { get; set; }
        public bool isOpen { get; set; }  //Status

        public TaskItem(string title, string description)
        {
            Id= Guid.NewGuid();
            this.Title = title;
            this.Description = description;
            isOpen = true;
            CreatedDate = DateTime.Now;
        }


        //Temporary Overloaded Constructor for Initialization Purposes
        public TaskItem (string title, string description, bool status)
        {
            Id = Guid.NewGuid();
            this.Title = title;
            this.Description = description;
            isOpen = status;
            CreatedDate = DateTime.Now;
        }
    }
}
