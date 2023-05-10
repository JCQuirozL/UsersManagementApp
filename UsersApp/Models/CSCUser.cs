namespace UsersApp.Models
{
    public class CSCUser
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Position { get; set; }
        public String Department { get; set; }
        public int GroupId { get; set; }
    }

    public class CSCGroups
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }

        public IList<CSCUser> Users { get; set; }

    }
}
