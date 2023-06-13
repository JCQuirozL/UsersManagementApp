namespace UsersApp.Models
{
    public class User2
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String UserName { get; set; }

        public String Email { get; set; }

        public DateTime Created { get; set; }

        public int DepartmentId { get; set; } = 1;
        public int TitleId { get; set; } = 1;

        public List<UsersInRoles> Roles { get; set; } = new();
        public int ApplicationId { get; set; } = 1;

        public Boolean IsActive { get; set; } = true;
        public Boolean IsBlocked { get; set; }

    }

    public class UsersInRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
    public class Application2
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public IList<Rol> Roles { get; set; }
    }
    public class Department2
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Boolean IsActive { get; set; }
        public IList<Title> TitlesList { get; set; }
    }
    public class Title2
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Boolean IsActive { get; set; }
    }

    public class Rol2
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Boolean IsActive { get; set; }

    }

    


}
