using Data;
using System.Collections.Generic;

namespace Laboratorium_3._00.Models
{
    public interface IEmployeeService
    {
        int Add(Employee employee);
        void Delete(int id);
        void Update(Employee employee);
        List<Employee> FindAll();
        Employee FindById(int id);
        List<OrganizationEntity> FindAllOrganizationsForVieModel();
    }
}
