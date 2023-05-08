namespace UsersApp.Models
{
    public class DEUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public int RolId { get; set; }
        
        public Boolean EsJefeInmediato { get; set; }

        public DateTime InfoDate { get; set; }

        public String CreadoPor { get; set; }
    }

    public class DEDepartments
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }

    public class DERol
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
