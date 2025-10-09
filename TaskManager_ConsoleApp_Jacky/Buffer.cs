using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Buffers;

namespace TaskManager_ConsoleApp_Jacky
{

    public class Buffer
    {
        
        public string? createName { get; set; }
        public string? createDescription { get; set; }
        public string? createDueDate { get; set; }

        public string ViewTaskUserChoice { get; set; }
        public string newName { get; set; }
        public string newStatus { get; set; }
        public string newDescription { get; set; }
        public string newDueDate { get; set; }

        //clean data method
        public void clearCreateData()
        {
           
            createName = null;
            createDescription = null;
            createDueDate = null;
            
        }
    }
}
