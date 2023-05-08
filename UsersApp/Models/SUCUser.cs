namespace UsersApp.Models
{
    public class SUCUser
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public String UserName { get; set; }

        public int DepartmentId { get; set; }

        public DateTime InfoDate { get; set; }
    }

    public class SUCDepartments
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
