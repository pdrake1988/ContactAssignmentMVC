namespace ContactAssignmentMVC.Models
{
    public class ContactInfo
    {
        public ContactInfo(
            string name,
            string address,
            string city,
            int phoneNumber,
            string employer,
            string type
        )
        {
            Name = name;
            Address = address;
            City = city;
            PhoneNumber = phoneNumber;
            Employer = employer;
            Type = type;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public string Employer { get; set; }
        public string Type { get; set; }
    }
}
