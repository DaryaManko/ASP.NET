namespace Laboratorium_3._00.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<EmployeeOrganization> EmployeeOrganizations { get; set; }
        public ICollection<ContactOrganization> ContactOrganizations { get; set; }
    }
}