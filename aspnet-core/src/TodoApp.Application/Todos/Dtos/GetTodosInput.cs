using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Todos.Dtos
{
    public class GetTodosInput
    {
        public TaskState? State { get; set; }
    }
}
