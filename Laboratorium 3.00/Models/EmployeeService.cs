using Data;

namespace Laboratorium_3._00.Models
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDateTimeProvider _timeProvider;
        private readonly Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();
        private int _nextId = 1;

        public EmployeeService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public int Add(Employee employee)
        {
            int id = _nextId++;
            employee.Id = id;
            employee.Created = _timeProvider.GetCurrentDateTime();
            _employees[id] = employee;
            return id;
        }

        public void Delete(int id)
        {
            if (_employees.ContainsKey(id))
            {
                _employees.Remove(id);
            }
        }

        public void Update(Employee employee)
        {
            if (_employees.ContainsKey(employee.Id))
            {
                _employees[employee.Id] = employee;
                employee.Updated = _timeProvider.GetCurrentDateTime();
            }
        }

        public List<Employee> FindAll()
        {
            return _employees.Values.ToList();
        }

        public Employee FindById(int id)
        {
            _employees.TryGetValue(id, out Employee employee);
            return employee;
        }

        public List<OrganizationEntity> FindAllOrganizationsForVieModel()
        {
            throw new NotImplementedException();
        }
    }
}
