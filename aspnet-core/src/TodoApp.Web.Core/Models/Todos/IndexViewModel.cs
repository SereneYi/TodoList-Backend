using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Todos.Dtos;
using TodoApp.Todos;

namespace TodoApp.Models.Todos
{
    public class IndexViewModel
    {
        public IReadOnlyList<TodoListDto> Todos { get; }
        public IndexViewModel(IReadOnlyList<TodoListDto> todos)
        {
        Todos = todos;

        }

    public string GetTaskLabel(TodoListDto todo)
    {
        switch (todo.State)
        {
            case TaskState.Open:
                return "label-success";
            default:
                return "label-default";
        }
    }
}    
}
