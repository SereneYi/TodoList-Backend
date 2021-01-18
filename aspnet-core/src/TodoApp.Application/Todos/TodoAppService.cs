using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Todos.Dtos;
using Microsoft.EntityFrameworkCore;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;
using AutoMapper;

namespace TodoApp.Todos
{
    public class TodoAppService: TodoAppAppServiceBase, ITodoAppService
    {
        private readonly IRepository<Todo> _todoRepository;
        public TodoAppService(IRepository<Todo> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<ListResultDto<TodoListDto>> GetAll(GetTodosInput input)
        {
            var todos = await _todoRepository
                .GetAll()
                .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<TodoListDto>(
                ObjectMapper.Map<List<TodoListDto>>(todos)
            );

        }
        public async Task Delete(DeleteTodoInput input)
        {
            await _todoRepository.DeleteAsync(input.Id);
        }

        public async Task Update(UpdateTodoInput input)
        {
            var todo = await _todoRepository.FirstOrDefaultAsync(input.Id);
            todo.Title = input.Title;
            await _todoRepository.UpdateAsync(todo);
        }

        public async Task Create(CreateTodoInput input)
        {
            var todos = new Todo();
            todos.Title = input.Title;
            await _todoRepository.InsertAsync(todos);

        }
    }
}
