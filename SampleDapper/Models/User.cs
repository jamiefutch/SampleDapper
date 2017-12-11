namespace SampleDapper.Models
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }

        public User()
        {
            Id = 0;
            UserName = string.Empty;
        }
    }
}