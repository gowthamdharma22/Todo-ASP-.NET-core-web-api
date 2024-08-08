namespace Todo.Api.Dtos
{
    public class LoginResponse(string email)
    {
        public string Email { get; set; } = email;
    }
}
