namespace Todo.api.Dtos;

public record class TodoResponse(int id, string description, bool isCompleted, string userId);
