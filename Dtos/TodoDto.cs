namespace Todo.api.Dtos;

public record class TodoDto(int id,string description,bool isCompleted=false);
