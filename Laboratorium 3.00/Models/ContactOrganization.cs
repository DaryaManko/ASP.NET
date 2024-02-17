namespace Laboratorium_3._00.Models
{
    public class ContactOrganization
    {
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
