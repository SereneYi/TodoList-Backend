using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models.Todos;
using TodoApp.Todos;
using TodoApp.Todos.Dtos;

namespace TodoApp.Controllers
{
    public class TodosController : TodoAppControllerBase
    {
        private readonly ITodoAppService _todoAppService;

        public TodosController(ITodoAppService todoAppService)
        {
            _todoAppService = todoAppService;
        }

        public async Task<ActionResult> Index(GetTodosInput input)
        {
            var output = await _todoAppService.GetAll(input);
            var model = new IndexViewModel(output.Items);
            return View(model);
        }

    }
}
