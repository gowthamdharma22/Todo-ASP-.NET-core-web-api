namespace Todo.api.Entities;

public class Todos
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public bool IsCompleted { get; set; }

    public string? UserId { get; set; }

    public User? User { get; set; }
}
