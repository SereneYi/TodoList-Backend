using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Todos.Dtos;

namespace TodoApp.Todos
{
    public interface ITodoAppService: IApplicationService
    {
        Task<ListResultDto<TodoListDto>> GetAll(GetTodosInput input);
    }
}
