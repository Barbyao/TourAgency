using Microsoft.AspNetCore.Identity;

namespace Web.Models.Identity
{
    public enum GenderType { Male, Female, Binary, Doter}

    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { set; get; }
        public string County { set; get; }
        public DateTime Birthday { set; get; }
        public GenderType Gender { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
        public byte[] ProfilePicture { get; set; }
    }
}
