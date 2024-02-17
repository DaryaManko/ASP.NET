namespace Laboratorium_3._00.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birth { get; set; }

        public ICollection<ContactOrganization> ContactOrganizations { get; set; }
    }
}
