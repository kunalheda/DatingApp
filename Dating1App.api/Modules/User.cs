namespace Dating1App.api.Modules
{
    public class User
    {
        public int Id { get; set; }

        public string userName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        


    }
}