using Microsoft.AspNetCore.Identity;

namespace Todo.api.Entities;

public class User : IdentityUser
{
    public List<Todos>? Todos { get; set; }

}
