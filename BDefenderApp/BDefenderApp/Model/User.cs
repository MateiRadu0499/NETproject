namespace BDefenderApp.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Affiliation { get; set; } = "None";
        public bool IsDeleted { get; set; }

        public void MarkAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
