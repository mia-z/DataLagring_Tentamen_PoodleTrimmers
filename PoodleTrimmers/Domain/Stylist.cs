namespace PoodleTrimmers.Domain
{
    public class Stylist
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Handle { get; set; }
        public int SocialSecurityNumber { get; set; }

        public Stylist()
        {
            //EMPTY CONSTRUCTOR MEMERY
        }

        public Stylist(string firstName, string lastName, string handle, int ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Handle = handle;
            SocialSecurityNumber = ssn;
        }
    }
}