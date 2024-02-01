namespace StoreApp.Models
{
    public class AddUserModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public int ContactNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool Subscribed { get; set; }
    }
}
