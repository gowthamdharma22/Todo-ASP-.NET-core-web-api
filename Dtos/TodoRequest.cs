namespace Todo.api;

public record class TodoRequest(string userId, string description, bool isCompleted)
{
}
