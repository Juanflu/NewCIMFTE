namespace NewCIMFTE.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public bool IsLoggedOn { get; set; }
    }
}
