using Todo.api.Entities;

namespace Todo.api.Repository;

public interface ITodoRepository
{
    Task<List<Todos>> GetAllTodo();
    Task<Todos?> GetTodoById(int id);
    Task AddTodo(Todos todo);
    Task UpdateTodo(Todos todo);
    Task DeleteTodo(int id);
}
