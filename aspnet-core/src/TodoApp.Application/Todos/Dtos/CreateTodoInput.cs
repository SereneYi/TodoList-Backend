using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Todos.Dtos
{
    public class CreateTodoInput
    {
        public string Title { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }
    }
}
