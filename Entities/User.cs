namespace movie_reservation_system.Entities
{
    public class User
    {
        public User(string phone, string firstName, string lastName, char sex, string email, string city)
        {
            Phone = phone;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Email = email;
            City = city;
        }

        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Sex { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}