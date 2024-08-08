using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Todo.api;
using Todo.api.Entities;
using Todo.api.Mapping;
using Todo.api.Repository;

namespace Todo.Api.Controllers;

[Route("api/todo")]
[ApiController]
[Authorize]
public class TodoController(ITodoRepository todoRepository) : ControllerBase
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    [HttpGet]
    public async Task<IActionResult> GetAllTodo()
    {
        var todos = await _todoRepository.GetAllTodo();
        return Ok(todos.Select(todo => todo.ToDto()).ToList());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTodoById([FromRoute] int id)
    {
        var todo = await _todoRepository.GetTodoById(id);
        if (todo == null)
        {
            return NotFound("Todo not found");
        }
        return Ok(todo.ToDto());
    }

    [HttpPost]
    public async Task<IActionResult> AddTodo([FromBody] TodoRequest todoRequest)
    {

        var todo = new Todos
        {
            Description = todoRequest.description,
            IsCompleted = todoRequest.isCompleted,
            UserId = todoRequest.userId,
        };
        await _todoRepository.AddTodo(todo);
        return Ok("Successfully Created");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTodo([FromRoute] int id, [FromBody] TodoRequest todoRequest)
    {
        var existingTodo = await _todoRepository.GetTodoById(id);
        if (existingTodo == null)
        {
            return NotFound("Todo not found");
        }
        existingTodo.Description = todoRequest.description;
        existingTodo.IsCompleted = todoRequest.isCompleted;
        existingTodo.UserId = todoRequest.userId;
        await _todoRepository.UpdateTodo(existingTodo);
        return Ok("Successfully Updated");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodo([FromRoute] int id)
    {
        var existingTodo = await _todoRepository.GetTodoById(id);
        if (existingTodo == null)
        {
            return NotFound("Todo not found");
        }
        await _todoRepository.DeleteTodo(id);
        return Ok("Successfully Deleted");
    }
}
