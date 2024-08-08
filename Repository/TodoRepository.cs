

using Microsoft.EntityFrameworkCore;
using Todo.api.Data;
using Todo.api.Entities;

namespace Todo.api.Repository;

public class TodoRepository(TodoContext dbContext) : ITodoRepository
{
    private readonly TodoContext dbContext = dbContext;
    public async Task AddTodo(Todos todo)
    {
        dbContext.Todos.Add(todo);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteTodo(int id)
    {
        await dbContext.Todos
                        .Where(todo => todo.Id == id)
                        .ExecuteDeleteAsync();
    }

    public async Task<List<Todos>> GetAllTodo()
    {
        return await dbContext.Todos.Include(t => t.User).AsNoTracking().ToListAsync();
    }

    public async Task<Todos?> GetTodoById(int id)
    {
        return await dbContext.Todos.FindAsync(id);
    }

    public async Task UpdateTodo(Todos todo)
    {
        dbContext.Todos.Update(todo);
        await dbContext.SaveChangesAsync();
    }
}
