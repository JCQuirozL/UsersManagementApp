namespace UsersApp.Models
{
    public class User
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public int DepartmentId { get; set; }
        public int TitleId { get; set; }

        public int RolId { get; set; }

        public int ApplicationId { get; set; }

        public Boolean IsActive { get; set; }
    }

    public class Application
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public IList<Rol> Roles { get; set; }
    }
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public IList<Title> TitlesList { get; set; }
    }
    public class Title
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }

    public class Rol
    {
        public int Id { get; set; }
        public String Name { get; set; }

    }

    


}
