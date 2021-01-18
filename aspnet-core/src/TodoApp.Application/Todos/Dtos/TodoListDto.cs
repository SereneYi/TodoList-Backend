using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Todos.Dtos
{
    [AutoMapFrom(typeof(Todo))]
    public class TodoListDto
    {
        public string Title { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }
    }
}
