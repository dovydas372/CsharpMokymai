namespace paskaita_11_praktika_API_part2.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public int Id { get; set; }

        public User(string name, string email )
        {
            Name = name;
            Email = email;
         
        }
    }
}
