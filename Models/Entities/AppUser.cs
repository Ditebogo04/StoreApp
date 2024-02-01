namespace StoreApp.Models.Entities
{
    public class AppUser 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public int ContactNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; } 
        public bool Subscribed { get; set; }
        //public string UserEmail { get; set; } = string.Empty;
        //public string UserPassword { get; set; } = string.Empty;
        //public string EmailConfirmed { get; set; }
        //public string PasswordConfirmed { get; set; }
        //public string UserEmailConfirmed { get; set; } = string.Empty;
    }
}
