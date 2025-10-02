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
        public required string Title { get; set; }
        public DateTime DueDate { get; set; }
        public required string Description { get; set; }
        public required string Status { get; set; }  
    }
}
